namespace MainForm
{
    partial class AddAssignment
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
            this._ckdlstCourses = new System.Windows.Forms.CheckedListBox();
            this._lstAssign = new System.Windows.Forms.ListBox();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _ckdlstCourses
            // 
            this._ckdlstCourses.FormattingEnabled = true;
            this._ckdlstCourses.Location = new System.Drawing.Point(128, 71);
            this._ckdlstCourses.Name = "_ckdlstCourses";
            this._ckdlstCourses.Size = new System.Drawing.Size(236, 169);
            this._ckdlstCourses.TabIndex = 0;
            // 
            // _lstAssign
            // 
            this._lstAssign.FormattingEnabled = true;
            this._lstAssign.Location = new System.Drawing.Point(451, 71);
            this._lstAssign.Name = "_lstAssign";
            this._lstAssign.Size = new System.Drawing.Size(236, 173);
            this._lstAssign.TabIndex = 1;
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(289, 400);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 3;
            this._btnOK.Text = "&OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this.OnClickOK);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(451, 400);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnClickCancel);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(128, 246);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "&Add Courses";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnClickAddCourses);
            // 
            // AddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._lstAssign);
            this.Controls.Add(this._ckdlstCourses);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddAssignment";
            this.Text = "AddAssignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox _ckdlstCourses;
        private System.Windows.Forms.ListBox _lstAssign;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnAdd;
    }
}