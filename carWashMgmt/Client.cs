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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            retreiveData();

        }

        // set the sql Connectivity
        SqlConnection con = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=carBd;Integrated Security=True");

        private void reset()
        {

            cx_nBox.Text = "";
            cx_mBox.Text = "";
            cx_sBox.SelectedIndex = -1;
            cx_cBox.Text = "";
            cx_aBox.Text = "";
        }

        int key = 0;
        private void retreiveData()
        {

            con.Open();

            string query = "select * from client_table";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            cx_gridView.DataSource = dataset.Tables[0];

            con.Close();



        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (cx_nBox.Text == "" || cx_mBox.Text == "" || cx_sBox.SelectedIndex == -1 || cx_cBox.Text == "" ||cx_aBox.Text == "")
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("insert into client_table(c_Name,c_Mobile,c_Status,c_Car,c_Address) values (@cName,@cMob,@cStatus,@cCar,@cAddress)", con);

                    sqlCommand.Parameters.AddWithValue("@cName", cx_nBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cMob", cx_mBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cStatus", cx_sBox.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@cCar", cx_cBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cAddress", cx_aBox.Text);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfully!!");

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


        /// <summary>
        ///  Edit Information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (cx_nBox.Text == "" || cx_mBox.Text == "" || cx_sBox.SelectedIndex == -1 || cx_cBox.Text == "" || cx_aBox.Text == "")
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("update client_table set c_Name = @cName,c_Mobile = @cMob, c_Status = @cStatus,c_Car= @cCar, c_Address = @cAddress where c_Id = @cId", con);

                    sqlCommand.Parameters.AddWithValue("@cName", cx_nBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cMob", cx_mBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cStatus", cx_sBox.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@cCar", cx_cBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cAddress", cx_aBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cId", key);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Edited!!");

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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select an  item for Delete! ");

            }
            else
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("delete from client_table where c_id = @cId", con);
                cmd.Parameters.AddWithValue("@cId", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully");

                con.Close();
                retreiveData();
                reset();
            }
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            Services sr = new Services();
            sr.Show();
            this.Hide();

        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Show();
            this.Hide();
               

        }

        private void outcomBtn_Click(object sender, EventArgs e)
        {
            AboutUs ab = new AboutUs();
            ab.Show();
            this.Hide();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            
            this.Show();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            Clean cl = new Clean();
            cl.Show();
            this.Hide();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Terms tr = new Terms();
            tr.Show();
            this.Hide();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void cx_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                cx_nBox.Text = cx_gridView.CurrentRow.Cells[1].Value.ToString();
                cx_mBox.Text = cx_gridView.CurrentRow.Cells[2].Value.ToString();
                cx_sBox.SelectedItem = cx_gridView.CurrentRow.Cells[3].Value.ToString();
                cx_cBox.Text = cx_gridView.CurrentRow.Cells[4].Value.ToString();
                cx_aBox.Text = cx_gridView.CurrentRow.Cells[5].Value.ToString();



                if (cx_nBox.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(cx_gridView.CurrentRow.Cells[0].Value.ToString());
                }
            }

        }
    }
}
