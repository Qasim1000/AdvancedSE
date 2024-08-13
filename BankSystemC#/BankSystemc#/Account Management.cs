using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class Account_Management : Form
    {
        public Account_Management()
        {
            InitializeComponent();
        }

        private void Account_Management_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage b = new HomePage();
            this.Close();
            b.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Update ud = new Update();
            this.Close();
            ud.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            this.Close();
            dl.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Account_Information ai = new Account_Information();
            this.Close();
            ai.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Update ud = new Update();
            this.Close();
            ud.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Account_Information ai = new Account_Information();
            this.Close();
            ai.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            this.Close();
            dl.Show();
        }
    }
}
