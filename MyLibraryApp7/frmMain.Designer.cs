﻿
namespace MyLibraryApp7
{
    partial class frmMain
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
            this.mnuStripMain = new System.Windows.Forms.MenuStrip();
            this.assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shelvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyShelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteShelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorNationalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNationalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNationalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripMain
            // 
            this.mnuStripMain.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetsToolStripMenuItem,
            this.myBooksToolStripMenuItem});
            this.mnuStripMain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMain.Name = "mnuStripMain";
            this.mnuStripMain.Size = new System.Drawing.Size(782, 40);
            this.mnuStripMain.TabIndex = 0;
            this.mnuStripMain.Text = "menuStrip1";
            // 
            // assetsToolStripMenuItem
            // 
            this.assetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shelvesToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.publisherLocationsToolStripMenuItem,
            this.publishersToolStripMenuItem,
            this.authorNationalityToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            this.assetsToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.assetsToolStripMenuItem.Text = "Assets";
            // 
            // shelvesToolStripMenuItem
            // 
            this.shelvesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShelfToolStripMenuItem,
            this.modifyShelfToolStripMenuItem,
            this.deleteShelfToolStripMenuItem});
            this.shelvesToolStripMenuItem.Name = "shelvesToolStripMenuItem";
            this.shelvesToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.shelvesToolStripMenuItem.Text = "Shelves";
            // 
            // addShelfToolStripMenuItem
            // 
            this.addShelfToolStripMenuItem.Name = "addShelfToolStripMenuItem";
            this.addShelfToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.addShelfToolStripMenuItem.Text = "Add Shelf";
            this.addShelfToolStripMenuItem.Click += new System.EventHandler(this.addShelfToolStripMenuItem_Click);
            // 
            // modifyShelfToolStripMenuItem
            // 
            this.modifyShelfToolStripMenuItem.Name = "modifyShelfToolStripMenuItem";
            this.modifyShelfToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.modifyShelfToolStripMenuItem.Text = "Modify Shelf";
            this.modifyShelfToolStripMenuItem.Click += new System.EventHandler(this.modifyShelfToolStripMenuItem_Click);
            // 
            // deleteShelfToolStripMenuItem
            // 
            this.deleteShelfToolStripMenuItem.Name = "deleteShelfToolStripMenuItem";
            this.deleteShelfToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.deleteShelfToolStripMenuItem.Text = "Delete Shelf";
            this.deleteShelfToolStripMenuItem.Click += new System.EventHandler(this.deleteShelfToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGenreToolStripMenuItem,
            this.deleteGenreToolStripMenuItem});
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // addGenreToolStripMenuItem
            // 
            this.addGenreToolStripMenuItem.Name = "addGenreToolStripMenuItem";
            this.addGenreToolStripMenuItem.Size = new System.Drawing.Size(257, 36);
            this.addGenreToolStripMenuItem.Text = "Add Genre";
            this.addGenreToolStripMenuItem.Click += new System.EventHandler(this.addGenreToolStripMenuItem_Click);
            // 
            // deleteGenreToolStripMenuItem
            // 
            this.deleteGenreToolStripMenuItem.Name = "deleteGenreToolStripMenuItem";
            this.deleteGenreToolStripMenuItem.Size = new System.Drawing.Size(257, 36);
            this.deleteGenreToolStripMenuItem.Text = "Delete Genre";
            this.deleteGenreToolStripMenuItem.Click += new System.EventHandler(this.deleteGenreToolStripMenuItem_Click);
            // 
            // publisherLocationsToolStripMenuItem
            // 
            this.publisherLocationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem,
            this.deleteLocationToolStripMenuItem});
            this.publisherLocationsToolStripMenuItem.Name = "publisherLocationsToolStripMenuItem";
            this.publisherLocationsToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.publisherLocationsToolStripMenuItem.Text = "Publisher Locations";
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // deleteLocationToolStripMenuItem
            // 
            this.deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            this.deleteLocationToolStripMenuItem.Size = new System.Drawing.Size(290, 36);
            this.deleteLocationToolStripMenuItem.Text = "Delete Location";
            this.deleteLocationToolStripMenuItem.Click += new System.EventHandler(this.deleteLocationToolStripMenuItem_Click);
            // 
            // publishersToolStripMenuItem
            // 
            this.publishersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPublisherToolStripMenuItem,
            this.modifyPublisherToolStripMenuItem,
            this.deletePublisherToolStripMenuItem});
            this.publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            this.publishersToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.publishersToolStripMenuItem.Text = "Publishers";
            // 
            // addPublisherToolStripMenuItem
            // 
            this.addPublisherToolStripMenuItem.Name = "addPublisherToolStripMenuItem";
            this.addPublisherToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.addPublisherToolStripMenuItem.Text = "Add Publisher";
            this.addPublisherToolStripMenuItem.Click += new System.EventHandler(this.addPublisherToolStripMenuItem_Click);
            // 
            // modifyPublisherToolStripMenuItem
            // 
            this.modifyPublisherToolStripMenuItem.Name = "modifyPublisherToolStripMenuItem";
            this.modifyPublisherToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.modifyPublisherToolStripMenuItem.Text = "Modify Publisher";
            this.modifyPublisherToolStripMenuItem.Click += new System.EventHandler(this.modifyPublisherToolStripMenuItem_Click);
            // 
            // deletePublisherToolStripMenuItem
            // 
            this.deletePublisherToolStripMenuItem.Name = "deletePublisherToolStripMenuItem";
            this.deletePublisherToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.deletePublisherToolStripMenuItem.Text = "Delete Publisher";
            this.deletePublisherToolStripMenuItem.Click += new System.EventHandler(this.deletePublisherToolStripMenuItem_Click);
            // 
            // authorNationalityToolStripMenuItem
            // 
            this.authorNationalityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNationalityToolStripMenuItem,
            this.deleteNationalityToolStripMenuItem});
            this.authorNationalityToolStripMenuItem.Name = "authorNationalityToolStripMenuItem";
            this.authorNationalityToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.authorNationalityToolStripMenuItem.Text = "Author Nationality";
            // 
            // addNationalityToolStripMenuItem
            // 
            this.addNationalityToolStripMenuItem.Name = "addNationalityToolStripMenuItem";
            this.addNationalityToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.addNationalityToolStripMenuItem.Text = "Add Nationality";
            this.addNationalityToolStripMenuItem.Click += new System.EventHandler(this.addNationalityToolStripMenuItem_Click);
            // 
            // deleteNationalityToolStripMenuItem
            // 
            this.deleteNationalityToolStripMenuItem.Name = "deleteNationalityToolStripMenuItem";
            this.deleteNationalityToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.deleteNationalityToolStripMenuItem.Text = "Delete Nationality";
            this.deleteNationalityToolStripMenuItem.Click += new System.EventHandler(this.deleteNationalityToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthorToolStripMenuItem,
            this.modifyAuthorToolStripMenuItem,
            this.deleteAuthorToolStripMenuItem});
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // addAuthorToolStripMenuItem
            // 
            this.addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            this.addAuthorToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.addAuthorToolStripMenuItem.Text = "Add Author";
            this.addAuthorToolStripMenuItem.Click += new System.EventHandler(this.addAuthorToolStripMenuItem_Click);
            // 
            // modifyAuthorToolStripMenuItem
            // 
            this.modifyAuthorToolStripMenuItem.Name = "modifyAuthorToolStripMenuItem";
            this.modifyAuthorToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.modifyAuthorToolStripMenuItem.Text = "Modify Author";
            this.modifyAuthorToolStripMenuItem.Click += new System.EventHandler(this.modifyAuthorToolStripMenuItem_Click);
            // 
            // deleteAuthorToolStripMenuItem
            // 
            this.deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            this.deleteAuthorToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.deleteAuthorToolStripMenuItem.Text = "Delete Author";
            this.deleteAuthorToolStripMenuItem.Click += new System.EventHandler(this.deleteAuthorToolStripMenuItem_Click);
            // 
            // myBooksToolStripMenuItem
            // 
            this.myBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem});
            this.myBooksToolStripMenuItem.Name = "myBooksToolStripMenuItem";
            this.myBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.myBooksToolStripMenuItem.Size = new System.Drawing.Size(150, 36);
            this.myBooksToolStripMenuItem.Text = "My Books";
            // 
            // picBackground
            // 
            this.picBackground.Location = new System.Drawing.Point(12, 43);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(289, 239);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 1;
            this.picBackground.TabStop = false;
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(384, 36);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.mnuStripMain);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Library App 7";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStripMain.ResumeLayout(false);
            this.mnuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripMain;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shelvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShelfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyShelfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteShelfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publisherLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorNationalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNationalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNationalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
    }
}

