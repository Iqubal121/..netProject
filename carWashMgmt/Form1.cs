using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carWashMgmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void child_panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            Services sr = new Services();
            sr.Show();
            this.Hide();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
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
            Client cl = new Client();
            cl.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Terms tr = new Terms();
            tr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clean cl = new Clean();
            cl.Show();
            this.Hide();
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginF login = new LoginF();
            login.Show();
            this.Hide();
        }

    }
}
