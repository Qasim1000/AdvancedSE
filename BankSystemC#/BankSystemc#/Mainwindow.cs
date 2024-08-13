using System;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class Mainwindow : Form
    {
        public Mainwindow()
        {
            InitializeComponent();
        }

        private void mainwindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                // Show the Login form
                Login lg = new Login();
                lg.Show();
                // Close the main window
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Override the OnFormClosing method
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the application from exiting
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
