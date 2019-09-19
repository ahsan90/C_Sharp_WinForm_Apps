using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripMileageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dLitres;
            double dKilometers;
            

            if(double.TryParse(textBox2.Text, out dLitres) == false)
            {
                lblAnswerLevel.Text = "Must be numeric!.";
                textBox2.Text = "";
                textBox2.Focus();
            }
            if (double.TryParse(textBox3.Text, out dKilometers) == false)
            {
                //lblAnswerLevel.Text = "Kilometers Must be numeric!.";
                MessageBox.Show("Kilometers Must be numeric!.", "Date entry error", MessageBoxButtons.OK);
                textBox3.Text = "";
                textBox2.Focus();
            }
            lblAnswerLevel.Text = "Kilometer per hour: " + (dKilometers / dLitres).ToString("F1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();
            textBox3.Text = "";
            lblAnswerLevel.Text = "";
        }
    }
}
