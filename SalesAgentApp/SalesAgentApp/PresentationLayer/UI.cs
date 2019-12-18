using SalesAgentApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAgentApp.PresentationLayer
{
    /*
    Class name:  UI
    Version:   1.1.1
    Author: Md Ahsanul Hoque
    #Description:  Represents Presentation class for SalesAgentApp
    Inputs:   n/a
    Outputs: none
    Dependencies:  base class Agent
    Change History:   20191120 By Md Ahsanul Hoque
    */
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Agent newJuniorAgent;
            try
            {
                //Check validation
                if (FormValidation.IsEmpty(lNameTextBox.Text) && FormValidation.IsEmpty(fNameTextBox.Text) &&
                FormValidation.IsEmpty(emailTextBox.Text) && FormValidation.IsEmpty(salesAmountTextBox.Text))
                {
                    MessageBox.Show("Validation failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //disable textBox control
                    lNameTextBox.Enabled = false;
                    fNameTextBox.Enabled = false;
                    emailTextBox.Enabled = false;
                    juniorRadioButton.Enabled = false;
                    agentRadioButton.Enabled = false;
                    seniorRadioButton.Enabled = false;
                    salesAmountTextBox.Enabled = false;

                    //prepare result for displaying
                    richTextBox1.Visible = true;
                    if (juniorRadioButton.Checked == true)
                    {
                        JuniorAgent newJuniorAgent = new JuniorAgent(lNameTextBox.Text, fNameTextBox.Text, emailTextBox.Text,
                            double.Parse(salesAmountTextBox.Text),true);
                        richTextBox1.Text = "";
                        richTextBox1.Text = "Junior Agent commission Income Details\n\nTotal commission: " + newJuniorAgent.CalculateCommission(true).ToString("C")
                                            +"\nCommission Rate: " + newJuniorAgent.GetCommissionRate()
                                            +"\nNote that Junior agent got 0.5% less commission than agent";
                    }
                    else if (agentRadioButton.Checked == true)
                    {
                        richTextBox1.Text = "";
                        Agent aAgent = new Agent(lNameTextBox.Text, fNameTextBox.Text, emailTextBox.Text,
                            double.Parse(salesAmountTextBox.Text));
                        richTextBox1.Text = "Agent commission Income Details\n\nTotal commission: " + aAgent.CalculateCommission(true).ToString("C")
                                           + "\nCommission Rate: " + aAgent.GetCommissionRate();
                    }
                    else
                    {


                        richTextBox1.Text = "";
                        SeniorAgent aSeniorAgent = new SeniorAgent(lNameTextBox.Text, fNameTextBox.Text, emailTextBox.Text,
                            double.Parse(salesAmountTextBox.Text));
                        richTextBox1.Text = "Senior Agent commission Income Details\n\nTotal commission: " + aSeniorAgent.CalculateCommission(true).ToString("C")
                                           + "\nCommission Rate: " + aSeniorAgent.GetCommissionRate();

                    }
                    this.Width = 657;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Validation failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
