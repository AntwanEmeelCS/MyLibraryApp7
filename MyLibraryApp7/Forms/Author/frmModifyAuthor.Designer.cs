
namespace MyLibraryApp7.Forms.Author
{
    partial class frmModifyAuthor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNationalities = new System.Windows.Forms.ComboBox();
            this.cboAuthors = new System.Windows.Forms.ComboBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(341, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(89, 199);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 50);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Author Name";
            // 
            // cboNationalities
            // 
            this.cboNationalities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNationalities.FormattingEnabled = true;
            this.cboNationalities.Location = new System.Drawing.Point(285, 125);
            this.cboNationalities.Name = "cboNationalities";
            this.cboNationalities.Size = new System.Drawing.Size(322, 39);
            this.cboNationalities.TabIndex = 15;
            this.cboNationalities.SelectedIndexChanged += new System.EventHandler(this.cboNationalities_SelectedIndexChanged);
            // 
            // cboAuthors
            // 
            this.cboAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthors.FormattingEnabled = true;
            this.cboAuthors.Location = new System.Drawing.Point(285, 22);
            this.cboAuthors.Name = "cboAuthors";
            this.cboAuthors.Size = new System.Drawing.Size(322, 39);
            this.cboAuthors.TabIndex = 16;
            this.cboAuthors.SelectedIndexChanged += new System.EventHandler(this.cboAuthors_SelectedIndexChanged);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(285, 72);
            this.txtAuthorName.MaxLength = 50;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(322, 39);
            this.txtAuthorName.TabIndex = 17;
            // 
            // frmModifyAuthor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(637, 278);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.cboAuthors);
            this.Controls.Add(this.cboNationalities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Existing Author";
            this.Load += new System.EventHandler(this.frmModifyAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNationalities;
        private System.Windows.Forms.ComboBox cboAuthors;
        private System.Windows.Forms.TextBox txtAuthorName;
    }
}