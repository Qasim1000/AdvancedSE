using System;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class Otp : Form
    {
        private string generatedOtp;
        private DateTime generatedTimestamp;
        private const int OTP_VALIDITY_DURATION = 60; // in seconds

        public Otp(string otp, DateTime timestamp)
        {
            InitializeComponent();
            generatedOtp = otp;
            generatedTimestamp = timestamp;
        }

        private void otpverify_Click(object sender, EventArgs e)
        {
            // Get the entered OTP from the textbox
            string enteredOtp = txtotp.Text;

            // Check if the OTP has expired
            TimeSpan timeElapsed = DateTime.Now - generatedTimestamp;
            if (timeElapsed.TotalSeconds > OTP_VALIDITY_DURATION)
            {
                MessageBox.Show("OTP has expired. Please go back to Login page to request a new OTP.");
                return;
            }

            // Check if the entered OTP matches the generated OTP
            if (enteredOtp == generatedOtp)
            {
                MessageBox.Show("OTP verified successfully.");
                HomePage pg = new HomePage();
                pg.Show();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private void otp_Load(object sender, EventArgs e)
        {

        }

        private void txtotp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lgn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
