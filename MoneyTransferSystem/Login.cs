using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTransferSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginBtn.Enabled = false;
        }

        private void reset() {
            login_Username.Text = "";
            login_Password.Text = "";
        
        }


        SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=Money_Transfer;Integrated Security=True");

        SqlCommand sqlCommand;
        SqlDataReader reader;
        DataSet dataSet = new DataSet();
        private void loginBtn_Click(object sender, EventArgs e)
        {

            connection.Open();
            string query = "select * from Register_Table where User_Name = '" + login_Username.Text.Trim() + "' and Password = '" + login_Password.Text.Trim() + "'";

            sqlCommand = new SqlCommand(query, connection);
            reader = sqlCommand.ExecuteReader();



            if (login_Username.Text.Trim() == "" || login_Password.Text.Trim() == "")
            {
                MessageBox.Show("Can't proceed with null values!!!");
            }
            else if (reader.Read())
            {


                
                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();
                reset();
                

            }
            else
            {

                MessageBox.Show("Incorrect User id Or Password! ");
            }

            connection.Close();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (Show.Text == "Show")
            {
                Show.Text = "Hide";
                login_Password.PasswordChar = '\0';

            }
            else
            {
                Show.Text = "Show";
                login_Password.PasswordChar = '*';
            }
        }

        private void acceptBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acceptBox.Checked == true)
            {
                loginBtn.Enabled = true;

            }
            else
            {
                loginBtn.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
