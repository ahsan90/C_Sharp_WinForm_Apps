/* Program Name: Application based on MDI that provides functionalities for handling files
 * Author: Md Ahsanul Hoque
 * Date: November 4, 2019   
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
        }

        int documentCounter = 0;
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentCounter++;
            MdiChildForm child = new MdiChildForm();
            child.MdiParent = this;
            child.Show();
            child.Text = "Document " + documentCounter;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChildForm child = new MdiChildForm();
            child.MdiParent = this;

            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Title = "Open File";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "All files|*.*|Text Files|*.txt|JPEG Images|*.jpg";

            openFileDialog1.ShowDialog();

            try
            {
                System.IO.StreamReader sReader = new System.IO.StreamReader(openFileDialog1.FileName);
                child.Show();
                child.ShowTextInRichTextBox(sReader);
                child.Text = openFileDialog1.FileName;
            }
            catch (ArgumentException)
            {
                child.Show();
                child.ShowTextInRichTextBox(null);
            }
        }

    }
}
