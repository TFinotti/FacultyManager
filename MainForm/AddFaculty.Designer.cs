namespace MainForm
{
    partial class AddFaculty
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
            this._lblName = new System.Windows.Forms.Label();
            this._lblStreet = new System.Windows.Forms.Label();
            this._lblTel = new System.Windows.Forms.Label();
            this._lblEmail = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtStreet = new System.Windows.Forms.TextBox();
            this._txtTel = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._lblStartDate = new System.Windows.Forms.Label();
            this._dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this._txtCity = new System.Windows.Forms.TextBox();
            this._lblCity = new System.Windows.Forms.Label();
            this._txtProvince = new System.Windows.Forms.TextBox();
            this._lblProvince = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(109, 47);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(35, 13);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Name";
            // 
            // _lblStreet
            // 
            this._lblStreet.AutoSize = true;
            this._lblStreet.Location = new System.Drawing.Point(99, 99);
            this._lblStreet.Name = "_lblStreet";
            this._lblStreet.Size = new System.Drawing.Size(35, 13);
            this._lblStreet.TabIndex = 2;
            this._lblStreet.Text = "Street";
            // 
            // _lblTel
            // 
            this._lblTel.AutoSize = true;
            this._lblTel.Location = new System.Drawing.Point(66, 149);
            this._lblTel.Name = "_lblTel";
            this._lblTel.Size = new System.Drawing.Size(78, 13);
            this._lblTel.TabIndex = 8;
            this._lblTel.Text = "Phone Number";
            // 
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.Location = new System.Drawing.Point(112, 201);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(32, 13);
            this._lblEmail.TabIndex = 10;
            this._lblEmail.Text = "Email";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(150, 44);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(199, 20);
            this._txtName.TabIndex = 1;
            // 
            // _txtStreet
            // 
            this._txtStreet.Location = new System.Drawing.Point(150, 95);
            this._txtStreet.Name = "_txtStreet";
            this._txtStreet.Size = new System.Drawing.Size(161, 20);
            this._txtStreet.TabIndex = 3;
            // 
            // _txtTel
            // 
            this._txtTel.Location = new System.Drawing.Point(150, 146);
            this._txtTel.Name = "_txtTel";
            this._txtTel.Size = new System.Drawing.Size(100, 20);
            this._txtTel.TabIndex = 9;
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(150, 197);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(161, 20);
            this._txtEmail.TabIndex = 11;
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(277, 381);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 14;
            this._btnOK.Text = "&OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this.OnClickOK);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(429, 381);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 15;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnClickCancel);
            // 
            // _lblStartDate
            // 
            this._lblStartDate.AutoSize = true;
            this._lblStartDate.Location = new System.Drawing.Point(89, 253);
            this._lblStartDate.Name = "_lblStartDate";
            this._lblStartDate.Size = new System.Drawing.Size(55, 13);
            this._lblStartDate.TabIndex = 12;
            this._lblStartDate.Text = "Start Date";
            // 
            // _dtpStartDate
            // 
            this._dtpStartDate.Location = new System.Drawing.Point(150, 248);
            this._dtpStartDate.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this._dtpStartDate.Name = "_dtpStartDate";
            this._dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this._dtpStartDate.TabIndex = 13;
            // 
            // _txtCity
            // 
            this._txtCity.Location = new System.Drawing.Point(374, 95);
            this._txtCity.Name = "_txtCity";
            this._txtCity.Size = new System.Drawing.Size(115, 20);
            this._txtCity.TabIndex = 5;
            // 
            // _lblCity
            // 
            this._lblCity.AutoSize = true;
            this._lblCity.Location = new System.Drawing.Point(344, 99);
            this._lblCity.Name = "_lblCity";
            this._lblCity.Size = new System.Drawing.Size(24, 13);
            this._lblCity.TabIndex = 4;
            this._lblCity.Text = "City";
            // 
            // _txtProvince
            // 
            this._txtProvince.Location = new System.Drawing.Point(579, 95);
            this._txtProvince.Name = "_txtProvince";
            this._txtProvince.Size = new System.Drawing.Size(26, 20);
            this._txtProvince.TabIndex = 7;
            // 
            // _lblProvince
            // 
            this._lblProvince.AutoSize = true;
            this._lblProvince.Location = new System.Drawing.Point(528, 99);
            this._lblProvince.Name = "_lblProvince";
            this._lblProvince.Size = new System.Drawing.Size(49, 13);
            this._lblProvince.TabIndex = 6;
            this._lblProvince.Text = "Province";
            // 
            // AddFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtProvince);
            this.Controls.Add(this._lblProvince);
            this.Controls.Add(this._txtCity);
            this.Controls.Add(this._lblCity);
            this.Controls.Add(this._dtpStartDate);
            this.Controls.Add(this._lblStartDate);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._txtTel);
            this.Controls.Add(this._txtStreet);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._lblEmail);
            this.Controls.Add(this._lblTel);
            this.Controls.Add(this._lblStreet);
            this.Controls.Add(this._lblName);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddFaculty";
            this.Text = "AddFaculty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblStreet;
        private System.Windows.Forms.Label _lblTel;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtStreet;
        private System.Windows.Forms.TextBox _txtTel;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label _lblStartDate;
        private System.Windows.Forms.DateTimePicker _dtpStartDate;
        private System.Windows.Forms.TextBox _txtCity;
        private System.Windows.Forms.Label _lblCity;
        private System.Windows.Forms.TextBox _txtProvince;
        private System.Windows.Forms.Label _lblProvince;
    }
}