using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDTOS.BussinessObjects
{
    /*
     Class name:  Order
     Version:   1.1.1
     Author: Md Ahsanul Hoque
     #Description:  This class holds the properties and other members
     Dependencies:  N/A
     Change History:   20191028 By Md Ahsanul Hoque
    */
    class Order
    {
        //Delcare local variables
        public static List<string> orderDescription = new List<string>();

        public const double HAM_PRICE = 5.00;
        public const double SUB_PRICE = 6.00;
        public const double FISH_PRICE = 8.00;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ComboOption { get; set; }
        public string MealType { get; set; }

        private double totalCostForHam = 0;
        private double totalCostForSub = 0;
        private double totalCostForFish = 0;

        private double comboOptionCost = 0;
        private double subtotalCost = 0;
        private double subtotal = 0;
        private double totalCost = 0;

        private int countHam = 0;
        private int countSub = 0;
        private int countFish = 0;





        /*
         Constructor type:  Default
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  N/A
         Dependencies:  N/A
         Change History:   20191028 By Md Ahsanul Hoque
        */
        public Order() { }
        /*
         Constructor type:  Custom
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  Set values of the properties from main UI
         Dependencies:  N/A
         Change History:   20191028 By Md Ahsanul Hoque
        */
        public Order(string firstName, string lastName, int comboChoice, string mealType, int hamQ, int subQ, int fishQ)
        {
            FirstName = firstName;
            LastName = lastName;
            MealType = mealType;
            ComboOption = comboChoice;
            countHam = hamQ;
            countSub = subQ;
            countFish = fishQ;

            CalculateOrder();
            
            
            

            orderDescription.Add(ToString());
        }

        /*
         Method name:  CalculateOrder
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  Calculates order based on user inputs
         Dependencies:  N/A
         Change History:   20191028 By Md Ahsanul Hoque
        */
        private void CalculateOrder()
        {

            if (this.MealType.Contains("Hamburger"))
            {
                totalCostForHam = HAM_PRICE * countHam;
            }
            if (this.MealType.Contains("Sub"))
            {
                totalCostForSub = SUB_PRICE * countSub;
            }
            if (this.MealType.Contains("Fish"))
            {
                totalCostForFish = FISH_PRICE * countFish;
            }

            subtotal = totalCostForHam + totalCostForSub + totalCostForFish;

            switch (ComboOption)
            {
                case 0:
                    comboOptionCost = subtotal;
                    break;
                case 1:
                    comboOptionCost = subtotal * 0.5;
                    break;
                case 2:
                    comboOptionCost = subtotal * 0.75;
                    break;
            }
            totalCost = subtotal + comboOptionCost;
        }

        /*
        Method name:  ToString
        Version:   1.1.1
        Author: Md Ahsanul Hoque
        #Description:  Prepare individual object of an order as a string value 
        Dependencies:  N/A
        Change History:   20191028 By Md Ahsanul Hoque
       */
        public override string ToString()
        {

            string output = "";
            output = this.FirstName + " " + this.LastName + " Food Order\n";
            output += MealType.Contains("Hamburger") ? countHam + " Hamburger- \t" + totalCostForHam.ToString("C") + "\n" : "";
            output += MealType.Contains("Sub") ? + countSub + " Sub- \t" + totalCostForSub.ToString("C") + "\n" : "";
            output += MealType.Contains("Fish") ? + countFish + " Fish- \t" + totalCostForFish.ToString("C") + "\n" : "";
            output += "--------------------------------------------------------------\n";
            output += "Subtotal:\t\t\t" + subtotal.ToString("C") + "\n";
            output += "Combo Meals Option:\t" + comboOptionCost.ToString("C") + "\n";
            output += "Meal Total Cost:\t\t" + totalCost.ToString("C") +"\n\n";
            output += "=================================================================\n";

            return output;
        }

    }
}
