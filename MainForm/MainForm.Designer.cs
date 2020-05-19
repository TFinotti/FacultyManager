namespace MainForm
{
    partial class MainForm
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
            this._lstFaculty = new System.Windows.Forms.ListBox();
            this._lstAssign = new System.Windows.Forms.ListBox();
            this._btnFaculty = new System.Windows.Forms.Button();
            this._btnAddAssign = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnNotAssigned = new System.Windows.Forms.Button();
            this._btnFacultyAssigned = new System.Windows.Forms.Button();
            this._txtCourseCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lstFaculty
            // 
            this._lstFaculty.FormattingEnabled = true;
            this._lstFaculty.Location = new System.Drawing.Point(47, 31);
            this._lstFaculty.Name = "_lstFaculty";
            this._lstFaculty.Size = new System.Drawing.Size(300, 186);
            this._lstFaculty.TabIndex = 0;
            this._lstFaculty.SelectedIndexChanged += new System.EventHandler(this.OnSelectItem);
            // 
            // _lstAssign
            // 
            this._lstAssign.FormattingEnabled = true;
            this._lstAssign.Location = new System.Drawing.Point(442, 31);
            this._lstAssign.Name = "_lstAssign";
            this._lstAssign.Size = new System.Drawing.Size(300, 186);
            this._lstAssign.TabIndex = 1;
            // 
            // _btnFaculty
            // 
            this._btnFaculty.Location = new System.Drawing.Point(152, 399);
            this._btnFaculty.Name = "_btnFaculty";
            this._btnFaculty.Size = new System.Drawing.Size(75, 23);
            this._btnFaculty.TabIndex = 5;
            this._btnFaculty.Text = "Add &Faculty";
            this._btnFaculty.UseVisualStyleBackColor = true;
            this._btnFaculty.Click += new System.EventHandler(this.OnClickAddFaculty);
            // 
            // _btnAddAssign
            // 
            this._btnAddAssign.Location = new System.Drawing.Point(562, 399);
            this._btnAddAssign.Name = "_btnAddAssign";
            this._btnAddAssign.Size = new System.Drawing.Size(75, 23);
            this._btnAddAssign.TabIndex = 7;
            this._btnAddAssign.Text = "Add &Assign";
            this._btnAddAssign.UseVisualStyleBackColor = true;
            this._btnAddAssign.Click += new System.EventHandler(this.OnClickAddAssign);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(357, 399);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 6;
            this._btnSave.Text = "&Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnClickSave);
            // 
            // _btnNotAssigned
            // 
            this._btnNotAssigned.Location = new System.Drawing.Point(47, 224);
            this._btnNotAssigned.Name = "_btnNotAssigned";
            this._btnNotAssigned.Size = new System.Drawing.Size(153, 23);
            this._btnNotAssigned.TabIndex = 2;
            this._btnNotAssigned.Text = "Show &Faculties Not Assigned";
            this._btnNotAssigned.UseVisualStyleBackColor = true;
            this._btnNotAssigned.Click += new System.EventHandler(this.OnClickNotAssigned);
            // 
            // _btnFacultyAssigned
            // 
            this._btnFacultyAssigned.Location = new System.Drawing.Point(442, 223);
            this._btnFacultyAssigned.Name = "_btnFacultyAssigned";
            this._btnFacultyAssigned.Size = new System.Drawing.Size(113, 23);
            this._btnFacultyAssigned.TabIndex = 3;
            this._btnFacultyAssigned.Text = "Search &Course Code";
            this._btnFacultyAssigned.UseVisualStyleBackColor = true;
            this._btnFacultyAssigned.Click += new System.EventHandler(this.OnClickSearch);
            // 
            // _txtCourseCode
            // 
            this._txtCourseCode.Location = new System.Drawing.Point(562, 225);
            this._txtCourseCode.Name = "_txtCourseCode";
            this._txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this._txtCourseCode.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtCourseCode);
            this.Controls.Add(this._btnFacultyAssigned);
            this.Controls.Add(this._btnNotAssigned);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnAddAssign);
            this.Controls.Add(this._btnFaculty);
            this.Controls.Add(this._lstAssign);
            this.Controls.Add(this._lstFaculty);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Faculty Management System";
            this.Activated += new System.EventHandler(this.OnActivatedMainForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox _lstAssign;
        private System.Windows.Forms.Button _btnFaculty;
        private System.Windows.Forms.Button _btnAddAssign;
        private System.Windows.Forms.Button _btnSave;
        internal System.Windows.Forms.ListBox _lstFaculty;
        private System.Windows.Forms.Button _btnNotAssigned;
        private System.Windows.Forms.Button _btnFacultyAssigned;
        private System.Windows.Forms.TextBox _txtCourseCode;
    }
}

