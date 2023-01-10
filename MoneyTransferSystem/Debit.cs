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

namespace MoneyTransferSystem
{
    public partial class Debit : Form
    {
        public Debit()
        {
            InitializeComponent();
            getAccountNumber();

        }

        SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=Money_Transfer;Integrated Security=True");

        SqlCommand sqlCommand;
        SqlDataReader reader;
        DataSet dataSet = new DataSet();

        public void getAccountNumber()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select Accout_Number from Register_Table", connection);

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Accout_Number", typeof(string));
                dataTable.Load(reader);
                deditSearch.ValueMember = "Accout_Number";
                deditSearch.DataSource = dataTable;




                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }


        private void fetchData()
        {

            try
            {
                connection.Open();

                string query = "select Sender_Account, Mobile, Date, Amount, Message from Transfer_Table where Receiver_Account = '"+ deditSearch.SelectedValue.ToString() + "'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                debitgridView.DataSource = dataset.Tables[0];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Hide();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendMoney send = new SendMoney();
            send.Show();
            this.Hide();
        }

        private void debitDtails_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void ceditBtn_Click(object sender, EventArgs e)
        {
            Credit cr = new Credit();
            cr.Show();
            this.Hide();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void deditSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchData();
        }

        private void deditSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
