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
    #Description:  Represents JuniorAgent class that is derived from Agent class
    Inputs:   n/a
    Outputs: none
    Dependencies:  base class Agent
    Change History:   20191120 By Md Ahsanul Hoque
    */
    class JuniorAgent : Agent
    {
        private bool isJunior;
        public JuniorAgent() { }

        public JuniorAgent (string lName, string fName, string email, double salesAmount, bool isJunior): 
            base(lName, fName, email, salesAmount)
        {
            this.isJunior = isJunior;
        }

        /*
        Method name:  CalculateCommission
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  This method(derived) performs calculatoin of Commission of Junior agent
        Inputs:   Parameters- inJunior
        Outputs: none
        Dependencies:  Calculate methor from base class
        Return value: double
        Change History:   20191120 By Md Ahsanul Hoque
        */
        public override double CalculateCommission(bool isJunior)
        {
            double tempCommission = 0;
            tempCommission = base.CalculateCommission(false) - base.CalculateCommission(false) * (0.5 / 100.0);
            return tempCommission;
        }
    }
}
