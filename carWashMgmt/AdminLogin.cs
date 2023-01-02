using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carWashMgmt
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            LoginF l = new LoginF();
            l.Show();
            this.Hide();
        }

        private void adminSignin_Click(object sender, EventArgs e)
        {
            if (adminPassword.Text == "")
            {
                MessageBox.Show("Sorry!! can't proceed with null values.");

            }
            else if (adminPassword.Text == "12345")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Please enter the correct password...");
            }
        }
    }
}
