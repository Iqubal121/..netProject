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

namespace BloodBankManagementSystem
{
    public partial class addPatient : Form
    {
        public addPatient()
        {
            InitializeComponent();
        }

        private void reset()
        {
            patientName.Text = "";
            patientFathername.Text = "";
            patientMobile.Text = "";
            patientBloodgroup.SelectedIndex = -1;
            patientGender.SelectedIndex = -1;
            patientAddress.Text = "";
        }



        private void donorClose_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.Show();
            this.Hide();
        }

        /// <summary>
        //SettingsBindableAttribute database connectivity;
        public SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public SqlCommand sqlCommand;
        public DataSet dataSet = new DataSet();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void donorSubmit_Click(object sender, EventArgs e)
        {
            if (patientName.Text == "" || patientFathername.Text == "" || patientMobile.Text == "" || patientGender.SelectedIndex == -1 || patientBloodgroup.SelectedIndex == -1 || patientAddress.Text == "")
            {

                MessageBox.Show("Can't proceed with null values!!!");
            }
            else
            {
                sqlCommand = new SqlCommand("select * from Donor_Table where d_mobile ='" + patientMobile.Text + "'", connection);
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                data.Fill(dataSet);
                int k = dataSet.Tables[0].Rows.Count;
                // check for already user
                if (k > 0)
                {
                    MessageBox.Show("This Mobile number already used!");
                    dataSet.Clear();
                }
                else
                {
                    try
                    {

                        connection.Open();

                        SqlCommand sqlCommand = new SqlCommand("insert into Patient_Table(p_Name,p_Fathername,p_Mobile,p_Dob,p_Gender,p_bloodGroup,p_Address) values (@dName,@dfatherName,@dmobile,@dDob,@dGender,@dGroup,@dAddress)", connection);

                        sqlCommand.Parameters.AddWithValue("@dName", patientName.Text);
                        sqlCommand.Parameters.AddWithValue("@dfatherName", patientFathername.Text);
                        sqlCommand.Parameters.AddWithValue("@dmobile", patientMobile.Text);
                        sqlCommand.Parameters.AddWithValue("@dDob", patientDob.Value.Date);
                        sqlCommand.Parameters.AddWithValue("@dGender", patientGender.SelectedItem.ToString());
                        sqlCommand.Parameters.AddWithValue("@dGroup", patientBloodgroup.SelectedItem.ToString());
                        sqlCommand.Parameters.AddWithValue("@dAddress", patientAddress.Text);

                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Added! ");

                        connection.Close();
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
