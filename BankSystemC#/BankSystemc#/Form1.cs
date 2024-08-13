namespace BankSystemc_
{
    public partial class HomePage : Form
    {
        public HomePage(bool SkipResources = false)
        {
            if (!SkipResources)
            {

            InitializeComponent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Financial_Transactions ft = new Financial_Transactions();
            this.Close();
            ft.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Account_Management am = new Account_Management();
            this.Close();
            am.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            AccountService am = new AccountService();
            this.Close();
            am.Show();
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            Account_Management am = new Account_Management();
            this.Close();
            am.Show();
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            AccountService am = new AccountService();
            this.Close();
            am.Show();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Financial_Transactions ft = new Financial_Transactions();
            this.Close();
            ft.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
