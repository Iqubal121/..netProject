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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            signupBtn.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void acceptBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acceptBox.Checked == true)
            {
                signupBtn.Enabled = true;

            }
            else
            {
                signupBtn.Enabled = false;

            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (Show.Text == "Show")
            {
                Show.Text = "Hide";
                regPassword.PasswordChar = '\0';

            }
            else
            {
                Show.Text = "Show";
                regPassword.PasswordChar = '*';
            }
        }

        ///reset method();
        private void reset()
        {
            regAccountnumber.Text = "";
            regName.Text = "";
            regMobile.Text = "";
            regUsername.Text = "";
            regGender.SelectedIndex = -1;
            regAmount.Text = "";
            regUsername.Text = "";
            regPassword.Text = "";
            
        }


       SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=Money_Transfer;Integrated Security=True");

         SqlCommand sqlCommand;
         DataSet dataSet = new DataSet();
        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (regAccountnumber.Text == "" || regName.Text == "" || regMobile.Text == "" || regGender.SelectedIndex == -1 || regAmount.Text == ""|| regUsername.Text == "" || regPassword.Text == "")
            {

                MessageBox.Show("Can't proceed with null values!!!");
            }
            else
            {
                

                sqlCommand = new SqlCommand("select * from Register_Table where Accout_Number ='" + regAccountnumber.Text.Trim() + "'", connection);
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                data.Fill(dataSet);
                int k = dataSet.Tables[0].Rows.Count;
                // check for already user
                if (k > 0)
                {
                    MessageBox.Show("Account Number is Already Exist!!");
                    dataSet.Clear();

                 }
                else
                {



                    try
                    {
                        
                        connection.Open();

                        SqlCommand sqlCommand = new SqlCommand("insert into Register_Table(Accout_Number,Full_Name,Mobile_Number,DOB,Gender,Amount,User_Name,Password) values (@Account,@name,@mobile,@userDob,@Gen,@amt,@userid,@userpassword)", connection);

                        sqlCommand.Parameters.AddWithValue("@Account", regAccountnumber.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@name", regName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@mobile", regMobile.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@userDob", regDob.Value.Date);
                        sqlCommand.Parameters.AddWithValue("@Gen", regGender.SelectedItem.ToString());
                        sqlCommand.Parameters.AddWithValue("@amt", regAmount.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@userid", regUsername.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@userpassword", regPassword.Text.Trim());

                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Registered Successfully! ");
                        connection.Close();

                        Login lg = new Login();
                        lg.Show();
                        this.Hide();


                        
                         

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }



                }


            }

            reset();
        }
    }
}
