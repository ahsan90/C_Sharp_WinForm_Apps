namespace BankAccountApp
{
    partial class MainUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.accHolderNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkingAccBalanceTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkingAccNoTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savingAccBalanceTxtBox = new System.Windows.Forms.TextBox();
            this.savingsAccNoTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.locationTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder Name:";
            // 
            // accHolderNameTxtBox
            // 
            this.accHolderNameTxtBox.Location = new System.Drawing.Point(277, 78);
            this.accHolderNameTxtBox.Name = "accHolderNameTxtBox";
            this.accHolderNameTxtBox.Size = new System.Drawing.Size(144, 20);
            this.accHolderNameTxtBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkingAccBalanceTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkingAccNoTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checking Acc Info";
            // 
            // checkingAccBalanceTxtBox
            // 
            this.checkingAccBalanceTxtBox.Location = new System.Drawing.Point(110, 114);
            this.checkingAccBalanceTxtBox.Name = "checkingAccBalanceTxtBox";
            this.checkingAccBalanceTxtBox.Size = new System.Drawing.Size(161, 26);
            this.checkingAccBalanceTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // checkingAccNoTxtBox
            // 
            this.checkingAccNoTxtBox.Location = new System.Drawing.Point(109, 49);
            this.checkingAccNoTxtBox.Name = "checkingAccNoTxtBox";
            this.checkingAccNoTxtBox.Size = new System.Drawing.Size(161, 26);
            this.checkingAccNoTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savingAccBalanceTxtBox);
            this.groupBox2.Controls.Add(this.savingsAccNoTxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(105, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Savings Acc Info";
            // 
            // savingAccBalanceTxtBox
            // 
            this.savingAccBalanceTxtBox.Location = new System.Drawing.Point(110, 110);
            this.savingAccBalanceTxtBox.Name = "savingAccBalanceTxtBox";
            this.savingAccBalanceTxtBox.Size = new System.Drawing.Size(161, 26);
            this.savingAccBalanceTxtBox.TabIndex = 3;
            // 
            // savingsAccNoTxtBox
            // 
            this.savingsAccNoTxtBox.Location = new System.Drawing.Point(110, 45);
            this.savingsAccNoTxtBox.Name = "savingsAccNoTxtBox";
            this.savingsAccNoTxtBox.Size = new System.Drawing.Size(161, 26);
            this.savingsAccNoTxtBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account No";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(105, 560);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(277, 560);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(144, 23);
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "Show Account Info";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Visible = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Locaiton";
            // 
            // locationTxtbox
            // 
            this.locationTxtbox.Location = new System.Drawing.Point(277, 129);
            this.locationTxtbox.Name = "locationTxtbox";
            this.locationTxtbox.Size = new System.Drawing.Size(144, 20);
            this.locationTxtbox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(99, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bank Account Application";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 612);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.locationTxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accHolderNameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "MainUI";
            this.Text = "Bank Account App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accHolderNameTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox checkingAccBalanceTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox checkingAccNoTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox savingAccBalanceTxtBox;
        private System.Windows.Forms.TextBox savingsAccNoTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox locationTxtbox;
        private System.Windows.Forms.Label label7;
    }
}

