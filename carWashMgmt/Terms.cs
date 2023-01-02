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
    public partial class Terms : Form
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            
            this.Show();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.Show();
            this.Hide();
        }

        private void outcomBtn_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Hide();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            Employees smp = new Employees();
            employeesBtn.Show();
            this.Hide();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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
