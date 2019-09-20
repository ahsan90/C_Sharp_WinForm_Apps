
/*
  Progam name:  Acid Rain Application
  Version:   1.1.1
  #Description:  Displaing pH level and appropriate message based on user input 
  Dependencies:  N/A
  Database file: N/A
  Change History:   N/A
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

namespace AcidRain
{
    public partial class AcidRainForm : Form
    {
        public AcidRainForm()
        {
            InitializeComponent();
        }

        //Process the data based on user input
        private void Process_Click(object sender, EventArgs e)
        {
            String input = pHInputTextBox.Text;

            double pHLevel;

            if(double.TryParse(input, out pHLevel))
            {
                ShowResult(pHLevel);
            }
            else
            {
                MessageBox.Show("Invalid user input");
            }
            
        }

       
        /*
          Progam name:  ShowResult
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description:  Perform logical Calculation based on the level of pH
          Inputs:   Parameters- pHLevel
          Outputs: Creates the appropriate messages
          Dependencies:  N/A
          Return value: none
          Change History:   20190917 By Md Ahsanul Hoque
        */

        private void ShowResult(double pHLevl)
        {
            int[] rgb = new int[3];
            String outputText = "";
           
            //Process pH level when less than 7.2 and greater than 0
            if(pHLevl>=0 && pHLevl < 7.2)
            {
                if(pHLevl == 7)
                {
                    rgb[0] = 142;
                    rgb[1] = 207;
                    rgb[2] = 1;
                    outputText = "Nutral, entered value is " + pHLevl;
                    ShowMessage(outputText, rgb);
                    outputText = "";
                } else
                {
                    rgb[0] = 238;
                    rgb[1] = 1;
                    rgb[2] = 0;
                    outputText = "Acidic and need to adjust pH increasers(bases) to balance pH Level, entered value is " + pHLevl;
                    ShowMessage(outputText, rgb);
                    outputText = "";
                }
            }

            //process pH level when it is greater than 7.8 and less than 14
            else if (pHLevl > 7.8 && pHLevl <= 14)
            {
                rgb[0] = 71;
                rgb[1] = 87;
                rgb[2] = 183;
                outputText = "Basic or Alkaline and need to adjust pH decreasers(acid) to balance pH Level, entered value is " + pHLevl;
                ShowMessage(outputText, rgb);
                outputText = "";
            }
            //Inform if pH level is balanced
            else if(pHLevl>=7.2 && pHLevl <= 7.8)
            {
                MessageBox.Show("Balanced");
            }
            else
            {
                resultRichTextBox.Text = "pH input level scale must be between 0 - 14";
                resultRichTextBox.ForeColor = Color.Black;
                resultRichTextBox.Focus();
                MessageBox.Show("pH input level scale must be between 0 - 14");
            }
            
        }


        /*
          Progam name:  ShowResult
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description:  Show Appropriate messages
          Inputs:   Parameters- message, rgb
          Outputs: display the appropriate messages
          Dependencies:  N/A
          Return value: none
          Change History:   20190917 By Md Ahsanul Hoque
        */
        private void ShowMessage(String message, int[] rgb)
        {
            resultRichTextBox.Text = message;
            resultRichTextBox.ForeColor = Color.FromArgb(rgb[0],rgb[1],rgb[2]);
            pHInputTextBox.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            pHInputTextBox.Text = "";
            resultRichTextBox.Text = "Result will be displayed here..";
            resultRichTextBox.ForeColor = Color.Black;
            pHInputTextBox.Focus();
        }

    }
}
