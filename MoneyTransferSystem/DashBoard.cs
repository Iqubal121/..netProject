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
    public partial class DashBoard : Form
    {
        public DashBoard()
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
                selectAccount.ValueMember = "Accout_Number";
                selectAccount.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public void fetchData()
        {
            try
            {
                connection.Open();

                string query = "select SUM(Amount) from Transfer_Table where Receiver_Account='" + selectAccount.SelectedValue.ToString() + "'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                int totalS = Convert.ToInt32(table.Rows[0][0].ToString());
                debitBalance.Text = "" + totalS;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void getInformation()
        {
            try
            {
                connection.Open();
                string query = "select * from Register_Table where Accout_Number='" + selectAccount.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(table);

                foreach (DataRow dr in table.Rows)
                {
                    existBalance.Text = dr["Amount"].ToString().Trim();

                }
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            connection.Close();
        }

        
        private void dashBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
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
            Debit db = new Debit();
            db.Show();
            this.Hide();
        }

        private void ceditBtn_Click(object sender, EventArgs e)
        {
            Credit cr = new Credit();
            cr.Show();
            this.Hide();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Hide();
        }

        private void selectAccount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getInformation();
            //fetchData();


        }
    }
}
