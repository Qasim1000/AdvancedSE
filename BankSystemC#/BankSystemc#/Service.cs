using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class Service : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=M1ST\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;");

        public Service()
        {
            InitializeComponent();
            servicetype.Items.AddRange(new string[] { "CheckBook", "CreditCard", "DebitCard" });
            servicetype.SelectedIndexChanged += servicetype_SelectedIndexChanged;
        }

        private void back_Click(object sender, EventArgs e)
        {
            AccountService ac = new AccountService();
            this.Close();
            ac.Show();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            LoadServiceData();
            
        }

        private void servicetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event if needed
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (servicetype.SelectedItem != null)
            {
                string serviceDetail = servicetype.SelectedItem.ToString(); // Assuming servicetype is the ComboBox control for service type
                string detailedService = servicedetailed.Text; // Assuming servicedetailed is the TextBox control for service details

                if (!string.IsNullOrEmpty(detailedService))
                {
                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string query = "INSERT INTO service (ServiceDetail, Status) VALUES (@ServiceDetail, 'Pending')";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ServiceDetail", serviceDetail + ": " + detailedService);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Service request submitted successfully.");
                                LoadServiceData(); // Load data into DataGridView after successful submission
                            }
                            else
                            {
                                MessageBox.Show("Failed to submit service request.");
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
                    MessageBox.Show("Please fill in the service details.");
                }
            }
            else
            {
                MessageBox.Show("Please select a service type.");
            }
        }

        private void LoadServiceData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM service";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
