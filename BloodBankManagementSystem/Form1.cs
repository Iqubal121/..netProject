using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelProgress_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelProgress.Width += 3;

            if (panelProgress.Width >= 1286)
            {
                timer1.Stop();
                Login loginF = new Login();
                this.Hide();
                loginF.Show();
            }

        }
    }
}
