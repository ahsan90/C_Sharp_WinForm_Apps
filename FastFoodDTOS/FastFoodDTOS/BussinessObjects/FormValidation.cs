using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDTOS.BussinessObjects
{
    /*
     Class name:  FormValidation
     Version:   1.1.1
     Author: Md Ahsanul Hoque
     #Description:  This class performs form validations
     Dependencies:  N/A
     Change History:   20191028 By Md Ahsanul Hoque
    */
    class FormValidation
    {

        /*
         Method name:  IsEmpty
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  This method performs form validations if any field is empty
         Dependencies:  N/A
         Change History:   20191028 By Md Ahsanul Hoque
        */
        public static bool IsEmpty(string input)
        {
            if (input == "")
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
