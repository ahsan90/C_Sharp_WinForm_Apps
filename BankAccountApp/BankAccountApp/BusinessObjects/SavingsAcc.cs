using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp.BusinessObjects
{
    public class SavingsAcc : Account
    {
        public int AccNo { get; set; }
        public SavingsAcc() { }

        public SavingsAcc(double balance, string accHolderName, string location, int accNo) : base(balance, accHolderName, location)
        {
            AccNo = accNo;
        }

        public override string ToString()
        {
            String returnString = "Savings Account details:-\n\n" + "Account No: " + this.AccNo + "\n" + base.ToString() + "\n";
            return returnString;
        }
    }
}
