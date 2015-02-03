namespace Ex2_1
{
    partial class InvoiceTotal
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
            this.LabelSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LabelDiscountPercent = new System.Windows.Forms.Label();
            this.LabelDiscountAmount = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelSubtotal
            // 
            this.LabelSubtotal.AutoSize = true;
            this.LabelSubtotal.Location = new System.Drawing.Point(53, 89);
            this.LabelSubtotal.Name = "LabelSubtotal";
            this.LabelSubtotal.Size = new System.Drawing.Size(59, 12);
            this.LabelSubtotal.TabIndex = 0;
            this.LabelSubtotal.Text = "&Subtotal:";
            this.LabelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(184, 80);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(136, 21);
            this.txtSubtotal.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(184, 162);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(136, 21);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(184, 134);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(136, 21);
            this.txtDiscountAmount.TabIndex = 3;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(184, 107);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(136, 21);
            this.txtDiscountPercent.TabIndex = 4;
            this.txtDiscountPercent.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(89, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(206, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LabelDiscountPercent
            // 
            this.LabelDiscountPercent.AutoSize = true;
            this.LabelDiscountPercent.Location = new System.Drawing.Point(53, 116);
            this.LabelDiscountPercent.Name = "LabelDiscountPercent";
            this.LabelDiscountPercent.Size = new System.Drawing.Size(107, 12);
            this.LabelDiscountPercent.TabIndex = 7;
            this.LabelDiscountPercent.Text = "Discount percent:";
            this.LabelDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelDiscountAmount
            // 
            this.LabelDiscountAmount.AutoSize = true;
            this.LabelDiscountAmount.Location = new System.Drawing.Point(53, 143);
            this.LabelDiscountAmount.Name = "LabelDiscountAmount";
            this.LabelDiscountAmount.Size = new System.Drawing.Size(101, 12);
            this.LabelDiscountAmount.TabIndex = 8;
            this.LabelDiscountAmount.Text = "Discount amount:";
            this.LabelDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(53, 171);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(41, 12);
            this.LabelTotal.TabIndex = 9;
            this.LabelTotal.Text = "Total:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(388, 352);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelDiscountAmount);
            this.Controls.Add(this.LabelDiscountPercent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.LabelSubtotal);
            this.Name = "InvoiceTotal";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LabelDiscountPercent;
        private System.Windows.Forms.Label LabelDiscountAmount;
        private System.Windows.Forms.Label LabelTotal;
    }
}

