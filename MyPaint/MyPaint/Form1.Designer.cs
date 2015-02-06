namespace MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEraseAll = new System.Windows.Forms.ToolStripButton();
            this.btnFontColor = new System.Windows.Forms.ToolStripButton();
            this.cboBrushSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(42, 42);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(200, 100);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEraseAll,
            this.toolStripSeparator1,
            this.btnFontColor,
            this.toolStripSeparator2,
            this.cboBrushSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEraseAll
            // 
            this.btnEraseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEraseAll.Image = ((System.Drawing.Image)(resources.GetObject("btnEraseAll.Image")));
            this.btnEraseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEraseAll.Name = "btnEraseAll";
            this.btnEraseAll.Size = new System.Drawing.Size(55, 22);
            this.btnEraseAll.Text = "Erase All";
            this.btnEraseAll.Click += new System.EventHandler(this.btnEraseAll_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("btnFontColor.Image")));
            this.btnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(67, 22);
            this.btnFontColor.Text = "Font Color";
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // cboBrushSize
            // 
            this.cboBrushSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboBrushSize.Name = "cboBrushSize";
            this.cboBrushSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboBrushSize.Size = new System.Drawing.Size(121, 25);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(42, 166);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.Text = "yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            this.btnYellow.MouseLeave += new System.EventHandler(this.btnYellow_MouseLeave);
            this.btnYellow.MouseHover += new System.EventHandler(this.btnYellow_MouseHover);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(167, 166);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 3;
            this.btnBlue.Text = "blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            this.btnBlue.MouseLeave += new System.EventHandler(this.btnBlue_MouseLeave);
            this.btnBlue.MouseHover += new System.EventHandler(this.btnBlue_MouseHover);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(42, 195);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 4;
            this.btnRed.Text = "red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            this.btnRed.MouseLeave += new System.EventHandler(this.btnRed_MouseLeave);
            this.btnRed.MouseHover += new System.EventHandler(this.btnRed_MouseHover);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(167, 195);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 23);
            this.btnGreen.TabIndex = 5;
            this.btnGreen.Text = "green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            this.btnGreen.MouseLeave += new System.EventHandler(this.btnGreen_MouseLeave);
            this.btnGreen.MouseHover += new System.EventHandler(this.btnGreen_MouseHover);
            // 
            // btnPink
            // 
            this.btnPink.Location = new System.Drawing.Point(42, 224);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(75, 23);
            this.btnPink.TabIndex = 6;
            this.btnPink.Text = "pink";
            this.btnPink.UseVisualStyleBackColor = true;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            this.btnPink.MouseLeave += new System.EventHandler(this.btnPink_MouseLeave);
            this.btnPink.MouseHover += new System.EventHandler(this.btnPink_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEraseAll;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.ToolStripButton btnFontColor;
        private System.Windows.Forms.ToolStripComboBox cboBrushSize;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

