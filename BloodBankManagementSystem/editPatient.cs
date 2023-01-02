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
    public partial class editPatient : Form
    {
        public editPatient()
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
        // call the database function
        public SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public SqlCommand sqlCommand;
        public DataSet dataSet;
        public SqlDataAdapter adapt;
        public DataTable dt;
        /// </summary>
        private void deleteDonor_Click(object sender, EventArgs e)
        {
            



            if (searchDonor.Text == "")
            {
                MessageBox.Show("Select an item for Delete! ");

            }
            else
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("delete from Patient_Table where p_Id = @d_id", connection);
                cmd.Parameters.AddWithValue("@d_id", searchDonor.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed !");

                connection.Close();

                reset();
            }

            reset();

        }

        private void donorSubmit_Click(object sender, EventArgs e)
        {
            if (patientName.Text == "" || patientFathername.Text == "" || patientMobile.Text == "" || patientGender.SelectedIndex == -1 || patientBloodgroup.SelectedIndex == -1 || patientAddress.Text == "")
            {

                MessageBox.Show("Can't proceed with null values!!!");
            }
            else
            {
                try
                {
                    string query = "update Patient_Table set p_Name = @dName ,p_Fathername = @dfatherName, p_Mobile = @dmobile,p_Dob = @dDob,p_Gender = @dGender,p_bloodGroup = @dGroup,p_Address = @dAddress where p_Id = @d_id";


                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@dName", patientName.Text);
                    sqlCommand.Parameters.AddWithValue("@dfatherName", patientFathername.Text);
                    sqlCommand.Parameters.AddWithValue("@dmobile", patientMobile.Text);
                    sqlCommand.Parameters.AddWithValue("@dDob", patientDob.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@dGender", patientGender.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@dGroup", patientBloodgroup.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@dAddress", patientAddress.Text);
                    sqlCommand.Parameters.AddWithValue("@d_Id", searchDonor.Text);


                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Updated !");

                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }





            }
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int id = int.Parse(searchDonor.Text.ToString());
                sqlCommand = new SqlCommand("select * from Patient_Table where p_Id='" + id + "'", connection);
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                dataSet = new DataSet();
                data.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    patientName.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    patientFathername.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    patientMobile.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    patientDob.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    patientGender.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    patientBloodgroup.Text = dataSet.Tables[0].Rows[0][6].ToString();
                    patientAddress.Text = dataSet.Tables[0].Rows[0][7].ToString();

                }
                else
                {

                    MessageBox.Show("ID not found");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
