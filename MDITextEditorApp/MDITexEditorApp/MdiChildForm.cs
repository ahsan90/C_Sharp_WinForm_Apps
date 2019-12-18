/* Program Name: Application based on MDI that provides functionalities for handling files
 * Author: Md Ahsanul Hoque
 * Date: November 4, 2019   
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MdiChildForm : Form
    {
        public MdiChildForm()
        {
            InitializeComponent();
        }

       

        public void ShowTextInRichTextBox(StreamReader sReader)
        {
            if (sReader != null)
            {
                richTextBox1.Text = sReader.ReadToEnd();
                //this.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("No file is chosen!");
            }
            
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Check Validation
            if (richTextBox1.Text == "") 
            {
                MessageBox.Show("File is empty");
            }
            //Save file if validation is passed
            else
            {
                saveFileDialog1.InitialDirectory = "C:";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.FileName = " ";
                saveFileDialog1.Filter = "Text Files|.txt|Word Document|.doc";

                richTextBox1.Text += "\nDate Written: " + dateTimePicker1.Value; ;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void MdiChildForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelForDate.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabelForTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelForTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Title = "Open File";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "All files|*.*|Text Files|*.txt|JPEG Images|*.jpg";

            openFileDialog1.ShowDialog();

            try
            {
                System.IO.StreamReader sReader = new System.IO.StreamReader(openFileDialog1.FileName);
                
                ShowTextInRichTextBox(sReader);

                this.Text = openFileDialog1.FileName;
            }
            catch (ArgumentException)
            {
                ShowTextInRichTextBox(null);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click_1(sender, e);
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
