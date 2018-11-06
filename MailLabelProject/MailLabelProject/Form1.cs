using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Joshua Williams
//Period: 0
//Date: 9/25/14
/*Project Description: This project uses concatenation to make
 * a mailing label. Text is inputted and formatted into a mailing
 * label. There is also a clear button to reset the label. */

namespace MailLabelProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblLabel.Text = txtFN.Text + " " + txtLN.Text +
                "\n" + txtStreet.Text + "\n" + txtCity.Text +
                ", " + txtState.Text + " " + txtZip.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblLabel.Text = "";
            txtFN.Text = "";
            txtLN.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
        }
    }
}
