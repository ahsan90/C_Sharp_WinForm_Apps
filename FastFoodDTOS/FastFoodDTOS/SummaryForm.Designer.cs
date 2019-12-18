namespace FastFoodDTOS
{
    partial class SummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outPutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // outPutRichTextBox
            // 
            this.outPutRichTextBox.Location = new System.Drawing.Point(71, 40);
            this.outPutRichTextBox.Name = "outPutRichTextBox";
            this.outPutRichTextBox.Size = new System.Drawing.Size(622, 381);
            this.outPutRichTextBox.TabIndex = 0;
            this.outPutRichTextBox.Text = "";
            this.outPutRichTextBox.TextChanged += new System.EventHandler(this.outPutRichTextBox_TextChanged);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outPutRichTextBox);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outPutRichTextBox;
    }
}