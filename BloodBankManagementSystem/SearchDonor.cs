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
    public partial class SearchDonor : Form
    {

        // set the sql Connectivity
        // call the database function
        public SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public SearchDonor()
        {
            InitializeComponent();
            fetchData();
        }

        private void fetchData()
        {

            try
            {
                connection.Open();

                string query = "select * from Donor_Table";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                patientGridview.DataSource = dataset.Tables[0];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "") {
                string query = "select * from Donor_Table where d_bloodGroup like '" + textBox1.Text + "%'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                patientGridview.DataSource = dataset.Tables[0];
            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            DashBoard dr = new DashBoard();
            dr.Show();
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
            Patient pr = new Patient();
            pr.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            st.Show();
            this.Hide();
        }
    }
}
