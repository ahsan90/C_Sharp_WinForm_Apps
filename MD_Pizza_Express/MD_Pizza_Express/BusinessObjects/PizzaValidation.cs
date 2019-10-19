using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_Pizza_Express.BusinessObjects
{
    class PizzaValidation
    {

        /*
         Method name:  IsValidationPassed
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  This method performs the validation of the pizza object's value
         Inputs:   Parameters- pizza
         Outputs: none
         Dependencies:  N/A
         Return value: Boolean
         Change History:   20191014 By Md Ahsanul Hoque
       */
        public static bool IsValidationPassed(Pizza pizza)
        {
            if (IsValidPizaSize(pizza) && IsToppingsChosen(pizza))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        Method name:  IsValidationPassed
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  This method ensures user enter pizza size
        Inputs:   Parameters- pizza
        Outputs: none
        Dependencies:  N/A
        Return value: Boolean
        Change History:   20191014 By Md Ahsanul Hoque
      */
        public static bool IsValidPizaSize(Pizza pizza)
        {
            if (pizza.GetSize() > 0 && pizza.GetSize() <= 3)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        /*
        Method name:  IsValidationPassed
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  This method ensures user user chooses toppings
        Inputs:   Parameters- pizza
        Outputs: none
        Dependencies:  N/A
        Return value: Boolean
        Change History:   20191014 By Md Ahsanul Hoque
      */
        public static bool IsToppingsChosen(Pizza pizza)
        {
            if (pizza.GetCountToppings() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
