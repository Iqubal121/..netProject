using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace carWashMgmt
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();

            // Retreive data
            retreiveData();
        }

        // set the sql Connectivity
        SqlConnection con = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=carBd;Integrated Security=True");


        // connect the data

        private void reset() {

            emp_nBox.Text = "";
            emp_mBox.Text = ""; 
            emp_gBox.SelectedIndex = -1;
            emp_aBox.Text = "";
        }

        private void retreiveData() {

            con.Open();

            string query = "select * from empTabel";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            empGd.DataSource = dataset.Tables[0];

            con.Close();
                
                
                
                }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (emp_nBox.Text == "" || emp_mBox.Text == "" || emp_gBox.SelectedIndex == -1 || emp_aBox.Text == "")
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("insert into EmpTabel(e_Name,e_Mobile,e_Gender,e_Address,e_password) values (@eName,@eMob,@eGender,@eAddress,@ePassword)", con);

                    sqlCommand.Parameters.AddWithValue("@eName", emp_nBox.Text);
                    sqlCommand.Parameters.AddWithValue("@eMob", emp_mBox.Text);
                    sqlCommand.Parameters.AddWithValue("@eGender", emp_gBox.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@eAddress", emp_aBox.Text);
                    sqlCommand.Parameters.AddWithValue("@ePassword", emp_Password.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully added Employees");
                    
                    con.Close();
                    retreiveData();
                    reset();
                }
                catch (Exception t) {
                    MessageBox.Show(t.Message);
                
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (emp_nBox.Text == "" || emp_mBox.Text == "" || emp_gBox.SelectedIndex == -1 || emp_aBox.Text == "")
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("update EmpTabel set e_Name = @eName,e_Mobile = @eMob,e_Gender=@eGender,e_Address = @eAddress,e_Password = @ePassword where e_id = @emp_id ", con);

                    sqlCommand.Parameters.AddWithValue("@eName", emp_nBox.Text);
                    sqlCommand.Parameters.AddWithValue("@eMob", emp_mBox.Text);
                    sqlCommand.Parameters.AddWithValue("@eGender", emp_gBox.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@eAddress", emp_aBox.Text);
                    sqlCommand.Parameters.AddWithValue("@ePassword", emp_Password.Text);
                    sqlCommand.Parameters.AddWithValue("@emp_id", key);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated Employees");

                    con.Close();
                    retreiveData();
                    reset();
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);



                }
            }
        }

            // detele the employees record
            private void removeBtn_Click(object sender, EventArgs e)
        {
            if (key == 0) {
                MessageBox.Show("Select an  item for Delete! ");

            }
            else {

                con.Open();

                SqlCommand cmd = new SqlCommand("delete from EmpTabel where e_id = @emp_id",con);
                cmd.Parameters.AddWithValue("@emp_id", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully");

                con.Close();
                retreiveData();
                reset();
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Terms tr = new Terms();
            tr.Show();
            this.Hide();


        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            Services sr = new Services();
            sr.Show();
            this.Hide();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void outcomBtn_Click(object sender, EventArgs e)
        {
            AboutUs abs = new AboutUs();
            abs.Show();
            this.Hide();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.Show();
            this.Hide();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            Clean cl = new Clean();
            cl.Show();
            this.Hide();
        }

        /// <summary>
        ///  for editing the employees details.
        /// </summary>

        int key = 0;
        private void empGd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                emp_nBox.Text = empGd.CurrentRow.Cells[1].Value.ToString();
                emp_mBox.Text = empGd.CurrentRow.Cells[2].Value.ToString();
                emp_gBox.SelectedItem = empGd.CurrentRow.Cells[3].Value.ToString();
                emp_aBox.Text = empGd.CurrentRow.Cells[4].Value.ToString();



                if (emp_nBox.Text == "")
                {
                    key = 0; 
                }
                else
                {
                    key = Convert.ToInt32(empGd.CurrentRow.Cells[0].Value.ToString());
                }
            }


        }

        private void emp_nBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
