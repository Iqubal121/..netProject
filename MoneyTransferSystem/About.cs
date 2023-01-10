using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTransferSystem
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            
            this.Refresh();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendMoney send = new SendMoney();
            send.Show();
            this.Hide();
        }

        private void debitDtails_Click(object sender, EventArgs e)
        {
            Debit db = new Debit();
            db.Show();
            this.Hide();
        }

        private void ceditBtn_Click(object sender, EventArgs e)
        {
            Credit cr = new Credit();
            cr.Show();
            this.Hide();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
