﻿using System;
using System.Data;

using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace BankSystemc_
{
    public partial class Delete : Form
    {
        public SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;");

        public Delete(bool SkipResources = false)
        {
            if (SkipResources)
            {
                InitializeComponent();
            }
        }

        public void Delete_Load(object sender, EventArgs e)
        {

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


        public void DeleteAccount(string accountNumber)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE FROM account WHERE AccountNumber = @AccountNumber";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.Add(new SqlParameter("@AccountNumber", accountNumber));
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account deleted successfully.");
                        accountnumber.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No account found with the specified account number.");
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

        public void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = accountnumber.Text;
            if (!string.IsNullOrEmpty(accountNumber))
            {
                DeleteAccount(accountNumber);
            }
            else
            {
                MessageBox.Show("Please enter an account number.");
            }
        }

        public void Delete_Load_1(object sender, EventArgs e)
        {
            LoadAccountInformation();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Account_Management am = new Account_Management();
            this.Close();
            am.Show();

        }

        public void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
