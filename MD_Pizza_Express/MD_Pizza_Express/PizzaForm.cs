using MD_Pizza_Express.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_Pizza_Express
{
    public partial class PizzaForm : Form
    {
        public PizzaForm()
        {
            InitializeComponent();

            //This method is called to populate Ingredients checkedListBox
            Load_CheckedListBox();

            //This method is called to populate pizza size combobox 
            Load_Pizza_Size();

            //This method is called to populate Sauce type combobox 
            Load_SauceType();

        }
        
        public void Load_CheckedListBox()
        {
            foreach (var item in Pizza.ingredients)
            {
                this.checkedListBoxForIngredients.Items.Add(item);
            }
        }

        public void Load_Pizza_Size()
        {
            string[] pizzaSize = { "Please select size", "Small(10\")-$5", "Medium(12\")-$8", "Large(14\")-$12" };
            foreach (var item in pizzaSize)
            {
                sizeComboBox.Items.Add(item);
            }
            sizeComboBox.SelectedIndex = 0;
        }

        public void Load_SauceType()
        {
            string[] sauceType = { "Regular", "Spicy" };

            foreach (var item in sauceType)
            {
                souceComboBox.Items.Add(item);
            }
            souceComboBox.SelectedIndex = 0;
        }
        
        
        

        private void OrderButton_Click(object sender, EventArgs e)
        {
            //Declaring local variable for storing total topping chosen by the user
            int totalTopings = checkedListBoxForIngredients.CheckedIndices.Count;

            //Add selected selected toppings in the local tempToppingList variable
            string tempToppingList = "";

            for (int i = 0; i <= checkedListBoxForIngredients.CheckedIndices.Count-1; i++)
            {
                tempToppingList += checkedListBoxForIngredients.CheckedItems[i].ToString() + (i == (checkedListBoxForIngredients.CheckedIndices.Count - 1) ? "" : ", ");
            }
    
            
            Pizza aPizza = new Pizza(sizeComboBox.SelectedIndex, souceComboBox.SelectedItem.ToString(), totalTopings, tempToppingList);


            //When validation is passed add order to pizzaOrderList static attributes of Pizza class
            if (PizzaValidation.IsValidationPassed(aPizza))
            {
                Pizza.pizzaOrderList.Add(aPizza);
                MessageBox.Show("Your order is placed..!!");
                Summary_Click(sender, e);//prepare result in summary tabPage
            }
            else
            {
                MessageBox.Show("Validation failed..!! You must build your pizza with appropriate items");
            }
        }

        private void Summary_Click(object sender, EventArgs e)
        {
            //Declare local variable to stor the all ordered listing
            string tempOrederListing = "";

            //When there are orders in the listing then store them in tempOrderListin variable
            if (Pizza.pizzaOrderList.Count > 0)
            {
                for (int i = 0; i <= Pizza.pizzaOrderList.Count - 1; i++)
                {
                    tempOrederListing += "Order No: " + (i+1)+ "\n";
                    tempOrederListing += Pizza.pizzaOrderList[i] + (i == (Pizza.pizzaOrderList.Count - 1) ? "" : "\n") + "\n";
                }
                //Calculate and store the total cost of all order listing for outputing
                double totalOrderValue = Pizza.pizzaOrderList.Select(x => x).Sum(y => y.GetCost());
                richTextBoxSummary.Text = "--Listing pizza order placed so far--\n\n" + tempOrederListing +"\n\nTotal order value($): " + totalOrderValue.ToString("C");
            }
            else
            {
                richTextBoxSummary.Text = "No order placed yet...";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Clear out the total Order placed
            Pizza.pizzaOrderList.Clear();
            richTextBoxSummary.Text = "Order listing is cleared..!!";
        }
    }
}
