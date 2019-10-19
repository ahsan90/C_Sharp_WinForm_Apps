namespace MD_Pizza_Express
{
    partial class PizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.tabControlStuff = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pizza = new System.Windows.Forms.TabPage();
            this.orderButton = new System.Windows.Forms.Button();
            this.checkedListBoxForIngredients = new System.Windows.Forms.CheckedListBox();
            this.ingredients = new System.Windows.Forms.Label();
            this.souceComboBox = new System.Windows.Forms.ComboBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.size = new System.Windows.Forms.Label();
            this.souceType = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.richTextBoxSummary = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlStuff.SuspendLayout();
            this.home.SuspendLayout();
            this.pizza.SuspendLayout();
            this.summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStuff
            // 
            this.tabControlStuff.Controls.Add(this.home);
            this.tabControlStuff.Controls.Add(this.pizza);
            this.tabControlStuff.Controls.Add(this.summary);
            this.tabControlStuff.Location = new System.Drawing.Point(-1, 1);
            this.tabControlStuff.Name = "tabControlStuff";
            this.tabControlStuff.SelectedIndex = 0;
            this.tabControlStuff.Size = new System.Drawing.Size(763, 529);
            this.tabControlStuff.TabIndex = 0;
            // 
            // home
            // 
            this.home.Controls.Add(this.groupBox1);
            this.home.Controls.Add(this.label1);
            this.home.Location = new System.Drawing.Point(4, 25);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(755, 500);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "MD Pizza Express";
            // 
            // pizza
            // 
            this.pizza.Controls.Add(this.orderButton);
            this.pizza.Controls.Add(this.checkedListBoxForIngredients);
            this.pizza.Controls.Add(this.ingredients);
            this.pizza.Controls.Add(this.souceComboBox);
            this.pizza.Controls.Add(this.sizeComboBox);
            this.pizza.Controls.Add(this.size);
            this.pizza.Controls.Add(this.souceType);
            this.pizza.Controls.Add(this.selection);
            this.pizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pizza.Location = new System.Drawing.Point(4, 25);
            this.pizza.Name = "pizza";
            this.pizza.Padding = new System.Windows.Forms.Padding(3);
            this.pizza.Size = new System.Drawing.Size(755, 500);
            this.pizza.TabIndex = 1;
            this.pizza.Text = "Pizza";
            this.pizza.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(277, 433);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(126, 32);
            this.orderButton.TabIndex = 7;
            this.orderButton.Text = "Add to Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // checkedListBoxForIngredients
            // 
            this.checkedListBoxForIngredients.Location = new System.Drawing.Point(237, 275);
            this.checkedListBoxForIngredients.Name = "checkedListBoxForIngredients";
            this.checkedListBoxForIngredients.Size = new System.Drawing.Size(222, 130);
            this.checkedListBoxForIngredients.TabIndex = 8;
            // 
            // ingredients
            // 
            this.ingredients.AutoSize = true;
            this.ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredients.ForeColor = System.Drawing.Color.Maroon;
            this.ingredients.Location = new System.Drawing.Point(248, 247);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(210, 25);
            this.ingredients.TabIndex = 5;
            this.ingredients.Text = "Toppings (each $0.75)";
            // 
            // souceComboBox
            // 
            this.souceComboBox.FormattingEnabled = true;
            this.souceComboBox.Location = new System.Drawing.Point(408, 170);
            this.souceComboBox.Name = "souceComboBox";
            this.souceComboBox.Size = new System.Drawing.Size(164, 24);
            this.souceComboBox.TabIndex = 4;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(116, 170);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(164, 24);
            this.sizeComboBox.TabIndex = 3;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.ForeColor = System.Drawing.Color.Black;
            this.size.Location = new System.Drawing.Point(164, 114);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(51, 25);
            this.size.TabIndex = 2;
            this.size.Text = "Size";
            // 
            // souceType
            // 
            this.souceType.AutoSize = true;
            this.souceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.souceType.ForeColor = System.Drawing.Color.Black;
            this.souceType.Location = new System.Drawing.Point(434, 114);
            this.souceType.Name = "souceType";
            this.souceType.Size = new System.Drawing.Size(119, 25);
            this.souceType.TabIndex = 1;
            this.souceType.Text = "Sauce Type";
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection.Location = new System.Drawing.Point(219, 47);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(275, 31);
            this.selection.TabIndex = 0;
            this.selection.Text = "Build Your Own Pizza";
            this.selection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // summary
            // 
            this.summary.Controls.Add(this.label2);
            this.summary.Controls.Add(this.clearBtn);
            this.summary.Controls.Add(this.richTextBoxSummary);
            this.summary.Location = new System.Drawing.Point(4, 25);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(3);
            this.summary.Size = new System.Drawing.Size(755, 500);
            this.summary.TabIndex = 2;
            this.summary.Text = "Summary";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Summary Information";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(298, 407);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(114, 30);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // richTextBoxSummary
            // 
            this.richTextBoxSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxSummary.Location = new System.Drawing.Point(151, 86);
            this.richTextBoxSummary.Name = "richTextBoxSummary";
            this.richTextBoxSummary.Size = new System.Drawing.Size(415, 294);
            this.richTextBoxSummary.TabIndex = 0;
            this.richTextBoxSummary.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Location = new System.Drawing.Point(47, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 335);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 530);
            this.Controls.Add(this.tabControlStuff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PizzaForm";
            this.Text = "MD Pizza Express";
            this.tabControlStuff.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.pizza.ResumeLayout(false);
            this.pizza.PerformLayout();
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStuff;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage pizza;
        private System.Windows.Forms.TabPage summary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.CheckedListBox checkedListBoxForIngredients;
        private System.Windows.Forms.Label ingredients;
        private System.Windows.Forms.ComboBox souceComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label souceType;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.RichTextBox richTextBoxSummary;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

