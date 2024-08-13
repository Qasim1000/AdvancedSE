using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class Update : Form
    {
        public SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;");
        public Random random = new Random();

        public Update(bool SkipResources = false)
        {
            if (SkipResources)
            {
                InitializeComponent();
            }
            accounttype.Items.AddRange(new string[] { "Personal", "Business" });
            accounttype.SelectedIndexChanged += accounttype_SelectedIndexChanged;


            button1.Click += buttonUpdate_Click;
        }

        public void Update_Load(object sender, EventArgs e)
        {

            LoadAccountInformation();
            populatefeild();
        }

        public void LoadAccountInformation()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }


                string query = "SELECT TOP 1 account_number FROM login_log ORDER BY login_time DESC";
                SqlCommand command = new SqlCommand(query, conn);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string accountNumber = result.ToString();

                    accountnumber.Text = accountNumber;


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

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void accounttype_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateAccountNumber();
        }

        public string GenerateAccountNumber()
        {

            if (accounttype.SelectedItem?.ToString() == "Personal" || accounttype.SelectedItem?.ToString() == "Business")
            {
                return "abl" + new string(Enumerable.Repeat("0123456789", 14)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }

            return string.Empty;
        }

        public void UpdateAccountNumber()
        {

            string accountType = accounttype.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(accountType))
            {
                accountnumber.Text = GenerateAccountNumber();
            }
        }

        public void UpdateAccount(string accountNumber, string newAccountType, string email, string mobileNumber, string password)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "UPDATE account SET AccountType = @AccountType, MobileNumber = @MobileNumber, Email = @Email, Password = @Password WHERE AccountNumber = @AccountNumber";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.Add(new SqlParameter("@AccountType", newAccountType));
                    command.Parameters.Add(new SqlParameter("@MobileNumber", mobileNumber));
                    command.Parameters.Add(new SqlParameter("@Email", email));
                    command.Parameters.Add(new SqlParameter("@Password", password));
                    command.Parameters.Add(new SqlParameter("@AccountNumber", accountNumber));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account updated successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            string accountNumber = accountnumber.Text;
            string newAccountType = accounttype.SelectedItem?.ToString();
            string emaill = email.Text;
            string mobileNumber = mobilenumber.Text;
            string passwordd = password.Text;

            if (!string.IsNullOrEmpty(accountNumber) &&
                !string.IsNullOrEmpty(newAccountType) &&
                !string.IsNullOrEmpty(emaill) &&
                !string.IsNullOrEmpty(mobileNumber) &&
                !string.IsNullOrEmpty(passwordd))
            {
                UpdateAccount(accountNumber, newAccountType, emaill, mobileNumber, passwordd);
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        public void LoadInitialAccountInfo()
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Account_Management am = new Account_Management();
            this.Close();
            am.Show();
        }

        public void populatefeild()
        {
            string q = "select MobileNumber, Email, Password, AccountType from account";
            SqlCommand cmd = new SqlCommand(q, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mobilenumber.Text = reader["MobileNumber"].ToString();
                    email.Text = reader["Email"].ToString();
                    password.Text = reader["Password"].ToString();
                    accounttype.Text = reader["AccountType"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
