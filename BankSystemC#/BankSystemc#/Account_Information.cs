using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace BankSystemc_
{
    public partial class Account_Information : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;");

        public Account_Information()
        {
            InitializeComponent();
        }

        private void Account_Information_Load(object sender, EventArgs e)
        {
            LoadAccountInformation();
        }

        private void LoadAccountInformation()
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
                    account.Text = accountNumber;
                    // Retrieve account details using the obtained account number
                    DisplayAccountDetails(accountNumber);
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

        private void DisplayAccountDetails(string accountNumber)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Query to get the account details from the account table
                string query = "SELECT * FROM account WHERE AccountNumber = @AccountNumber";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@AccountNumber", accountNumber));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dataGridView1 is the DataGridView control on your form
                dataGridView1.DataSource = dataTable;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Account_Management am = new Account_Management();
            this.Close();
            am.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Account_Management am = new Account_Management();
            this.Close();
            am.Show();  
        }
    }
}
