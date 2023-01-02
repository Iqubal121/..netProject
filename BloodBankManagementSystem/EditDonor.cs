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
    public partial class EditDonor : Form
    {
        public EditDonor()
        {
            InitializeComponent();
        }

        /// <summary>
        // call the database function
        public SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public SqlCommand sqlCommand;
        public DataSet dataSet;
        public SqlDataAdapter adapt;
        public DataTable dt;
        /// </summary>
        //// reset
        private void reset()
        {
            donorName.Text = "";
            donorFathrName.Text = "";
            donorMobile.Text = "";
            donorBloodgroup.SelectedIndex = -1;
            donorGender.SelectedIndex = -1;
            donorAddress.Text = "";
        }
        private void donorSubmit_Click(object sender, EventArgs e)
        {
            if (donorName.Text == "" || donorFathrName.Text == "" || donorMobile.Text == "" || donorGender.SelectedIndex == -1 || donorBloodgroup.SelectedIndex == -1 || donorAddress.Text == "")
            {

                MessageBox.Show("Can't proceed with null values!!!");
            }

            else
            {
                    try
                    {
                    string query = "update Donor_Table set d_Name = @dName ,d_Fathername = @dfatherName, d_Mobile = @dmobile,d_Dob = @dDob,d_Gender = @dGender,d_bloodGroup = @dGroup,d_Address = @dAddress where d_Id = @d_id";


                    connection.Open();
                   
                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    sqlCommand.Parameters.AddWithValue("@dName", donorName.Text);
                    sqlCommand.Parameters.AddWithValue("@dfatherName", donorFathrName.Text);
                    sqlCommand.Parameters.AddWithValue("@dmobile", donorMobile.Text);
                    sqlCommand.Parameters.AddWithValue("@dDob", donorDob.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@dGender", donorGender.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@dGroup", donorBloodgroup.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@dAddress", donorAddress.Text);
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

        private void deleteDonor_Click(object sender, EventArgs e)
        {


            if (searchDonor.Text == "")
            {
                MessageBox.Show("Select an  item for Delete! ");

            }
            else
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("delete from Donor_Table where d_Id = @d_id", connection);
                cmd.Parameters.AddWithValue("@d_id", searchDonor.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed !");

                connection.Close();
                
                reset();
            }
            reset();
        }

        private void donorClose_Click(object sender, EventArgs e)
        {
            Donor dr = new Donor();
            dr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int id = int.Parse(searchDonor.Text.ToString());
                sqlCommand = new SqlCommand("select * from Donor_Table where d_Id='" + id + "'", connection);
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                dataSet = new DataSet();
                data.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    donorName.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    donorFathrName.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    donorMobile.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    donorDob.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    donorGender.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    donorBloodgroup.Text = dataSet.Tables[0].Rows[0][6].ToString();
                    donorAddress.Text = dataSet.Tables[0].Rows[0][7].ToString();

                }
                else {

                    MessageBox.Show("ID not found");
                }

                connection.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }



        }

        private void searchDonor_TextChanged(object sender, EventArgs e)
        {
            if (searchDonor.Text == "") {
                reset();
            }
        }
    }
}
