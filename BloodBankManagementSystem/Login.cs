using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            if (show.Text == "Show")
            {
                show.Text = "Hide";
                login_Password.PasswordChar = '\0';

            }
            else {
                show.Text = "Show";
                login_Password.PasswordChar = '*';
            }
        }

        private void acceptBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acceptBox.Checked == true)
            {
                loginBtn.Enabled = true;

            }
            else {
                loginBtn.Enabled = false;

            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login_Username.Text == "" || login_Password.Text == "")
            {
                MessageBox.Show("Can't proceed with null values!!!");
            }
            else if (login_Username.Text == "user" || login_Password.Text == "password")
            {


                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();

            }
            else {

                MessageBox.Show("Please Enter the correct Details for Login! ");
            }
        }
    }
}
