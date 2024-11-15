using MyLibraryApp7.ClassLib;
using MyLibraryApp7.Forms.Author;
using MyLibraryApp7.Forms.AuthorNationality;
using MyLibraryApp7.Forms.Genre;
using MyLibraryApp7.Forms.MyBooks;
using MyLibraryApp7.Forms.Publisher;
using MyLibraryApp7.Forms.PublisherLocation;
using MyLibraryApp7.Forms.Shelves;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            this.Icon = new Icon(appPath + "\\assets\\MyLibraryApp7.ico");
            //resize form and draw background
            picBackground.Image = Image.FromFile(appPath + "\\assets\\MyLibraryApp7.jpg");
            const int length = 700;
            this.Height = mnuStripMain.Height + length;
            this.Width = length;
            picBackground.Top = mnuStripMain.Height;
            picBackground.Left = 0;
            picBackground.Size = new Size(length, length);
            mnuStripMain.BackColor = Color.FromArgb(255, 175, 160, 120);
            string db_path = DapperBasis.db_path;
            if (!File.Exists(db_path))
            {
                InitializeDB();
            }
            else
            {
                //MessageBox.Show("Database File Exists.");
            }
        }
        private bool InitializeDatabaseFile()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DapperBasis.connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializeShelfLookup(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE Shelves
                            (
	                            ShelfID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                            ShelfName nvarchar(50) NOT NULL,
	                            Notes nvarchar(500)
                            )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializeGenreLookup(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE Genre
                                (
	                                GenreID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                GenreName nvarchar(50) NOT NULL
                                )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializePublisherLocationLookup(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE PublisherLocation
                                (
	                                LocationID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                LocationName nvarchar(50) NOT NULL
                                )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializePublisherLookup(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE Publisher
                                (
	                                PublisherID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                PublisherName nvarchar(50) NOT NULL,
	                                PublisherLocationID int NOT NULL REFERENCES PublisherLocation('LocationID')
                                )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializeNationalityLookup(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE Nationality
                                (
	                                NationalityID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                NationalityName nvarchar(50) NOT NULL
                                )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializeAuthorLookup(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE Author
                                (
	                                AuthorID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                AuthorName nvarchar(50) NOT NULL,
	                                AuthorNationalityID int NOT NULL REFERENCES Nationality('NationalityID')
                                )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool InitializeMyBooksTable(ref DapperBasis db)
        {
            try
            {
                string qry = @"CREATE TABLE MyBooks
                                (
	                                BookID int IDENTITY(1,1) PRIMARY KEY,
	                                BookTitle nvarchar(250) NOT NULL,
	                                AuthorID int NOT NULL REFERENCES Author('AuthorID'),
	                                BookISBN nvarchar(50),
	                                PublisherID int NOT NULL REFERENCES Publisher('PublisherID'),
	                                PublicationDate nvarchar(200) NOT NULL,
	                                GenreID int NOT NULL REFERENCES Genre('GenreID'),
	                                Pages int NOT NULL,
	                                ShelfID int NOT NULL REFERENCES Shelves('ShelfID')
                                )";
                db.ExecuteQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void InitializeDB()
        {
            DapperBasis db = new DapperBasis();
            if (InitializeDatabaseFile())
            {
                if (InitializeShelfLookup(ref db))
                {
                    if (InitializeGenreLookup(ref db))
                    {
                        if (InitializePublisherLocationLookup(ref db))
                        {
                            if (InitializePublisherLookup(ref db))
                            {
                                if (InitializeNationalityLookup(ref db))
                                {
                                    if (InitializeAuthorLookup(ref db))
                                    {
                                        if (InitializeMyBooksTable(ref db))
                                        {
                                            MessageBox.Show("Database Initialization Completed Successfully.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error Creating MyBooks Table.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Creating Author Lookup.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error Creating Nationality Lookup.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error Creating Publisher Lookup.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error Creating Publisher Location Lookup.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Creating Genre Lookup.");
                    }
                }
                else
                {
                    MessageBox.Show("Error Creating Shelf Lookup.");
                }
            }
            else
            {
                MessageBox.Show("Error Creating Database File.");
            };
        }

        private void addShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddShelf().ShowDialog();
        }

        private void modifyShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmModifyShelf().ShowDialog();
        }

        private void deleteShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDeleteShelf().ShowDialog();
        }

        private void addGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddGenre().ShowDialog();
        }

        private void deleteGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDeleteGenre().ShowDialog();
        }

        private void addNationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNationality().ShowDialog();
        }

        private void deleteNationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDeleteNationality().ShowDialog();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddLocation().ShowDialog();
        }

        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDeleteLocation().ShowDialog();
        }

        private void addPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddPublisher().ShowDialog();
        }

        private void modifyPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmModifyPublisher().ShowDialog();
        }

        private void deletePublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDeletePublisher().ShowDialog();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddAuthor().ShowDialog();
        }

        private void modifyAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmModifyAuthor().ShowDialog();
        }

        private void deleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDeleteAuthor().ShowDialog();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddMyBook().Show();
        }
    }
}
