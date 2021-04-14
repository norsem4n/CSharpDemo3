using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram3
{
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the form

            this.Close();
        }

        private void rBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            // Changes tagline color to blue

            lblTagline.ForeColor = Color.Blue;
        }

        private void rBtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            // Changes tagline color to green

            lblTagline.ForeColor = Color.Green;
        }

        private void rBtnYellow_CheckedChanged(object sender, EventArgs e)
        {
            // changes tagline color to yellow

            lblTagline.ForeColor = Color.Yellow;
        }

        private void rBtnPurple_CheckedChanged(object sender, EventArgs e)
        {
            // changes tagline color to purple

            lblTagline.ForeColor = Color.Purple;
        }

        private void ckBoxName_CheckedChanged(object sender, EventArgs e)
        {
            // displays the name of the business when checked

            lblBusinessName.Visible = ckBoxName.Checked;
        }

        private void ckBoxTagline_CheckedChanged(object sender, EventArgs e)
        {
            // displays the name of the business tagline when checked

            lblTagline.Visible = ckBoxTagline.Checked;
        }

        private void ckBoxLogo_CheckedChanged(object sender, EventArgs e)
        {
            // displays the logo when checked

            pictureBox1.Visible = ckBoxLogo.Checked;
        }

        private void ckBoxDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            // displays developer when checked 

            lblDeveloper.Visible = ckBoxDeveloper.Checked;
        }
    }
}
