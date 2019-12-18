namespace FastFoodDTOS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.mealTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.fishQTextBox = new System.Windows.Forms.TextBox();
            this.subQTextBox = new System.Windows.Forms.TextBox();
            this.hamQTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fishCheckBox = new System.Windows.Forms.CheckBox();
            this.subCheckBox = new System.Windows.Forms.CheckBox();
            this.hamCheckBox = new System.Windows.Forms.CheckBox();
            this.mealChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mealTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.placeOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem1,
            this.checkoutOrderToolStripMenuItem});
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.placeOrderToolStripMenuItem.Text = "Order";
            // 
            // placeOrderToolStripMenuItem1
            // 
            this.placeOrderToolStripMenuItem1.Name = "placeOrderToolStripMenuItem1";
            this.placeOrderToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.placeOrderToolStripMenuItem1.Text = "Place Order";
            this.placeOrderToolStripMenuItem1.Click += new System.EventHandler(this.placeOrderToolStripMenuItem1_Click);
            // 
            // checkoutOrderToolStripMenuItem
            // 
            this.checkoutOrderToolStripMenuItem.Name = "checkoutOrderToolStripMenuItem";
            this.checkoutOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkoutOrderToolStripMenuItem.Text = "Checkout Order";
            this.checkoutOrderToolStripMenuItem.Click += new System.EventHandler(this.checkoutOrderToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(228, 130);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(228, 170);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // mealTypeGroupBox
            // 
            this.mealTypeGroupBox.Controls.Add(this.fishQTextBox);
            this.mealTypeGroupBox.Controls.Add(this.subQTextBox);
            this.mealTypeGroupBox.Controls.Add(this.hamQTextBox);
            this.mealTypeGroupBox.Controls.Add(this.label3);
            this.mealTypeGroupBox.Controls.Add(this.fishCheckBox);
            this.mealTypeGroupBox.Controls.Add(this.subCheckBox);
            this.mealTypeGroupBox.Controls.Add(this.hamCheckBox);
            this.mealTypeGroupBox.Location = new System.Drawing.Point(164, 233);
            this.mealTypeGroupBox.Name = "mealTypeGroupBox";
            this.mealTypeGroupBox.Size = new System.Drawing.Size(305, 151);
            this.mealTypeGroupBox.TabIndex = 5;
            this.mealTypeGroupBox.TabStop = false;
            this.mealTypeGroupBox.Text = "Meal Type";
            // 
            // fishQTextBox
            // 
            this.fishQTextBox.Location = new System.Drawing.Point(168, 103);
            this.fishQTextBox.Name = "fishQTextBox";
            this.fishQTextBox.Size = new System.Drawing.Size(85, 23);
            this.fishQTextBox.TabIndex = 6;
            // 
            // subQTextBox
            // 
            this.subQTextBox.Location = new System.Drawing.Point(168, 75);
            this.subQTextBox.Name = "subQTextBox";
            this.subQTextBox.Size = new System.Drawing.Size(85, 23);
            this.subQTextBox.TabIndex = 5;
            // 
            // hamQTextBox
            // 
            this.hamQTextBox.Location = new System.Drawing.Point(168, 47);
            this.hamQTextBox.Name = "hamQTextBox";
            this.hamQTextBox.Size = new System.Drawing.Size(85, 23);
            this.hamQTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // fishCheckBox
            // 
            this.fishCheckBox.AutoSize = true;
            this.fishCheckBox.Location = new System.Drawing.Point(6, 103);
            this.fishCheckBox.Name = "fishCheckBox";
            this.fishCheckBox.Size = new System.Drawing.Size(114, 21);
            this.fishCheckBox.TabIndex = 2;
            this.fishCheckBox.Text = "Fish($8 each)";
            this.fishCheckBox.UseVisualStyleBackColor = true;
            // 
            // subCheckBox
            // 
            this.subCheckBox.AutoSize = true;
            this.subCheckBox.Location = new System.Drawing.Point(6, 75);
            this.subCheckBox.Name = "subCheckBox";
            this.subCheckBox.Size = new System.Drawing.Size(113, 21);
            this.subCheckBox.TabIndex = 1;
            this.subCheckBox.Text = "Sub($6 each)";
            this.subCheckBox.UseVisualStyleBackColor = true;
            // 
            // hamCheckBox
            // 
            this.hamCheckBox.AutoSize = true;
            this.hamCheckBox.Location = new System.Drawing.Point(6, 47);
            this.hamCheckBox.Name = "hamCheckBox";
            this.hamCheckBox.Size = new System.Drawing.Size(159, 21);
            this.hamCheckBox.TabIndex = 0;
            this.hamCheckBox.Text = "Hamburger($5 each)";
            this.hamCheckBox.UseVisualStyleBackColor = true;
            // 
            // mealChoiceComboBox
            // 
            this.mealChoiceComboBox.FormattingEnabled = true;
            this.mealChoiceComboBox.Items.AddRange(new object[] {
            "Meal Only",
            "Combo Meal",
            "Upsize Combo Meal"});
            this.mealChoiceComboBox.Location = new System.Drawing.Point(415, 170);
            this.mealChoiceComboBox.Name = "mealChoiceComboBox";
            this.mealChoiceComboBox.Size = new System.Drawing.Size(138, 24);
            this.mealChoiceComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Combo Option";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(93, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(460, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Drive Through Ordering POS System";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 440);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mealChoiceComboBox);
            this.Controls.Add(this.mealTypeGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUI";
            this.Text = "Drive Throug Ordering System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mealTypeGroupBox.ResumeLayout(false);
            this.mealTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkoutOrderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox mealTypeGroupBox;
        private System.Windows.Forms.TextBox fishQTextBox;
        private System.Windows.Forms.TextBox subQTextBox;
        private System.Windows.Forms.TextBox hamQTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fishCheckBox;
        private System.Windows.Forms.CheckBox subCheckBox;
        private System.Windows.Forms.CheckBox hamCheckBox;
        private System.Windows.Forms.ComboBox mealChoiceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

