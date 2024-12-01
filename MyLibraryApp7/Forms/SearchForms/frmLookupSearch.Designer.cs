
namespace MyLibraryApp7.Forms.SearchForms
{
    partial class frmLookupSearch
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
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbTableID = new System.Windows.Forms.RadioButton();
            this.rdbTableString = new System.Windows.Forms.RadioButton();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Keyword";
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(243, 19);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(325, 39);
            this.txtSearchKeyword.TabIndex = 1;
            this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Field";
            // 
            // rdbTableID
            // 
            this.rdbTableID.AutoSize = true;
            this.rdbTableID.Location = new System.Drawing.Point(243, 74);
            this.rdbTableID.Name = "rdbTableID";
            this.rdbTableID.Size = new System.Drawing.Size(138, 36);
            this.rdbTableID.TabIndex = 3;
            this.rdbTableID.Text = "Table ID";
            this.rdbTableID.UseVisualStyleBackColor = true;
            // 
            // rdbTableString
            // 
            this.rdbTableString.AutoSize = true;
            this.rdbTableString.Checked = true;
            this.rdbTableString.Location = new System.Drawing.Point(387, 74);
            this.rdbTableString.Name = "rdbTableString";
            this.rdbTableString.Size = new System.Drawing.Size(176, 36);
            this.rdbTableString.TabIndex = 4;
            this.rdbTableString.TabStop = true;
            this.rdbTableString.Text = "TableString";
            this.rdbTableString.UseVisualStyleBackColor = true;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(30, 126);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSearchResults.RowTemplate.Height = 30;
            this.dgvSearchResults.Size = new System.Drawing.Size(538, 376);
            this.dgvSearchResults.TabIndex = 5;
            // 
            // frmLookupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 535);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.rdbTableString);
            this.Controls.Add(this.rdbTableID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchKeyword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLookupSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search ??";
            this.Load += new System.EventHandler(this.frmLookupSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTableID;
        private System.Windows.Forms.RadioButton rdbTableString;
        private System.Windows.Forms.DataGridView dgvSearchResults;
    }
}