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
    public partial class Stock : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public Stock()
        {
            InitializeComponent();
            fetchData();
        }

        private void fetchData() {

            try
            {
                connection.Open();

                string query = "select * from Stock_Table";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                stockGridView.DataSource = dataset.Tables[0];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (stockBloodgroup.SelectedIndex == -1 || quantityDonate.Text == "")
            {

                MessageBox.Show("Please enter some details!");

            }
            else
            {
                try
                {

                    connection.Open();
                    string query = "update Stock_Table set Quantity = Quantity- " + quantityDonate.Text + " where Blood_Group ='" + stockBloodgroup.Text + "'";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);

                    connection.Close();

                    fetchData();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void reset() {
            stockBloodgroup.SelectedIndex = -1;
            quantityDonate.Text = "";
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stockBloodgroup.SelectedIndex == -1 || quantityDonate.Text == "") {

                MessageBox.Show("Please enter some details");

            }
            else {
                try {
                    
                    connection.Open();
                    string query = "update Stock_Table set Quantity = Quantity + " + quantityDonate.Text + " where Blood_Group ='" + stockBloodgroup.Text + "'";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);

                    connection.Close();

                    fetchData();
                    reset();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void donorBtn_Click(object sender, EventArgs e)
        {
            Donor dr = new Donor();
            dr.Show();
            this.Hide();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.Show();
            this.Hide();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDonor sr = new SearchDonor();
            sr.Show();
            this.Hide();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
