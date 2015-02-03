namespace W2Lab_Zeng
{
    partial class ChildGeneralPassportApplication
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.gpSex = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.chkReturn = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.gpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(55, 30);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(53, 12);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "S&urname:";
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Location = new System.Drawing.Point(55, 67);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(71, 12);
            this.lblGivenName.TabIndex = 2;
            this.lblGivenName.Text = "&Given Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(55, 106);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(89, 12);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "&Date of Birth:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(180, 27);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(176, 21);
            this.txtSurname.TabIndex = 1;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Location = new System.Drawing.Point(180, 64);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(176, 21);
            this.txtGivenName.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(180, 100);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(176, 21);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(49, 20);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 16);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "&Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(487, 27);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(118, 109);
            this.picPhoto.TabIndex = 7;
            this.picPhoto.TabStop = false;
            // 
            // gpSex
            // 
            this.gpSex.Controls.Add(this.rdoFemale);
            this.gpSex.Controls.Add(this.rdoMale);
            this.gpSex.Location = new System.Drawing.Point(180, 141);
            this.gpSex.Name = "gpSex";
            this.gpSex.Size = new System.Drawing.Size(154, 77);
            this.gpSex.TabIndex = 6;
            this.gpSex.TabStop = false;
            this.gpSex.Text = "Sex";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(49, 42);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 16);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "&Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(55, 235);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(95, 12);
            this.lblPlaceOfBirth.TabIndex = 10;
            this.lblPlaceOfBirth.Text = "Place of Birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(178, 235);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 12);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "&City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(213, 232);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(319, 235);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(47, 12);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "C&ountry";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(478, 235);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(53, 12);
            this.lblProvince.TabIndex = 12;
            this.lblProvince.Text = "&Province";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(178, 266);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(323, 12);
            this.lblConfirm.TabIndex = 14;
            this.lblConfirm.Text = "&Would you like the previous passport returned to you?";
            // 
            // chkReturn
            // 
            this.chkReturn.AutoSize = true;
            this.chkReturn.Location = new System.Drawing.Point(180, 291);
            this.chkReturn.Name = "chkReturn";
            this.chkReturn.Size = new System.Drawing.Size(294, 16);
            this.chkReturn.TabIndex = 15;
            this.chkReturn.Text = "Yes, please return to previous passport to me";
            this.chkReturn.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(372, 232);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 21);
            this.txtCountry.TabIndex = 11;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "ON",
            "QC",
            "QW",
            "AS",
            "ZX",
            "ER",
            "DF",
            "CV"});
            this.cboProvince.Location = new System.Drawing.Point(537, 232);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(68, 20);
            this.cboProvince.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(487, 143);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(117, 23);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "Choose File...";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ChildGeneralPassportApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 376);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkReturn);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPlaceOfBirth);
            this.Controls.Add(this.gpSex);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGivenName);
            this.Controls.Add(this.lblSurname);
            this.Name = "ChildGeneralPassportApplication";
            this.Text = "Child General Passport Application";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.gpSex.ResumeLayout(false);
            this.gpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.GroupBox gpSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.CheckBox chkReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChoose;
    }
}

