/*
  Progam name:  Life Insurance Application
  Version:   1.1.1
  #Description:  Life insurance policy that calculates sales's person's commissin based on each sales as well all an summary for the total system with extended functionalities
  Dependencies:  N/A
  Database file: N/A
  Change History:   Since: 30 September, 2019
 */

using LifeInsuranceApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceApp.BusinessModel
{
      /*
      Class name:  SalesPerson
      Version:   1.1.1
      #Description:  This is a model class which all the sales person properties and methods
      Dependencies:  N/A
      Database file: N/A
      Change History:   Since: 30 September, 2019
     */
    class SalesPerson
    {

        public const double RATE_1 = 0.05;
        public const double RATE_2 = 0.10;
        public const double RATE_3 = 0.20;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double InsuranceAmount { get; set; }
        public double IndividualTotalSales { get; set; }
        public double IndividualCommissionEarnedPerSales { get; set; }
        public double IndividualTotalCommissionEarned { get; set; }

        public double Rate { get; set; }


        private bool IsValidInsuranceAmount { get; set; }
        public String ErrorText { get; set; }


        public SalesPerson() { }


        /*
          Public Constructor:  Constructor for model class
          Version:   1.1.1
          #Description:  Custom constructor that passes the values from the use to properties
          Dependencies:  N/A
          Database file: N/A
          Change History:   Since: 30 September, 2019
         */
        public SalesPerson(string firstName, string lastName, string insuranceAmount)
        {
            this.ErrorText = "";

            this.FirstName = firstName;
            this.LastName = lastName;
            CheckInsuranceAmountAmount(insuranceAmount);
        }

        /*
          Method name:  CheckInsuranceAmount
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description: Check validatin for appropriate insurance amount
          Inputs:   Parameters- insuranceAmount
          Outputs: flag as boolean
          Dependencies:  N/A
          Return value: flag
          Change History:   20190930 By Md Ahsanul Hoque
        */

        public bool CheckInsuranceAmountAmount(string insuranceAmount)
        {
          
            bool flag = false;

            this.ErrorText = "";

            if (Double.TryParse(insuranceAmount, out double amount))
            {
                this.InsuranceAmount = amount;
                flag = true;
            }
            else if (SalesPersonUtility.IsEmpty(insuranceAmount))
            {
                this.ErrorText = "Amount cannot be empty";
            }
            else
            {
                this.ErrorText = ErrorMessage("Enter numeric value");
            }
            this.IsValidInsuranceAmount = flag;
            return flag;
        }

        /*
          Method name:  IsValidFirstName
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description: Check firstName validation
          Inputs:   Parameters- fName
          Outputs: flag as boolean
          Dependencies:  N/A
          Return value: flag
          Change History:   20190930 By Md Ahsanul Hoque
        */
        public bool IsValidFirstName(string fName)
        { 
            bool flag = false;
            this.ErrorText = "";
            if (!SalesPersonUtility.IsEmpty(fName))
            {
                flag = true;
            }
            else
            {
                this.ErrorText = "First name cannot be empty";
            }
            return flag;
        }

        /*
          Method name:  IsValidLastName
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description: Check lastName validation
          Inputs:   Parameters- lName
          Outputs: flag as boolean
          Dependencies:  N/A
          Return value: flag
          Change History:   20190930 By Md Ahsanul Hoque
        */
        public bool IsValidLastName(string lName)
        {
            bool flag = false;
            this.ErrorText = "";
            if (!SalesPersonUtility.IsEmpty(lName))
            {
                flag = true;
            }
            else
            {
                this.ErrorText = "Last name cannot be empty";
            }
            return flag;
        }


        /*
          Method name:  isValidationPassed
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description: Check for all the field validation is okay to be passed
          Inputs:   Parameters- FirstName, LastName IsValidInsuranceAmount
          Outputs: flag as boolean
          Dependencies:  N/A
          Return value: flag
          Change History:   20190930 By Md Ahsanul Hoque
        */
        public bool isValidationPassed()
        {
            bool flag = false;
            if((IsValidFirstName(FirstName)) && IsValidLastName(LastName) && IsValidInsuranceAmount)
            {
                flag = true;
            }
            return flag;
        }

        /*
         Method name:  GetCommissionRate
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description: Determine commission rate
         Inputs:   Parameters- rate
         Outputs: flag as boolean
         Dependencies:  N/A
         Return value: flag
         Change History:   20190930 By Md Ahsanul Hoque
       */
        public double GetCommissionRate(double rate)
        {
            return rate;
        }

        public string ErrorMessage(String errorText)
        {
            return errorText;
        }

        /*
        Method name:  Display
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description: This method return individual information
        Inputs:   Parameters- none
        Outputs: string value
        Dependencies:  N/A
        Return value: output
        Change History:   20190930 By Md Ahsanul Hoque
      */
        public string Display()
        {
            
            string output = "";
            output = "Name: " + this.FirstName + " " + this.LastName + "\n"
                                    + "Commission earned from this sale: " + this.IndividualCommissionEarnedPerSales.ToString("C");
            return output;
        }
    }
}
