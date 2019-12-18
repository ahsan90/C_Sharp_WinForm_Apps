using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp.BusinessObjects
{
    public abstract class Account
    {
        public double Balance { get; set; }

        public String AccountHolderName { get; set; }
        public String Locaiton { get; set; }

        public Account() { }

        public Account(double balance, string accHolderName, string location)
        {
            this.Balance = balance;
            this.AccountHolderName = accHolderName;
            this.Locaiton = location;
        }

        public override string ToString()
        {
            string returnString = "Account holder name: " + AccountHolderName + "\n"
                                  + "Balance: " + Balance.ToString("C") + "\n" + "Acount Location: " + Locaiton + "\n";
            return returnString;
        }
    }
}
