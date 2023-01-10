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
    public partial class SendMoney : Form
    {
        public SendMoney()
        {
            InitializeComponent();
            signupBtn.Enabled = false;
            getSenderAccount();

            getAccountNumber();
            
        }

        SqlConnection connection = new SqlConnection(@"Data Source=IQBALS\SQLEXPRESS01;Initial Catalog=Money_Transfer;Integrated Security=True");

        SqlCommand sqlCommand;
        SqlDataReader reader;
        DataSet dataSet = new DataSet();

        private void reset()
        {
            recAccount.Text = "";
            sendName.Text = "";
            sendMobile.Text = "";
            sendAmount.Text = "";
            sendMessage.Text = "";

        }

        // get sender Account;
        public void getSenderAccount()
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
                sendAccout.ValueMember = "Accout_Number";
                sendAccout.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }


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
                recAccount.ValueMember = "Accout_Number";
                recAccount.DataSource = dataTable;
                



                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }


        int totalAmount;

        private void getsendInformation()
        {
            try
            {
                connection.Open();

                string query = "select * from Register_Table where Accout_Number='" + recAccount.SelectedValue.ToString() + " '";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(table);


                foreach (DataRow dr in table.Rows)
                {
                    totalAmount = Convert.ToInt32(dr["Amount"].ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            connection.Close();
        }
        private void getInformation()
        {
            try
            {
                connection.Open();

                string query = "select * from Register_Table where Accout_Number='" + recAccount.SelectedValue.ToString() + " '";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(table);
                

                foreach (DataRow dr in table.Rows)
                {                    
                    sendName.Text = dr["Full_Name"].ToString().Trim();
                    sendMobile.Text = dr["Mobile_Number"].ToString().Trim();
                    
                }     
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            connection.Close();
        }


        // Update the Sender Account Balance
        private void updateSenderAccount() {

            int b1 = totalAmount - Convert.ToInt32(sendAmount.Text);

            try {
                connection.Open();
                string query = "update Register_Table set Amount = Amount - " + sendAmount.Text + " where Accout_Number ='" + sendAccout.Text + "'";
                sqlCommand = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                connection.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        
        
        
        }


        private void updateReceiverAccount()
        {
            int b1 = totalAmount + Convert.ToInt32(sendAmount.Text);

            try
            {
                connection.Open();
                string query = "update Register_Table set Amount = Amount + " + sendAmount.Text + " where Accout_Number ='" + recAccount.Text + "'";
               
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            if (recAccount.Text.Trim() == "" || sendName.Text.Trim() == "" || sendName.Text.Trim() == "" || sendAmount.Text.Trim() == "" || sendMessage.Text.Trim() == "")
            {

                MessageBox.Show("Can't proceed with null values!!!");
            }
            else if (sendAccout.Text.Trim() == recAccount.Text.Trim())
            {

                MessageBox.Show("Sender == Receiver Account !!!");

            }
            else if (Convert.ToInt32(sendAmount.Text) > totalAmount) {

                MessageBox.Show("Insufficient Balance !!!");
            }
            else
            {

                try
                {

                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("insert into Transfer_Table(Sender_Account,Receiver_Account,Name,Mobile,Date,Amount,Message) values (@sAcc,@rAcc,@nam,@mob,@dat,@amt,@msg)", connection);

                    sqlCommand.Parameters.AddWithValue("@sAcc", sendAccout.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@rAcc", recAccount.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@nam", sendName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@mob", sendMobile.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@dat", sendDate.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@amt", sendAmount.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@msg", sendMessage.Text.Trim());

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show(" Money has been transfered");
                    connection.Close();

                    updateSenderAccount();
                    updateReceiverAccount();
                    reset();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }






            }

            

        }

        private void acceptBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acceptBox.Checked == true)
            {
                signupBtn.Enabled = true;

            }
            else
            {
                signupBtn.Enabled = false;

            }

        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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
        }

        private void sendAccout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendAccout_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getsendInformation();

        }
    }
}
