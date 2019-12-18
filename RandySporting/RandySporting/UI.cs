/*
 Project: Calcuate the service costs for a customer for the service he/she choose
 Author: Md Ahsanul Hoque
 Since: 20190925
 
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandySporting
{
    public partial class UI : Form
    {

        //Declare the initial variables
        private const decimal TEAM_BUILDING = 125.00m;
        private const decimal NUITRTION = 60.00m;
        private const decimal EXERCISE = 35.00m;
        private const decimal FULL_PACKAGE = 200.00m;

        private const decimal DISCOUNT_TEN = .10m;
        private const decimal DISCOUNT_TWENTY = .20m;

        decimal totalDue = 0m;


        public UI()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //variable that holds the amount calculated 
            decimal tempAmount = 0;
            if (noSelectCheckBox.Checked == false)
            {
                if (fullPackCheckBox.Checked)
                {
                    tempAmount += FULL_PACKAGE;
                }
                else
                {
                    if (teamChckBox.Checked)
                    {
                        tempAmount += TEAM_BUILDING;
                    }
                    if (nuitritionCheckBox.Checked)
                    {
                        tempAmount += NUITRTION;
                    }
                    if (ExerciseCheckBox.Checked)
                    {
                        tempAmount += EXERCISE;
                    }

                }
                MessageBox.Show("Calculated...!");
            }
            else
            {
                MessageBox.Show("You must uncheck No Selection option and select the services you want");
            }


            //Calculate the amount based on discount provided

            if (tenPercentRadioButton.Checked)
            {
                tempAmount = tempAmount - tempAmount * DISCOUNT_TEN;
                totalDue = tempAmount;
            }
            else if (twentyPercentRadioButton.Checked)
            {
                tempAmount = tempAmount - tempAmount * DISCOUNT_TWENTY;
                totalDue = tempAmount;
            }
            else
            {
                totalDue = tempAmount;
            }

           

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            totalDue = 0m;
            teamChckBox.Checked = false;
            nuitritionCheckBox.Checked = false;
            ExerciseCheckBox.Checked = false;
            fullPackCheckBox.Checked = false;
            noSelectCheckBox.Checked = true;
            noneRadioButton.Checked = true;
            tenPercentRadioButton.Checked = false;
            twentyPercentRadioButton.Checked = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total cost for the client : " + totalDue.ToString("C"));
        }
    }
}
