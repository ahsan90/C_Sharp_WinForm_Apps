using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_Pizza_Express.BusinessObjects
{

     /*
     Class name:  Pizza
     Version:   1.1.1
     Author: Md Ahsanul Hoque
     #Description:  This class holds the properties and other members
     Dependencies:  N/A
     Change History:   20191014 By Md Ahsanul Hoque
    */
    class Pizza
    {
        //Ingredients for toppings as readonly
        public static readonly string[] ingredients = { "Pepperoni", "Mushrooms", "Onions", "Sausage", "Bacon", "Extra cheese", "Black olives", "Green peppers" };

        //Declaring pizzaOrderList for storing pizza order
        public static List<Pizza> pizzaOrderList = new List<Pizza>();
        
        //Properties
        private int size;

        private string sauceType;

        private double cost;

        public string Toppings { get; set; }

        public int countToppings;

        /*
         Method name:  Default Constructor
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  Default constructor 
         Inputs:   Parameters- none
         Outputs: none
         Dependencies:  N/A
         Return value: none
         Change History:   20191014 By Md Ahsanul Hoque
       */
        public Pizza() { }

        /*
         Method name:  Custom Constructor
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  This constructor sets the property values when instantiates
         Inputs:   Parameters- size, sauceType, countToppings, toppings
         Outputs: none
         Dependencies:  N/A
         Return value: none
         Change History:   20191014 By Md Ahsanul Hoque
       */
        public Pizza(int size, string sauceType, int countToppings, string toppings)
        {
            this.size = size;
            this.sauceType = sauceType;
            this.countToppings = countToppings;
            Toppings = toppings;

            if (PizzaValidation.IsValidationPassed(this))
            {
                CalculateCost();
            }
        }

        public int GetSize()
        {
            return size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

        public double GetCost()
        {
            return cost;
        }

        public void SetCost(double cost)
        {
            this.cost = cost;
        }

        public int GetCountToppings()
        {
            return countToppings;
        }

        public string GetSauceType()
        {
            return sauceType;
        }

        public void SetSauceType(string sauce)
        {
            this.sauceType = sauce;
        }

        /*
         Method name:  CalculateCost
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  This method calculates the total cost of a pizza order
         Inputs:   Parameters- none
         Outputs: none
         Dependencies:  N/A
         Return value: none
         Change History:   20191014 By Md Ahsanul Hoque
       */
        private void CalculateCost()
        {
            this.cost = DetermineCostBasedOnSize(this.size) + 0.75 * countToppings;
        }

        /*
          Method name:  ToString
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description:  This method returns single pizza order
          Inputs:   Parameters- none
          Outputs: none
          Dependencies:  N/A
          Return value: none
          Change History:   20191020 By Md Ahsanul Hoque
        */
        public override string ToString()
        {
            string output = "Size: " + DetermineSizeText(this.size) + "\nSauce type: " + this.sauceType + "\nToppings($0.75 each): " + this.Toppings + "\nTotal cost: " + this.cost.ToString("C");

            return output;
        }


        /*
         Method name:  DetermineCostBasedOnSize
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  Return the value of price of the pizza according to size
         Inputs:   Parameters- size
         Outputs: returns the price of pizza
         Dependencies:  N/A
         Return value: tempCost
         Change History:   20191014 By Md Ahsanul Hoque
       */
        private double DetermineCostBasedOnSize( int size)
        {
            double tempCost;
            switch (size)
            {
                case 1 :
                    tempCost = 5;
                    break;
                case 2 :
                    tempCost = 8;
                    break;
                default:
                    tempCost = 12;
                    break;
            }
            return tempCost;
        }

        /*
          Method name:  DetermineSizeText
          Version:   1.1.1
          Author: Md Ahsanul Hoque
          #Description:  Return the value of piza size as string
          Inputs:   Parameters- none
          Outputs: returns the appropriate text
          Dependencies:  N/A
          Return value: text
          Change History:   20191014 By Md Ahsanul Hoque
        */
        private string DetermineSizeText(int size)
        {
            string text;
            switch (size)
            {
                case 1:
                    text = "Small(10\")-$5";
                    break;
                case 2:
                    text = "Small(12\")-$8";
                    break;
                default:
                    text = "Small(14\")-$12";
                    break;
            }
            return text;
        }

        /*
         Method name:  GetSummaryInfo
         Version:   1.1.1
         Author: Md Ahsanul Hoque
         #Description:  Return the order summary as a string
         Inputs:   Parameters- none
         Outputs: returns the appropriate text
         Dependencies:  N/A
         Return value: summaryt
         Change History:   20191020 By Md Ahsanul Hoque
       */

        public static string GetSummaryInfo()
        {
            string summary = "";

            //When there are orders in the listing then store them in tempOrderListin variable
            if (pizzaOrderList.Count > 0)
            {
                for (int i = 0; i <= pizzaOrderList.Count - 1; i++)
                {
                    summary += "Order No: " + (i + 1) + "\n";
                    summary += pizzaOrderList[i].ToString() + (i == (pizzaOrderList.Count - 1) ? "" : "\n") + "\n";
                }
                //Calculate and store the total cost of all order listing for outputing
                double totalOrderValue = pizzaOrderList.Select(x => x).Sum(y => y.GetCost());
                summary = "--Listing pizza order placed so far--\n\n" + summary + "\n\nTotal order value($): " + totalOrderValue.ToString("C");
            }
            else
            {
                summary = "No order placed yet...";
            }

            return summary;
        }
    }
}
