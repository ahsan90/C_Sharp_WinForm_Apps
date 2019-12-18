


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAgentApp.BusinessLayer
{
    /*
    Class name:  SeniorAgent
    Version:   1.1.1
    Author: Md Ahsanul Hoque
    #Description:  Represents SeniorAgent class that is derived from Agent class
    Inputs:   n/a
    Outputs: none
    Dependencies:  base class Agent
    Change History:   20191120 By Md Ahsanul Hoque
    */
    class SeniorAgent : Agent
    {
        //Default constructor
        public SeniorAgent() { }

        //Custom constructor that accept parameters from form class
        public SeniorAgent (string lName, string fName, string email, double salesAmount) : base(lName,
            fName, email, salesAmount)
        {

        }

        /*
        Method name:  CalculateCommission
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  This method(derived) performs calculatoin of Commission of Senior agent
        Inputs:   Parameters- inJunior
        Outputs: none
        Dependencies:  Calculate method from base class
        Return value: double
        Change History:   20191120 By Md Ahsanul Hoque
        */
        public override double CalculateCommission(bool isJunior)
        {
            double tempCommission = 0;
            tempCommission = base.CalculateCommission() + base.CalculateCommission(false) * (1.5 / 100.0);
            return tempCommission;
        }
    }
}
