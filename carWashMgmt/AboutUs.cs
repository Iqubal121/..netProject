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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

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
            Employees rm = new Employees();
            rm.Show();
            this.Hide();

        }

        private void outcomBtn_Click(object sender, EventArgs e)
        {
            this.Show();
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
            Clean cl = new Clean();
            cl.Show();
            this.Hide();

        }
    }
}
