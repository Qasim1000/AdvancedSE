using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystemc_
{

    public partial class Financial_Transactions : Form
    {


         SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;");

        public Financial_Transactions(bool SkipResources = false)
        {
            if (!SkipResources)
            {
                InitializeComponent();
            }
        }

        public void Financial_Transactions_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
            LoadAccountInformation();
        }
        public void LoadAccountInformation()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Query to get the last login account number from the login_log table
                string query = "SELECT TOP 1 account_number FROM login_log ORDER BY login_time DESC";
                SqlCommand command = new SqlCommand(query, conn);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string accountNumber = result.ToString();
                    // Assuming `account` is the name of your TextBox control
                    accountd.Text = accountNumber;
                    accountt.Text = accountNumber;
                    accountw.Text = accountNumber;

                    // Retrieve account details using the obtained account number

                }
                else
                {
                    MessageBox.Show("No account information found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }



        public void LoadTransactionHistory()
        {
            try
            {
                conn.Open();
                string query = "SELECT account_number, transaction_type, amount, timestamp FROM transaction_history ORDER BY timestamp DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading transaction history: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void RecordTransaction(string accountNumber, string transactionType, decimal amount)
        {
            if (!int.TryParse(balanced.Text, out int parsedBalance))
            {
                MessageBox.Show("Please enter a valid integer for the balance.");
                return; // Exit the method if balance is not a valid integer
            }
            if (!int.TryParse(balancet.Text, out int parsedBalancet))
            {
                MessageBox.Show("Please enter a valid integer for the balance.");
                return; // Exit the method if balance is not a valid integer
            }
            if (!int.TryParse(balancew.Text, out int parsedBalancew))
            {
                MessageBox.Show("Please enter a valid integer for the balance.");
                return; // Exit the method if balance is not a valid integer
            }
            try
            {
                conn.Open();
                string query = "INSERT INTO transaction_history (account_number, transaction_type, amount, timestamp) VALUES (@AccountNumber, @TransactionType, @Amount, GETDATE())";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@AccountNumber", accountNumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", transactionType));
                command.Parameters.Add(new SqlParameter("@Amount", amount));

                command.ExecuteNonQuery();
                MessageBox.Show("Transaction recorded successfully.");
                LoadTransactionHistory(); // Refresh the DataGridView after recording a transaction
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void Deposit(string accountNumber, decimal amount)
        {
            try
            {
                conn.Open();
                string query = "UPDATE account SET Balance = Balance + @Amount WHERE AccountNumber = @AccountNumber";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Amount", amount));
                command.Parameters.Add(new SqlParameter("@AccountNumber", accountNumber));

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deposit successful.");
                    RecordTransaction(accountNumber, "Deposit", amount);
                }
                else
                {
                    MessageBox.Show("Account not found. Deposit failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void Withdraw(string accountNumber, decimal amount)
        {
            try
            {
                conn.Open();
                string query = "UPDATE account SET Balance = Balance - @Amount WHERE AccountNumber = @AccountNumber";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Amount", amount));
                command.Parameters.Add(new SqlParameter("@AccountNumber", accountNumber));

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Withdrawal successful.");
                    RecordTransaction(accountNumber, "Withdraw", amount);
                }
                else
                {
                    MessageBox.Show("Account not found. Withdrawal failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void Transfer(string fromAccount, string toAccount, decimal amount)
        {
            try
            {
                conn.Open();

                // Begin a transaction
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Withdraw from the fromAccount
                    string withdrawQuery = "UPDATE account SET Balance = Balance - @Amount WHERE AccountNumber = @AccountNumber";
                    SqlCommand withdrawCommand = new SqlCommand(withdrawQuery, conn, transaction);
                    withdrawCommand.Parameters.Add(new SqlParameter("@Amount", amount));
                    withdrawCommand.Parameters.Add(new SqlParameter("@AccountNumber", fromAccount));
                    withdrawCommand.ExecuteNonQuery();

                    // Deposit to the toAccount
                    string depositQuery = "UPDATE account SET Balance = Balance + @Amount WHERE AccountNumber = @AccountNumber";
                    SqlCommand depositCommand = new SqlCommand(depositQuery, conn, transaction);
                    depositCommand.Parameters.Add(new SqlParameter("@Amount", amount));
                    depositCommand.Parameters.Add(new SqlParameter("@AccountNumber", toAccount));
                    depositCommand.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                    MessageBox.Show("Transfer successful.");

                    // Record the transactions
                    RecordTransaction(fromAccount, "Transfer Out", amount);
                    RecordTransaction(toAccount, "Transfer In", amount);
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an error occurs
                    transaction.Rollback();
                    MessageBox.Show($"An error occurred during the transfer: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void depositButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountd.Text; // Assuming this is the TextBox for account number
            if (decimal.TryParse(balanced.Text, out decimal amount)) // Assuming this is the TextBox for deposit amount
            {
                Deposit(accountNumber, amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        public void withdrawButton_Click(object sender, EventArgs e)
        {
            string accountNumber = accountd.Text; // Assuming this is the TextBox for account number
            if (decimal.TryParse(balanced.Text, out decimal amount)) // Assuming this is the TextBox for withdrawal amount
            {
                Withdraw(accountNumber, amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        public void transferButton_Click(object sender, EventArgs e)
        {
            string fromAccount = accountt.Text; // Assuming this is the TextBox for the sender's account number
            string toAccount = taccountt.Text; // Assuming this is the TextBox for the receiver's account number
            if (decimal.TryParse(balancet.Text, out decimal amount)) // Assuming this is the TextBox for transfer amount
            {
                Transfer(fromAccount, toAccount, amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {

            HomePage pg = new HomePage();
            this.Close();
            pg.Show();
        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepsoitCash_Click(object sender, EventArgs e)
        {

        }
    }
}
