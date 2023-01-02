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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            retreiveData();
        }

        // set the sql Connectivity
        SqlConnection con = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=carBd;Integrated Security=True");

        private void reset()
        {

            ser_nBox.Text = "";
            ser_pBox.Text = "";
            ser_cBox.Text = "";
        }
        private void retreiveData()
        {

            con.Open();

            string query = "select * from Service_Table";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            serGridview.DataSource = dataset.Tables[0];

            con.Close();
        }

            private void Services_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ser_nBox.Text == "" || ser_pBox.Text == "" ||  ser_cBox.Text == "")
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("insert into Service_Table(s_Name,s_Price,s_Car) values (@sName,@sPrice,@sCar)", con);

                    sqlCommand.Parameters.AddWithValue("@sName", ser_nBox.Text);
                    sqlCommand.Parameters.AddWithValue("@sPrice", ser_pBox.Text);
                    sqlCommand.Parameters.AddWithValue("@sCar", ser_cBox.Text);
               
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
        int key = 0;
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (ser_nBox.Text == "" || ser_pBox.Text == "" || ser_cBox.Text == "")
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("update Service_Table set s_Name = @sName,s_Price = @sPrice,s_Car= @sCar where s_Id =@sId", con);

                    sqlCommand.Parameters.AddWithValue("@sName", ser_nBox.Text);
                    sqlCommand.Parameters.AddWithValue("@sPrice", ser_pBox.Text);
                    sqlCommand.Parameters.AddWithValue("@sCar", ser_cBox.Text);
                    sqlCommand.Parameters.AddWithValue("@sId", key);

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

        private void removeBtn_Click(object sender, EventArgs e)
        {


            if (key == 0)
            {
                MessageBox.Show("Select an  item for Delete! ");

            }
            else
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("delete from Service_Table where s_id = @sId", con);
                cmd.Parameters.AddWithValue("@sId", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully");

                con.Close();
                retreiveData();
                reset();

            }
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
            this.Hide();
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

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            Clean cr = new Clean();
            cr.Show();
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

        private void employeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {

                ser_nBox.Text = serGridview.CurrentRow.Cells[1].Value.ToString();
                ser_cBox.Text = serGridview.CurrentRow.Cells[2].Value.ToString();
              
                ser_pBox.Text = serGridview.CurrentRow.Cells[3].Value.ToString();
              



                if (ser_nBox.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(serGridview.CurrentRow.Cells[0].Value.ToString());
                }
            }


        }
    }
}
