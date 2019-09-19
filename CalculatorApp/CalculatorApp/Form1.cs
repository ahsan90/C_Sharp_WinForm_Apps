using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
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

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double dVal1, dVal2;
            dVal1 = GetFirstValue();
            dVal2 = GetSecondValue();

            if (dVal1 > 0 && dVal2 > 0)
            {
                lblAnswer.ForeColor = Color.Red;
                lblAnswer.Text = "Result :" + (dVal1 * dVal2).ToString();
            }
        }
        public double GetFirstValue()
        {
            double dNum1;
            while(double.TryParse(txtNumOne.Text, out dNum1) == false)
            {
                lblAnswer.ForeColor = Color.Red;
                lblAnswer.Text = "Value must be numeric and > 0";
                txtNumOne.Text = "0";
                txtNumOne.Focus();
            }
            return dNum1;
        }

        public double GetSecondValue()
        {
            double dNum2;
            while (double.TryParse(txtNumTwo.Text, out dNum2) == false)
            {
                lblAnswer.ForeColor = Color.Red;
                lblAnswer.Text = "Value must be numeric and > 0";
                txtNumTwo.Text = "0";
                txtNumTwo.Focus();
            }
            return dNum2;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            double dVal1, dVal2;
            dVal1 = GetFirstValue();
            dVal2 = GetSecondValue();

            if (dVal1 > 0 && dVal2 > 0)
            {
                lblAnswer.ForeColor = Color.Red;
                lblAnswer.Text = "Result" + (dVal1 + dVal2).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumOne.Text = "";
            txtNumTwo.Text = "";
            lblAnswer.Text = "";
            txtNumOne.Focus();
            txtNumTwo.Focus();
        }
    }
}
