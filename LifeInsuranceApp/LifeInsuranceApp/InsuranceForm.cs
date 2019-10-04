
/*
  Progam name:  Life Insurance Application
  Version:   1.1.1
  #Description:  Life insurance policy that calculates sales's person's commissin based on each sales as well all an summary for the total system with extended functionalities
  Dependencies:  N/A
  Database file: N/A
  Change History:   Since: 30 September, 2019
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
using LifeInsuranceApp.BusinessModel;
using LifeInsuranceApp.Utility;

namespace LifeInsuranceApp
{
    public partial class InsuranceForm : Form
    {
        public InsuranceForm()
        {
            InitializeComponent();
        }

        public int countTotalSales = 0;

        SalesPerson aSalesPerson;

        private int countTotalPolicies = 0;

        private List<SalesPerson> salesPersonRepo = new List<SalesPerson>(); // Holds the value of all sales person

        public bool individualSalesPersonInfoCleared = false;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            
            //pass the input values through the SalesPerson constructor
            aSalesPerson = new SalesPerson(textBoxFirstName.Text, textBoxLastName.Text, textBoxInsuranceAmount.Text);

            //Check validation
            if (!aSalesPerson.isValidationPassed())
            {

                if (!aSalesPerson.IsValidLastName(aSalesPerson.LastName))
                {
                    lNameValitionError.Text = aSalesPerson.ErrorText;
                    lNameValitionError.ForeColor = Color.Red;
                    textBoxLastName.Focus();
                }
                else
                {
                    lNameValitionError.Text = "";
                }
                if (!aSalesPerson.IsValidFirstName(aSalesPerson.FirstName))
                {
                    fNameValidationError.Text = aSalesPerson.ErrorText;
                    fNameValidationError.ForeColor = Color.Red;
                    textBoxFirstName.Focus();

                }
                else
                {
                    fNameValidationError.Text = "";
                }
                if (!aSalesPerson.CheckInsuranceAmountAmount(textBoxInsuranceAmount.Text))
                {
                    insuranceAmountValidationError.Text = aSalesPerson.ErrorText;
                    insuranceAmountValidationError.ForeColor = Color.Red;
                    textBoxInsuranceAmount.Focus();
                }
                else
                {
                    insuranceAmountValidationError.Text = "";
                }


                //Display appropriate message if validation failed
                richTextBoxForResult.Text = "Validation failed..!!!";

                MessageBox.Show("Please enter the appropriate values");

            }

            else
            {
                insuranceAmountValidationError.Text = "";
                lNameValitionError.Text = "";
                fNameValidationError.Text = "";

                //Ensure positive insurance amount
                if (aSalesPerson.InsuranceAmount < 0)
                {
                    MessageBox.Show("Insurance amount cannot be negative");
                }
                else
                {
                    //Determine and display the result for the appropriate input values from user
                    SalesPersonUtility.DetermineCommissionAndRate(aSalesPerson);


                    richTextBoxForResult.Text = "Hello " + aSalesPerson.FirstName + " " + aSalesPerson.LastName
                                                + ", You have earned the following commission at a rate of " + aSalesPerson.Rate * 100 +"%"
                                                + "\n\n"
                                                + "Commission amount: " + aSalesPerson.IndividualCommissionEarnedPerSales + "\n"
                                                + "Commission rate: " + aSalesPerson.Rate * 100 +"%";

                    //Add or update the current sales person info to the repository based on the requirements
                    SalesPersonUtility.AddOrUpdateToSalesPersonRepo(aSalesPerson, salesPersonRepo);

                    //Count policies
                    countTotalPolicies++;

                }
            }
        }

        //Clear button even hanler clears the data as specified
        private void BtnClear_Click(object sender, EventArgs e)
        {

            try
            {

                if (!SalesPersonUtility.IsEmpty(aSalesPerson.FirstName) && !SalesPersonUtility.IsEmpty(aSalesPerson.LastName)
                    && SalesPersonUtility.IsSalesPersonFound(aSalesPerson, salesPersonRepo))
                {
                    salesPersonRepo.Remove(aSalesPerson);
                    aSalesPerson.FirstName = "";
                    aSalesPerson.LastName = "";
                    countTotalPolicies--;
                    individualSalesPersonInfoCleared = true;
                }
                else
                {
                    individualSalesPersonInfoCleared = false;
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxInsuranceAmount.Text = "";
                textBoxLastName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There's nothing to clear off..");
            }
        }


        //Show the summary in the message box
        private void BtnSummary_Click(object sender, EventArgs e)
        {
            string outputString = "";

            //check data exists in the repo
            if (salesPersonRepo.Count>0)
            {
                //if individual information is not cleared the show the appropriate result to messagebox
                if (individualSalesPersonInfoCleared)
                {
                    outputString = "Current sales person's information removed or cleared";
                }
                else
                {
                    //Check current sales person exists or not
                    if (!SalesPersonUtility.IsEmpty(aSalesPerson.FirstName) && !SalesPersonUtility.IsEmpty(aSalesPerson.LastName)
                    && SalesPersonUtility.IsSalesPersonFound(aSalesPerson, salesPersonRepo))
                    {
                        outputString = "";

                        outputString = aSalesPerson.Display();

                        richTextBoxForResult.Text = outputString;
                    }
                    else
                    {
                        outputString = "Current sales person's information removed or cleared";
                    }
                }

                //grab and hold the value from displaySummary and also pass outputString extracted from above logic
                outputString = DisplaySummary(outputString);

                MessageBox.Show(outputString);

                richTextBoxForResult.Text = outputString;
            }

            //if no data found in the repo display appropriate message
            else
            {
                richTextBoxForResult.Text = "No data found to display";
                MessageBox.Show("No data found to display");
            }
            
            Clear_Error_Message();

            individualSalesPersonInfoCleared = false;
        }


        //Clear button event handler delete all information from the salePersonList repository
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult responseDialogResult;

            string outputString = "";


            if (salesPersonRepo.Count>0)
            {
                outputString = aSalesPerson.Display();
                richTextBoxForResult.Text = outputString;

                if (individualSalesPersonInfoCleared)
                {
                    outputString = "Current sales person's information removed or cleared";
                }
                else
                {
                    //Perform operation if the properties have appropriate values and exists in the repo
                    if (!SalesPersonUtility.IsEmpty(aSalesPerson.FirstName) && !SalesPersonUtility.IsEmpty(aSalesPerson.LastName)
                    && SalesPersonUtility.IsSalesPersonFound(aSalesPerson, salesPersonRepo))
                    {
                        //Grab individual info
                        outputString = aSalesPerson.Display();

                        richTextBoxForResult.Text = outputString;
                    }
                    else
                    {
                        outputString = "Current sales person's information removed or cleared";
                    }
                }

                outputString = DisplaySummary(outputString);

                responseDialogResult = MessageBox.Show(outputString, "Life Insurance Applicaiton summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (responseDialogResult == DialogResult.Yes)
                {
                    salesPersonRepo.Clear();
                    countTotalPolicies = 0;
                    richTextBoxForResult.Clear() ;
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxInsuranceAmount.Clear();
                    textBoxLastName.Focus();
                }
            }
            else
            {
                MessageBox.Show("There's nothing to clear");
            }

            Clear_Error_Message();

            individualSalesPersonInfoCleared = false;
        }


        /*
          Method name:  DisplaySummary
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description:  Return the value of the summary as string
          Inputs:   Parameters- outputString
          Outputs: returns the appropriate messages
          Dependencies:  N/A
          Return value: none
          Change History:   20190930 By Md Ahsanul Hoque
        */
        public string DisplaySummary(string outputString)
        {
            //declaring local variable
            double totalInsuranceCommissionAmountEarned = 0;
            double totalInsuranceAmountSold = 0;
            double averageCommissionEarned = 0;


            //Perform calculation if salesPersonRepo is not empty
            if (salesPersonRepo.Count>0)
            {
                totalInsuranceCommissionAmountEarned += salesPersonRepo.Select(x=> x).Sum(y=> y.IndividualTotalCommissionEarned);
                totalInsuranceAmountSold += salesPersonRepo.Select(x => x).Sum(y => y.IndividualTotalSales);
                averageCommissionEarned = totalInsuranceCommissionAmountEarned / (salesPersonRepo.Count);
            }
            else
            {
                totalInsuranceCommissionAmountEarned = 0;
                totalInsuranceAmountSold = 0;
            }

            //Prepare summary and return it
            return "Total number of policies counted: " + countTotalPolicies + "\n"
                    + "Total insurance amount sold: " + totalInsuranceAmountSold.ToString("C") + "\n\n"
                    + "---------------------------------------------\n"
                    + "Current Seles Person summary:-\n\n"
                    + outputString
                    + "\n"
                    + "----------------------------------------------\n"
                    + "Total insurance amount earned by all sales person processed so far: " + totalInsuranceCommissionAmountEarned.ToString("C")+"\n"
                    + "Average Commission earning "+ averageCommissionEarned.ToString("C")+ "\n"
                    + "Total sales person processed: " + salesPersonRepo.Count;
        }


        /*
          Method name:  Clear_Error_Message
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description:  Clear existing error message from the UI
          Outputs: N/A
          Dependencies:  N/A
          Return value: none
          Change History:   20190930 By Md Ahsanul Hoque
        */
        private void Clear_Error_Message()
        {
            lNameValitionError.Text = "";
            fNameValidationError.Text = "";
            insuranceAmountValidationError.Text = "";
        }
    }
}
