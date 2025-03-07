﻿using System;
using System.Linq;
using System.Net.NetworkInformation;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace BankSystemc_
{
    public partial class CreateAccount : Form
    {
        private Random random = new Random();

        public CreateAccount()
        {
            InitializeComponent();

            
            accounttype.Items.AddRange(new string[] { "Personal", "Business" });
            accounttype.SelectedIndexChanged += accounttype_SelectedIndexChanged;
        }

        SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;TrustServerCertificate=True ");
       
        private ErrorProvider errorProvider = new ErrorProvider();

        private void Createacccount_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(fathername.Text) ||
                string.IsNullOrWhiteSpace(address.Text) ||
                string.IsNullOrWhiteSpace(mobilenumber.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                string.IsNullOrWhiteSpace(confirmpasword.Text) ||
                string.IsNullOrWhiteSpace(accountnumber.Text) ||
                string.IsNullOrWhiteSpace(balance.Text) ||
                string.IsNullOrWhiteSpace(macaddress.Text) ||
                accounttype.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return; 
            }

            
            if (password.Text != confirmpasword.Text)
            {
                MessageBox.Show("Passwords and Confirm Password do not match. Please re-enter your password.");
                return; 
            }
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return; 
            }
            if (!int.TryParse(balance.Text, out int parsedBalance))
            {
                MessageBox.Show("Please enter a valid integer for the balance.");
                return; 
            }

            try
            {
                conn.Open();
                string q = "INSERT INTO account (Name, FatherName, Address, MobileNumber, Email, Password, AccountNumber, AccountType, Balance, MAC_Address) VALUES (@Name, @FatherName, @Address, @MobileNumber, @Email, @Password, @AccountNumber, @AccountType, @Balance, @MAC_Address)";
                SqlCommand command = new SqlCommand(q, conn);
                command.Parameters.Add(new SqlParameter("@Name", name.Text));
                command.Parameters.Add(new SqlParameter("@FatherName", fathername.Text));
                command.Parameters.Add(new SqlParameter("@Address", address.Text));
                command.Parameters.Add(new SqlParameter("@MobileNumber", mobilenumber.Text));
                command.Parameters.Add(new SqlParameter("@Email", email.Text));
                command.Parameters.Add(new SqlParameter("@Password", password.Text));
                command.Parameters.Add(new SqlParameter("@AccountNumber", accountnumber.Text)); 
                command.Parameters.Add(new SqlParameter("@AccountType", accounttype.SelectedItem.ToString())); 
                command.Parameters.Add(new SqlParameter("@Balance", balance.Text));
                command.Parameters.Add(new SqlParameter("@MAC_Address", macaddress.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("Account created successfully.");
                Login lg = new Login();
                lg.Show();
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

        public void GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == string.Empty) 
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            macaddress.Text = sMacAddress;
        }

        private void macaddress_TextChanged(object sender, EventArgs e)
        {
            GetMACAddress();
        }

        private string GenerateAccountNumber()
        {
            
            if (accounttype.SelectedItem?.ToString() == "Personal")
            {
                return "abl" + new string(Enumerable.Repeat("0123456789", 14)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            else if (accounttype.SelectedItem?.ToString() == "Business")
            {
                return "abl" + new string(Enumerable.Repeat("0123456789", 14)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }

            return string.Empty;
        }

        private void UpdateAccountNumber()
        {
           
            string accountType = accounttype.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(accountType))
            {
                accountnumber.Text = GenerateAccountNumber();
            }
        }

        private void accounttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            UpdateAccountNumber();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

            
        }
        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string emaile = email.Text;
            if (!IsValidEmail(emaile))
            {
                e.Cancel = true;
                errorProvider.SetError(email, "Invalid email format.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(email, string.Empty);
            }
        }

        private bool IsValidEmail(string email)
        {
            
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

    }
}
