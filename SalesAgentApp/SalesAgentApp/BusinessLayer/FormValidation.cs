using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAgentApp.BusinessLayer
{
    class FormValidation
    {
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
