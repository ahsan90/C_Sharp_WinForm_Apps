using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp.BusinessObjects
{

    class FormValidation
    {
        public static string ErrorText { get; set; }

        public static bool isValidationPassed = false;

        public static bool IsEmpty(String input, string errorField)
        {
            ErrorText = "";
            if (input.Length == 0 || input == "")
            {
                ErrorText = errorField + " cannot be blank";
                return true;
            }
            else
            {
                isValidationPassed = true;
                return false;
            }
        }

        public static bool IsDouble(string input)
        {
            ErrorText = "";
            //double tempBalance = Double.TryParse(input);
            if (Double.TryParse(input, out double d))
            {
                isValidationPassed = true;
                return true;
            }
            else
            {
                isValidationPassed = false;
                ErrorText = "Invalid entry";
                return false;
            }
        }

        public static bool IsPositiveValue(string input)
        {
            ErrorText = "";
            //double tempDoubleValue = Double.Parse(input);
            try
            {
                int tempIntValue = Int32.Parse(input);
                if(tempIntValue > 0)
                {
                    isValidationPassed = true;
                    return true;
                }
                else
                {
                    isValidationPassed = false;
                    ErrorText = "Please enter positive value";
                    return false;
                }

            }
            catch (FormatException)
            {
                ErrorText = "Invalid entry";
                return false;
            }
        }

    }
}
