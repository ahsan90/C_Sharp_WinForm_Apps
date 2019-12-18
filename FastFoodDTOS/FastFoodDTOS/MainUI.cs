using FastFoodDTOS.BussinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDTOS
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void placeOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string mealType = "", firstName = "", lastName = "";
            int hamQty = 0, subQty = 0, fishQty = 0;



            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            try
            {
                if (hamCheckBox.Checked)
                {
                    mealType += "Hamburger";
                    hamQty = int.Parse(hamQTextBox.Text);
                }

                if (subCheckBox.Checked)
                {
                    mealType += " Sub";
                    subQty = int.Parse(subQTextBox.Text);
                }
                if (fishCheckBox.Checked)
                {
                    mealType += " Fish";
                    fishQty = int.Parse(fishQTextBox.Text);
                }
                int comboOption = mealChoiceComboBox.SelectedIndex;

                //Check validation
                if (!FormValidation.IsEmpty(firstName) && !FormValidation.IsEmpty(lastName)
                    && ((hamCheckBox.Checked && hamQty > 0) || (subCheckBox.Checked && subQty > 0) ||
                    (fishCheckBox.Checked && fishQty > 0)) && comboOption>=0)
                {
                    //If Validation is passed then place the order
                    Order aOrder = new Order(firstName, lastName, comboOption, mealType, hamQty, subQty, fishQty);
                    MessageBox.Show("Your order is placed");
                }
                else
                {
                    MessageBox.Show("Validation failed");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input");
            }
            
        }

        private void checkoutOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Checkout and show order summary in order form
            SummaryForm sForm = new SummaryForm();
            sForm.Show();
            sForm.outPutRichTextBox_TextChanged(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the program
            this.Close();
            SummaryForm sForm = new SummaryForm();
            sForm.Close();
        }
    }
}
