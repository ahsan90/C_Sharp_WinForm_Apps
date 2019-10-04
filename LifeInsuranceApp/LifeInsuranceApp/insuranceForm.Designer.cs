namespace LifeInsuranceApp
{
    partial class InsuranceForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.richTextBoxForResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxInsuranceAmount = new System.Windows.Forms.TextBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lNameValitionError = new System.Windows.Forms.Label();
            this.fNameValidationError = new System.Windows.Forms.Label();
            this.insuranceAmountValidationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(309, 23);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(218, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Life Insurance Applicaiton";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(159, 317);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(202, 106);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLastName.Location = new System.Drawing.Point(465, 106);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(120, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // richTextBoxForResult
            // 
            this.richTextBoxForResult.Location = new System.Drawing.Point(163, 404);
            this.richTextBoxForResult.Name = "richTextBoxForResult";
            this.richTextBoxForResult.Size = new System.Drawing.Size(507, 162);
            this.richTextBoxForResult.TabIndex = 4;
            this.richTextBoxForResult.Text = "Result will be displayed here...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insurance Amount";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(465, 171);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 26);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxInsuranceAmount
            // 
            this.textBoxInsuranceAmount.Location = new System.Drawing.Point(465, 233);
            this.textBoxInsuranceAmount.Name = "textBoxInsuranceAmount";
            this.textBoxInsuranceAmount.Size = new System.Drawing.Size(120, 26);
            this.textBoxInsuranceAmount.TabIndex = 8;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(290, 317);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(98, 30);
            this.btnSummary.TabIndex = 9;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.BtnSummary_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(421, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(559, 317);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(111, 30);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // lNameValitionError
            // 
            this.lNameValitionError.AutoSize = true;
            this.lNameValitionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameValitionError.Location = new System.Drawing.Point(465, 139);
            this.lNameValitionError.Name = "lNameValitionError";
            this.lNameValitionError.Size = new System.Drawing.Size(0, 13);
            this.lNameValitionError.TabIndex = 12;
            // 
            // fNameValidationError
            // 
            this.fNameValidationError.AutoSize = true;
            this.fNameValidationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameValidationError.Location = new System.Drawing.Point(465, 200);
            this.fNameValidationError.Name = "fNameValidationError";
            this.fNameValidationError.Size = new System.Drawing.Size(0, 13);
            this.fNameValidationError.TabIndex = 13;
            // 
            // insuranceAmountValidationError
            // 
            this.insuranceAmountValidationError.AutoSize = true;
            this.insuranceAmountValidationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceAmountValidationError.Location = new System.Drawing.Point(462, 262);
            this.insuranceAmountValidationError.Name = "insuranceAmountValidationError";
            this.insuranceAmountValidationError.Size = new System.Drawing.Size(0, 13);
            this.insuranceAmountValidationError.TabIndex = 14;
            // 
            // InsuranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 612);
            this.Controls.Add(this.insuranceAmountValidationError);
            this.Controls.Add(this.fNameValidationError);
            this.Controls.Add(this.lNameValitionError);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.textBoxInsuranceAmount);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxForResult);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsuranceForm";
            this.Text = "Life Insurance Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.RichTextBox richTextBoxForResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxInsuranceAmount;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lNameValitionError;
        private System.Windows.Forms.Label fNameValidationError;
        private System.Windows.Forms.Label insuranceAmountValidationError;
    }
}

