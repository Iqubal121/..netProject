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
    public partial class Clean : Form
    {
        public Clean()
        {
            InitializeComponent();
            getClientDetails();
            getDServiceDetails();
        }

        // set the sql Connectivity
        SqlConnection con = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=carBd;Integrated Security=True");


        private void getClientDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select c_Name from client_table",con);

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("c_Name", typeof(string));
            dataTable.Load(reader);
            cl_cxNameBox.ValueMember = "c_Name";
            cl_cxNameBox.DataSource = dataTable;


            con.Close();
        }


        private void getDServiceDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select s_Name from Service_Table", con);

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("s_Name", typeof(string));
            dataTable.Load(reader);
            cl_serviceBox.ValueMember = "s_Name";
            cl_serviceBox.DataSource = dataTable;


            con.Close();
        }

        private void getcxData() {
            try
            {
                con.Open();
                string query = "select * from client_table where c_Name='" + cl_cxNameBox.SelectedValue.ToString() + " '";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(table);

                foreach (DataRow dr in table.Rows)
                {
                    cl_mBox.Text = dr["c_Mobile"].ToString();
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

                
            con.Close();
        
        
        }


        // get service nae
        private void getserviceData()
        {
            try
            {
                con.Open();
                string query = "select * from Service_Table where s_Name='" + cl_serviceBox.SelectedValue.ToString() + " '";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(table);

                foreach (DataRow dr in table.Rows)
                {
                    cl_priceBox.Text = dr["s_Price"].ToString();
                    cl_cBox.Text = dr["s_Car"].ToString();


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


            con.Close();


        }

        private void reset()
        {

            cl_mBox.Text = "";
            cl_cBox.Text = "";
            cl_cxNameBox.SelectedIndex = -1;
            cl_priceBox.Text = "";
            cl_serviceBox.SelectedIndex = -1;

            cx_gridView.Refresh();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (cl_mBox.Text == "" || cl_cBox.Text == "" || cl_cxNameBox.SelectedIndex == -1 || cl_priceBox.Text == "" || cl_serviceBox.SelectedIndex == -1)
            {

                MessageBox.Show("Can't proceed with null value!");

            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("insert into invoice_table(c_Name,c_Mobile,e_Name,c_Address,amount,iDate) values (@iName,@iMob,@i_serviceName,@iCar,@iAmount,@iDte)", con);

                    sqlCommand.Parameters.AddWithValue("@iName", cl_cxNameBox.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@iMob", cl_mBox.Text);
                    sqlCommand.Parameters.AddWithValue("@i_serviceName", cl_serviceBox.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@iCar", cl_cBox.Text);
                    sqlCommand.Parameters.AddWithValue("@iAmount", gTotal);
                    sqlCommand.Parameters.AddWithValue("@iDte", cleanDate.Value.Date);


                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show(" Bill Saved !!!");

                    con.Close();
                    reset();  
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cl_cxNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cl_cxNameBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getcxData();
        }

        private void cl_serviceBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getserviceData();
        }


        // click on save button
        int num = 0, gTotal = 0;

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
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
            Employees rmp = new Employees();
            rmp.Show();
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

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Terms tr = new Terms();
            tr.Show();
            this.Hide();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cl_cnfrmBtn_Click(object sender, EventArgs e)
        {
            if (cl_priceBox.Text == "")
            {
                MessageBox.Show("Please select the service!!");
            }
            else {

                DataGridViewRow dataGrid = new DataGridViewRow();

                dataGrid.CreateCells(cx_gridView);

                dataGrid.Cells[0].Value = num+ 1;
                dataGrid.Cells[1].Value = cl_serviceBox.SelectedValue.ToString();

                dataGrid.Cells[2].Value = cl_priceBox.Text;
                dataGrid.Cells[3].Value = cl_cBox.Text;
                cx_gridView.Rows.Add(dataGrid);
                num++;

                gTotal = gTotal + Convert.ToInt32(cl_priceBox.Text);
                totalAmount.Text = "INR " + gTotal;

            }
        }
    }
}
