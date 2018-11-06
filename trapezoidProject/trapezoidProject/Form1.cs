using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trapezoidProject
{
    public partial class Form1 : Form
    {
        private decimal areaOfTrapezoid;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate the area of a trapezoid
            //create variables and get info from text boxes
            
            decimal base1 = decimal.Parse(txtBase1.Text);
            decimal base2 = decimal.Parse(txtBase2.Text);
            decimal height = decimal.Parse(txtHeight.Text);
            areaOfTrapezoid = TrapezoidArea(base1, base2, height);

            lblArea.Text = areaOfTrapezoid.ToString("N2");
        }
        public decimal TrapezoidArea(decimal b1, decimal b2, decimal theHeight)
        {

            decimal theArea = 0;
            theArea = .5m * theHeight * (b1 + b2);

            return theArea;

        }
    }
}
