using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemc_
{
    public partial class AccountService : Form
    {
        public AccountService()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            this.Close();
            hm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            this.Close();
            service.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentMethord paymentMethord = new PaymentMethord();
            this.Close();
            paymentMethord.Show();
        }

        private void AccountService_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Service service = new Service();
            this.Close();
            service.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PaymentMethord paymentMethord = new PaymentMethord();
            this.Close();
            paymentMethord.Show();
        }
    }
}
