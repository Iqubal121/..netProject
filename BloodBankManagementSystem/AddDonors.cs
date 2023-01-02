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
    public partial class AddDonors : Form
    {

        // call the database function
        public SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public SqlCommand sqlCommand;
        public DataSet dataSet = new DataSet();

        public AddDonors()
        {
            InitializeComponent();
        }


        private void AddDonors_Load(object sender, EventArgs e)
        {
            
            

        }


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
            else {
                sqlCommand = new SqlCommand("select * from Donor_Table where d_mobile ='" + donorMobile.Text + "'", connection);
                SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
                data.Fill(dataSet);
                int k = dataSet.Tables[0].Rows.Count;
                // check for already user
                if (k > 0)
                {
                    MessageBox.Show("This Mobile number already used!");
                    dataSet.Clear();
                }
                else {
                    try {

                        connection.Open();
                                                
                        SqlCommand sqlCommand = new SqlCommand("insert into Donor_Table(d_Name,d_Fathername,d_Mobile,d_Dob,d_Gender,d_bloodGroup,d_Address) values (@dName,@dfatherName,@dmobile,@dDob,@dGender,@dGroup,@dAddress)", connection);

                        sqlCommand.Parameters.AddWithValue("@dName", donorName.Text);
                        sqlCommand.Parameters.AddWithValue("@dfatherName", donorFathrName.Text);
                        sqlCommand.Parameters.AddWithValue("@dmobile", donorMobile.Text);
                        sqlCommand.Parameters.AddWithValue("@dDob", donorDob.Value.Date);
                        sqlCommand.Parameters.AddWithValue("@dGender", donorGender.SelectedItem.ToString());
                        sqlCommand.Parameters.AddWithValue("@dGroup", donorBloodgroup.SelectedItem.ToString());
                        sqlCommand.Parameters.AddWithValue("@dAddress", donorAddress.Text);

                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Added! ");

                        connection.Close();
                    } catch (Exception ex) {

                        MessageBox.Show(ex.Message);
                    }
                
                
                }
            
            
            }

            reset();
        }

        private void donorClose_Click(object sender, EventArgs e)
        {
            Donor dr = new Donor();
            dr.Show();
            this.Hide();
        }
    }
}
