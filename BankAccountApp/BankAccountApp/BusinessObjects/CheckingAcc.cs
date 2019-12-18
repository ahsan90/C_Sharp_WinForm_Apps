using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp.BusinessObjects
{
    class CheckingAcc : Account
    {
        public int AccNo { get; set; }
        public CheckingAcc(double balance, string accHolderName,string location, int accNo) : base(balance, accHolderName, location)
        {
            this.AccNo = accNo;
        }

        public override string ToString()
        {
            String returnString = "Checking Account details:-\n\n" + "Account No: " + this.AccNo + "\n" + base.ToString() + "\n";
            return returnString;
        }
    }
}
