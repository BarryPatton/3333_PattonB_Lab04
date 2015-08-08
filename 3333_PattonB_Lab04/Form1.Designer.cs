namespace _3333_PattonB_Lab04
{
    partial class Form1
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
            this.textBoxNumberOfPackages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTotalBeforeDiscount = new System.Windows.Forms.Label();
            this.labelDiscountPercentage = new System.Windows.Forms.Label();
            this.labelTotalAfterDiscount = new System.Windows.Forms.Label();
            this.labelSavingsFromDiscount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the number of packages purchased:";
            // 
            // textBoxNumberOfPackages
            // 
            this.textBoxNumberOfPackages.Location = new System.Drawing.Point(224, 27);
            this.textBoxNumberOfPackages.Name = "textBoxNumberOfPackages";
            this.textBoxNumberOfPackages.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfPackages.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total before discount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 105);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount Percentage:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(15, 223);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Enter += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(132, 223);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(249, 223);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTotalBeforeDiscount
            // 
            this.labelTotalBeforeDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalBeforeDiscount.Location = new System.Drawing.Point(224, 64);
            this.labelTotalBeforeDiscount.Name = "labelTotalBeforeDiscount";
            this.labelTotalBeforeDiscount.Size = new System.Drawing.Size(100, 23);
            this.labelTotalBeforeDiscount.TabIndex = 6;
            // 
            // labelDiscountPercentage
            // 
            this.labelDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDiscountPercentage.Location = new System.Drawing.Point(224, 105);
            this.labelDiscountPercentage.Name = "labelDiscountPercentage";
            this.labelDiscountPercentage.Size = new System.Drawing.Size(100, 23);
            this.labelDiscountPercentage.TabIndex = 8;
            // 
            // labelTotalAfterDiscount
            // 
            this.labelTotalAfterDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAfterDiscount.Location = new System.Drawing.Point(224, 185);
            this.labelTotalAfterDiscount.Name = "labelTotalAfterDiscount";
            this.labelTotalAfterDiscount.Size = new System.Drawing.Size(100, 23);
            this.labelTotalAfterDiscount.TabIndex = 12;
            // 
            // labelSavingsFromDiscount
            // 
            this.labelSavingsFromDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSavingsFromDiscount.Location = new System.Drawing.Point(224, 144);
            this.labelSavingsFromDiscount.Name = "labelSavingsFromDiscount";
            this.labelSavingsFromDiscount.Size = new System.Drawing.Size(100, 23);
            this.labelSavingsFromDiscount.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 185);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total after discount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Savings from Discount:";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(347, 263);
            this.Controls.Add(this.labelTotalAfterDiscount);
            this.Controls.Add(this.labelSavingsFromDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDiscountPercentage);
            this.Controls.Add(this.labelTotalBeforeDiscount);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumberOfPackages);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTotalBeforeDiscount;
        private System.Windows.Forms.Label labelDiscountPercentage;
        private System.Windows.Forms.Label labelTotalAfterDiscount;
        private System.Windows.Forms.Label labelSavingsFromDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

