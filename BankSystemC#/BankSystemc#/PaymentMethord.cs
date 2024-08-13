using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class PaymentMethord : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;");

        public PaymentMethord()
        {
            InitializeComponent();
            type.Items.AddRange(new string[] { "Direct Debit", "RepeatPay" });
            type.SelectedIndexChanged += type_SelectedIndexChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountService service = new AccountService();
            this.Close();
            service.Show();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paymentType = type.SelectedItem.ToString(); // Assuming you have a ComboBox for payment type
            string paymentDetails = detail.Text; // Assuming you have a TextBox for payment details
            string paymentAmount = amount.Text; // Assuming you have a TextBox for payment amount

            if (!string.IsNullOrEmpty(paymentType) && !string.IsNullOrEmpty(paymentDetails) && !string.IsNullOrEmpty(paymentAmount))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "INSERT INTO Payment (Type, Details, Amount, SetupDateTime) VALUES (@Type, @Details, @Amount, @SetupDateTime)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", paymentType);
                        cmd.Parameters.AddWithValue("@Details", paymentDetails);
                        cmd.Parameters.AddWithValue("@Amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@SetupDateTime", DateTime.Now);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment details submitted successfully.");
                            LoadPaymentData(); // Load data into DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit payment details.");
                        }
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
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void PaymentMethord_Load(object sender, EventArgs e)
        {
            LoadAccountInformation();
            LoadPaymentData(); // Load data into DataGridView on form load
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                    // Assuming `acn` is the name of your TextBox control
                    acn.Text = accountNumber;
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

        private void LoadPaymentData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT Type, Details, Amount, SetupDateTime FROM Payment";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Assuming dataGridView1 is the name of your DataGridView control
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

        private void acn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
