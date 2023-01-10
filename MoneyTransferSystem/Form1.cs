using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTransferSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressPanel.Width += 3;

            if (progressPanel.Width >= 1283) {

                timer1.Stop();

                Login lg = new Login();
                lg.Show();
                this.Hide();


            }
        }
    }
}
