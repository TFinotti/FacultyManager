namespace MainForm
{
    partial class FacultyAssignment
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
            this._lblResult = new System.Windows.Forms.Label();
            this._lstResult = new System.Windows.Forms.ListBox();
            this._btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblResult
            // 
            this._lblResult.AutoSize = true;
            this._lblResult.Location = new System.Drawing.Point(54, 49);
            this._lblResult.Name = "_lblResult";
            this._lblResult.Size = new System.Drawing.Size(37, 13);
            this._lblResult.TabIndex = 0;
            this._lblResult.Text = "Result";
            // 
            // _lstResult
            // 
            this._lstResult.FormattingEnabled = true;
            this._lstResult.Location = new System.Drawing.Point(97, 49);
            this._lstResult.Name = "_lstResult";
            this._lstResult.Size = new System.Drawing.Size(208, 95);
            this._lstResult.TabIndex = 1;
            // 
            // _btnOK
            // 
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(165, 150);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "&OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // FacultyAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._lstResult);
            this.Controls.Add(this._lblResult);
            this.MaximumSize = new System.Drawing.Size(408, 244);
            this.MinimumSize = new System.Drawing.Size(408, 244);
            this.Name = "FacultyAssignment";
            this.Text = "Faculty Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblResult;
        private System.Windows.Forms.Button _btnOK;
        internal System.Windows.Forms.ListBox _lstResult;
    }
}