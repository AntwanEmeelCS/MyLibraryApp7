
namespace MyLibraryApp7.Forms.MyBooks
{
    partial class frmAddMyBook
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.cboAuthorName = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.txtPublicationDate = new System.Windows.Forms.TextBox();
            this.cboGenres = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updPageCount = new System.Windows.Forms.NumericUpDown();
            this.cboShelves = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.btnSearchShelf = new System.Windows.Forms.Button();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.btnSearchPublisher = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updPageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(475, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 50);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(266, 430);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 50);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Publication Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pages";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(248, 22);
            this.txtBookTitle.MaxLength = 125;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(472, 39);
            this.txtBookTitle.TabIndex = 20;
            // 
            // cboAuthorName
            // 
            this.cboAuthorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthorName.FormattingEnabled = true;
            this.cboAuthorName.Location = new System.Drawing.Point(248, 70);
            this.cboAuthorName.Name = "cboAuthorName";
            this.cboAuthorName.Size = new System.Drawing.Size(472, 39);
            this.cboAuthorName.TabIndex = 21;
            this.cboAuthorName.SelectedIndexChanged += new System.EventHandler(this.cboAuthorName_SelectedIndexChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(248, 119);
            this.txtISBN.MaxLength = 25;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(472, 39);
            this.txtISBN.TabIndex = 22;
            // 
            // cboPublisher
            // 
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(248, 167);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(472, 39);
            this.cboPublisher.TabIndex = 23;
            this.cboPublisher.SelectedIndexChanged += new System.EventHandler(this.cboPublisher_SelectedIndexChanged);
            // 
            // txtPublicationDate
            // 
            this.txtPublicationDate.Location = new System.Drawing.Point(248, 216);
            this.txtPublicationDate.MaxLength = 100;
            this.txtPublicationDate.Name = "txtPublicationDate";
            this.txtPublicationDate.Size = new System.Drawing.Size(472, 39);
            this.txtPublicationDate.TabIndex = 24;
            // 
            // cboGenres
            // 
            this.cboGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(248, 264);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.Size = new System.Drawing.Size(472, 39);
            this.cboGenres.TabIndex = 26;
            this.cboGenres.SelectedIndexChanged += new System.EventHandler(this.cboGenres_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "Genre";
            // 
            // updPageCount
            // 
            this.updPageCount.Location = new System.Drawing.Point(248, 312);
            this.updPageCount.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.updPageCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updPageCount.Name = "updPageCount";
            this.updPageCount.Size = new System.Drawing.Size(120, 39);
            this.updPageCount.TabIndex = 27;
            this.updPageCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cboShelves
            // 
            this.cboShelves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShelves.FormattingEnabled = true;
            this.cboShelves.Location = new System.Drawing.Point(248, 359);
            this.cboShelves.Name = "cboShelves";
            this.cboShelves.Size = new System.Drawing.Size(472, 39);
            this.cboShelves.TabIndex = 29;
            this.cboShelves.SelectedIndexChanged += new System.EventHandler(this.cboShelves_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Shelf";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(39, 430);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(161, 50);
            this.btnClearForm.TabIndex = 30;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddAuthor.Location = new System.Drawing.Point(736, 63);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(158, 50);
            this.btnAddAuthor.TabIndex = 31;
            this.btnAddAuthor.Text = "Add...";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddPublisher.Location = new System.Drawing.Point(736, 160);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(158, 50);
            this.btnAddPublisher.TabIndex = 32;
            this.btnAddPublisher.Text = "Add...";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddGenre.Location = new System.Drawing.Point(736, 257);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(158, 50);
            this.btnAddGenre.TabIndex = 33;
            this.btnAddGenre.Text = "Add...";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddShelf.Location = new System.Drawing.Point(736, 352);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(158, 50);
            this.btnAddShelf.TabIndex = 34;
            this.btnAddShelf.Text = "Add...";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // btnSearchShelf
            // 
            this.btnSearchShelf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchShelf.Location = new System.Drawing.Point(914, 352);
            this.btnSearchShelf.Name = "btnSearchShelf";
            this.btnSearchShelf.Size = new System.Drawing.Size(158, 50);
            this.btnSearchShelf.TabIndex = 38;
            this.btnSearchShelf.Text = "Search...";
            this.btnSearchShelf.UseVisualStyleBackColor = true;
            this.btnSearchShelf.Click += new System.EventHandler(this.btnSearchShelf_Click);
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchGenre.Location = new System.Drawing.Point(914, 257);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(158, 50);
            this.btnSearchGenre.TabIndex = 37;
            this.btnSearchGenre.Text = "Search...";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // btnSearchPublisher
            // 
            this.btnSearchPublisher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchPublisher.Location = new System.Drawing.Point(914, 160);
            this.btnSearchPublisher.Name = "btnSearchPublisher";
            this.btnSearchPublisher.Size = new System.Drawing.Size(158, 50);
            this.btnSearchPublisher.TabIndex = 36;
            this.btnSearchPublisher.Text = "Search...";
            this.btnSearchPublisher.UseVisualStyleBackColor = true;
            this.btnSearchPublisher.Click += new System.EventHandler(this.btnSearchPublisher_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchAuthor.Location = new System.Drawing.Point(914, 63);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(158, 50);
            this.btnSearchAuthor.TabIndex = 35;
            this.btnSearchAuthor.Text = "Search...";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // frmAddMyBook
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1099, 520);
            this.Controls.Add(this.btnSearchShelf);
            this.Controls.Add(this.btnSearchGenre);
            this.Controls.Add(this.btnSearchPublisher);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.btnAddShelf);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.cboShelves);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updPageCount);
            this.Controls.Add(this.cboGenres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPublicationDate);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.cboAuthorName);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Name = "frmAddMyBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Book Record";
            this.Load += new System.EventHandler(this.frmAddMyBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updPageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.ComboBox cboAuthorName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.TextBox txtPublicationDate;
        private System.Windows.Forms.ComboBox cboGenres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown updPageCount;
        private System.Windows.Forms.ComboBox cboShelves;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Button btnSearchShelf;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.Button btnSearchPublisher;
        private System.Windows.Forms.Button btnSearchAuthor;
    }
}