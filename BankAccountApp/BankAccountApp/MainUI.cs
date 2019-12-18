using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccountApp.BusinessObjects;

namespace BankAccountApp
{
    public partial class MainUI : Form
    {
        string accountSummary = "";
        public MainUI()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string errorText = "";
            bool hasFormInputError = false;

            if (FormValidation.IsEmpty(accHolderNameTxtBox.Text, "Name"))
            {
                errorText += FormValidation.ErrorText + "\n";
                hasFormInputError = true;
            }
            
            if (FormValidation.IsEmpty(locationTxtbox.Text, "Location"))
            {
                errorText += FormValidation.ErrorText + "\n";
                hasFormInputError = true;
            }
            if (FormValidation.IsEmpty(checkingAccNoTxtBox.Text, "Checkin Account No"))
            {
                errorText += FormValidation.ErrorText + "\n";
                hasFormInputError = true; 
            }
            if (!FormValidation.IsPositiveValue(checkingAccNoTxtBox.Text))
            {
                errorText += FormValidation.ErrorText + " for checking acc no!\n";
                hasFormInputError = true;
            }
            if (!FormValidation.IsDouble(checkingAccBalanceTxtBox.Text))
            {
                errorText += FormValidation.ErrorText + " for chekcing balance\n";
                hasFormInputError = true;
            }
            if (FormValidation.IsEmpty(savingsAccNoTxtBox.Text, "Savings Account No"))
            {
                errorText += FormValidation.ErrorText + "\n";
                hasFormInputError = true;
            }
            if (!FormValidation.IsPositiveValue(savingsAccNoTxtBox.Text))
            {
                errorText += FormValidation.ErrorText + " for savings acc no!\n";
                hasFormInputError = true;
            }
            if (!FormValidation.IsDouble(savingAccBalanceTxtBox.Text))
            {
                errorText += FormValidation.ErrorText + " for savings balance\n";
                hasFormInputError = true;
            }

            if (hasFormInputError)
            {
                showBtn.Visible = false;
                MessageBox.Show("Please fix the following error\n\n" + errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CheckingAcc aCheckingAcc = new CheckingAcc(Double.Parse(checkingAccBalanceTxtBox.Text), accHolderNameTxtBox.Text, locationTxtbox.Text, Int32.Parse(checkingAccNoTxtBox.Text));
                SavingsAcc aSavingsAcc = new SavingsAcc(Double.Parse(savingAccBalanceTxtBox.Text), accHolderNameTxtBox.Text, locationTxtbox.Text, Int32.Parse(savingsAccNoTxtBox.Text));
                accountSummary = aCheckingAcc.ToString() + aSavingsAcc.ToString();
                showBtn.Visible = true;
                MessageBox.Show("Information saved successfully!","", MessageBoxButtons.OK);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("========:Your Account summary:=========\n\n" + accountSummary.ToString());
        }
    }
}
