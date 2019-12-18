using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAgentApp.BusinessLayer
{
    /*
    Class name:  Agent
    Version:   1.1.1
    Author: Md Ahsanul Hoque
    #Description:  Holds the properties and method of itself and other derived classes
    Inputs:   n/a
    Outputs: none
    Dependencies:  n/a
    Change History:   20191120 By Md Ahsanul Hoque
    */
    class Agent
    {
        //Declaring properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public const double RATE_1 = (2 / 100.00);

        public const double RATE_2 = 4 / 100.00;

        public const double RATE_3 = 6 / 100.00;

        public double SalesAmount { get; set; }

        //Default constructor
        public Agent() { }

        //Custom constructor
        public Agent(string lName, string fName, string email, double salesAmount)
        {
            this.LastName = lName;
            this.FirstName = fName;
            this.Email = email;
            this.SalesAmount = salesAmount;
        }


        /*
        Method name:  CalculateCommission
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  This method performs calculatoin of Commission of an agent
        Inputs:   Parameters- inAgent
        Outputs: none
        Dependencies:  N/A
        Return value: double
        Change History:   20191120 By Md Ahsanul Hoque
        */
        public virtual double CalculateCommission(bool isAgent = true)
        {
            double tempCommission = 0;
            if (this.SalesAmount<1000)
            {
                tempCommission = this.SalesAmount * RATE_1;
            }
            else if(this.SalesAmount >= 1000 && this.SalesAmount <= 5000)
            {
                tempCommission = this.SalesAmount * RATE_2;
            }
            else
            {
                tempCommission = this.SalesAmount * RATE_3;
            }
            return tempCommission;
        }


        /*
        Method name:  GetCommissionRate
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  This method(derived) performs to determine as string format
        Inputs:   none
        Outputs: none
        Dependencies:  N/A
        Return value: string
        Change History:   20191120 By Md Ahsanul Hoque
        */
        public string GetCommissionRate()
        {
            string tempComRate = "";
            if (this.SalesAmount < 1000)
            {
                tempComRate = (100 * RATE_1) + "%";
            }
            else if (this.SalesAmount >= 1000 && this.SalesAmount <= 5000)
            {
                tempComRate = (100 * RATE_2) + "%";
            }
            else
            {
                tempComRate = (100.00 * RATE_3) + "%";
            }
            return tempComRate;
        }
    }
}
