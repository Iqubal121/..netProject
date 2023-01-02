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
    public partial class DashBoard : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        public DashBoard()
        {
            InitializeComponent();
            fetchData();
        }

        public void fetchData() {
            try
            {
                connection.Open();

                string query = "select SUM(Quantity) from Stock_Table";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                int totalS = Convert.ToInt32(table.Rows[0][0].ToString());
                totalStock.Text = "" + totalS;
                

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
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
            SearchDonor srd = new SearchDonor();
            srd.Show();
            this.Hide();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            st.Show();
            this.Hide();
        }

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
