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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressPanel.Width += 3;

            if (progressPanel.Width >= 1355) {
                timer1.Stop();
                LoginF loginF = new LoginF();
                this.Hide();
                loginF.Show();
            }

        }

        private void progressPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
