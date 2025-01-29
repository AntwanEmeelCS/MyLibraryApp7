
namespace MyLibraryApp7.Forms.Wishlists
{
    partial class frmPaperpackWishlist
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.cboAuthors = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.updYearIndex = new System.Windows.Forms.NumericUpDown();
            this.updPriceAfter = new System.Windows.Forms.NumericUpDown();
            this.updPriceBefore = new System.Windows.Forms.NumericUpDown();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnSearchPublisher = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updYearIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceBefore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price Before";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year Index";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price After";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 505);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(175, 57);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(552, 505);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 57);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(189, 200);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(439, 39);
            this.cboGenre.TabIndex = 10;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenre_SelectedIndexChanged);
            // 
            // cboPublisher
            // 
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(189, 143);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(439, 39);
            this.cboPublisher.TabIndex = 11;
            this.cboPublisher.SelectedIndexChanged += new System.EventHandler(this.cboPublisher_SelectedIndexChanged);
            // 
            // cboAuthors
            // 
            this.cboAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthors.FormattingEnabled = true;
            this.cboAuthors.Location = new System.Drawing.Point(188, 84);
            this.cboAuthors.Name = "cboAuthors";
            this.cboAuthors.Size = new System.Drawing.Size(439, 39);
            this.cboAuthors.TabIndex = 12;
            this.cboAuthors.SelectedIndexChanged += new System.EventHandler(this.cboAuthors_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(189, 405);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(779, 39);
            this.txtNotes.TabIndex = 16;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(189, 30);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(438, 39);
            this.txtBookTitle.TabIndex = 17;
            // 
            // updYearIndex
            // 
            this.updYearIndex.Location = new System.Drawing.Point(189, 353);
            this.updYearIndex.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.updYearIndex.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.updYearIndex.Name = "updYearIndex";
            this.updYearIndex.Size = new System.Drawing.Size(120, 39);
            this.updYearIndex.TabIndex = 18;
            this.updYearIndex.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // updPriceAfter
            // 
            this.updPriceAfter.Location = new System.Drawing.Point(188, 304);
            this.updPriceAfter.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.updPriceAfter.Name = "updPriceAfter";
            this.updPriceAfter.Size = new System.Drawing.Size(120, 39);
            this.updPriceAfter.TabIndex = 19;
            // 
            // updPriceBefore
            // 
            this.updPriceBefore.Location = new System.Drawing.Point(188, 253);
            this.updPriceBefore.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.updPriceBefore.Name = "updPriceBefore";
            this.updPriceBefore.Size = new System.Drawing.Size(120, 39);
            this.updPriceBefore.TabIndex = 20;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchAuthor.Location = new System.Drawing.Point(810, 77);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(158, 50);
            this.btnSearchAuthor.TabIndex = 37;
            this.btnSearchAuthor.Text = "Search...";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddAuthor.Location = new System.Drawing.Point(638, 77);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(158, 50);
            this.btnAddAuthor.TabIndex = 36;
            this.btnAddAuthor.Text = "Add...";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnSearchPublisher
            // 
            this.btnSearchPublisher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchPublisher.Location = new System.Drawing.Point(810, 136);
            this.btnSearchPublisher.Name = "btnSearchPublisher";
            this.btnSearchPublisher.Size = new System.Drawing.Size(158, 50);
            this.btnSearchPublisher.TabIndex = 39;
            this.btnSearchPublisher.Text = "Search...";
            this.btnSearchPublisher.UseVisualStyleBackColor = true;
            this.btnSearchPublisher.Click += new System.EventHandler(this.btnSearchPublisher_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddPublisher.Location = new System.Drawing.Point(638, 136);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(158, 50);
            this.btnAddPublisher.TabIndex = 38;
            this.btnAddPublisher.Text = "Add...";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchGenre.Location = new System.Drawing.Point(810, 193);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(158, 50);
            this.btnSearchGenre.TabIndex = 41;
            this.btnSearchGenre.Text = "Search...";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddGenre.Location = new System.Drawing.Point(638, 193);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(158, 50);
            this.btnAddGenre.TabIndex = 40;
            this.btnAddGenre.Text = "Add...";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // frmPaperpackWishlist
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(981, 589);
            this.Controls.Add(this.btnSearchGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnSearchPublisher);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.updPriceBefore);
            this.Controls.Add(this.updPriceAfter);
            this.Controls.Add(this.updYearIndex);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cboAuthors);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaperpackWishlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add A Paper book to wishlist";
            this.Load += new System.EventHandler(this.frmPaperpackWishlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updYearIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceBefore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.ComboBox cboAuthors;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.NumericUpDown updYearIndex;
        private System.Windows.Forms.NumericUpDown updPriceAfter;
        private System.Windows.Forms.NumericUpDown updPriceBefore;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnSearchPublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.Button btnAddGenre;
    }
}