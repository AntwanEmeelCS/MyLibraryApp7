
namespace MyLibraryApp7.Forms.MyBooks
{
    partial class frmGoogleBooksSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvFoundBooks = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPubDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Author";
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(231, 74);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.Size = new System.Drawing.Size(555, 39);
            this.txtSearchAuthor.TabIndex = 2;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(231, 20);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(555, 39);
            this.txtSearchTitle.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(807, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Fetch Data";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvFoundBooks
            // 
            this.dgvFoundBooks.AllowUserToAddRows = false;
            this.dgvFoundBooks.AllowUserToDeleteRows = false;
            this.dgvFoundBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colAuthor,
            this.colPublisher,
            this.colPubDate,
            this.colISBN,
            this.colPageCount});
            this.dgvFoundBooks.Location = new System.Drawing.Point(23, 134);
            this.dgvFoundBooks.Name = "dgvFoundBooks";
            this.dgvFoundBooks.ReadOnly = true;
            this.dgvFoundBooks.RowHeadersWidth = 51;
            this.dgvFoundBooks.RowTemplate.Height = 30;
            this.dgvFoundBooks.Size = new System.Drawing.Size(970, 424);
            this.dgvFoundBooks.TabIndex = 4;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 150;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 150;
            // 
            // colPublisher
            // 
            this.colPublisher.HeaderText = "Publisher";
            this.colPublisher.MinimumWidth = 6;
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.ReadOnly = true;
            this.colPublisher.Width = 150;
            // 
            // colPubDate
            // 
            this.colPubDate.HeaderText = "Publication Date";
            this.colPubDate.MinimumWidth = 6;
            this.colPubDate.Name = "colPubDate";
            this.colPubDate.ReadOnly = true;
            this.colPubDate.Width = 150;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.MinimumWidth = 6;
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            this.colISBN.Width = 150;
            // 
            // colPageCount
            // 
            this.colPageCount.HeaderText = "Page Count";
            this.colPageCount.MinimumWidth = 6;
            this.colPageCount.Name = "colPageCount";
            this.colPageCount.ReadOnly = true;
            this.colPageCount.Width = 150;
            // 
            // frmGoogleBooksSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 570);
            this.Controls.Add(this.dgvFoundBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.txtSearchAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGoogleBooksSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Google Books Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAuthor;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFoundBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPubDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPageCount;
    }
}