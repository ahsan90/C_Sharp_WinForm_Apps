namespace AcidRain
{
    partial class AcidRainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcidRainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pHInputTextBox = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(119, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter pH level";
            // 
            // pHInputTextBox
            // 
            this.pHInputTextBox.Location = new System.Drawing.Point(268, 59);
            this.pHInputTextBox.Name = "pHInputTextBox";
            this.pHInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.pHInputTextBox.TabIndex = 7;
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(409, 56);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(90, 25);
            this.Process.TabIndex = 2;
            this.Process.Text = "Execute";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Image = ((System.Drawing.Image)(resources.GetObject("result.Image")));
            this.result.Location = new System.Drawing.Point(0, 101);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(692, 294);
            this.result.TabIndex = 4;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultRichTextBox.Location = new System.Drawing.Point(188, 434);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(294, 115);
            this.resultRichTextBox.TabIndex = 5;
            this.resultRichTextBox.Text = "Result will be displayed here..";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(520, 56);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // AcidRainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 590);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.pHInputTextBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AcidRainForm";
            this.Text = "AcidRainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pHInputTextBox;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button btnReset;
    }
}

