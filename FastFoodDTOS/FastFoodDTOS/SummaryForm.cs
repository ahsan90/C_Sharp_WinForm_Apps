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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        public void outPutRichTextBox_TextChanged(object sender, EventArgs e)
        {
            string resutl = "";
            if (Order.orderDescription.Count>0)
            {
                foreach (var item in Order.orderDescription)
                {
                    resutl += item;
                }
            }else
            {
                resutl = "No order placed yet...";
            }
            outPutRichTextBox.Text = resutl;
        }
    }
}
