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

namespace carWashMgmt
{
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cl_cBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cl_mBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginF_Load(object sender, EventArgs e)
        {

        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.Show();
            this.Hide();
        }

        // set the path for database connectivity.
        SqlConnection con = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=carBd;Integrated Security=True");
        private void SignIn_Click(object sender, EventArgs e)
        {
            if (loginUserName.Text == "" || loginPassword.Text == "")
            {
                MessageBox.Show(" Sorry can't proceeed with null values.!!!!!");
            }
            else
            {
                try
                {
                    con.Open();


                    string query = "select count(*) from EmpTabel where e_Name = '" + loginUserName.Text + "'and e_password='" + loginPassword + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);


                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    con.Close();
                    /*
                    if (dataTable.Rows[0][0].ToString() == "1")
                    {

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                        con.Close();
                    }
                    else {
                        MessageBox.Show("Please enter the correct information for login !!");

                    }
                    */


                    //con.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    } 
}
