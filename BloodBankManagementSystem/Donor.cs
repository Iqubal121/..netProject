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
    public partial class Donor : Form
    {

        // set the sql Connectivity
        // call the database function
        public SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");


        public Donor()
        {
            InitializeComponent();
            fetchData();
        }

        
        private void fetchData() {

            try
            {
                connection.Open();

                string query = "select * from Donor_Table";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                donorGridView.DataSource = dataset.Tables[0];

                connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

                




        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Hide();
        }

        private void donorBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDonors ad = new AddDonors();
            ad.Show();
            this.Hide();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            EditDonor ed = new EditDonor();
            ed.Show();
            this.Hide();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            Patient pr = new Patient();
            pr.Show();
            this.Hide();
        }

        private void donorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDonor srd = new SearchDonor();
            srd.Show();
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
