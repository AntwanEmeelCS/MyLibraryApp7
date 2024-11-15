using MyLibraryApp7.ClassLib;
using MyLibraryApp7.Forms.Author;
using MyLibraryApp7.Forms.Genre;
using MyLibraryApp7.Forms.Publisher;
using MyLibraryApp7.Forms.Shelves;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.MyBooks
{
    public partial class frmAddMyBook : Form
    {
        public frmAddMyBook()
        {
            InitializeComponent();
        }

        private void frmAddMyBook_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillAuthors(cboAuthorName);
            ds.FillGenres(cboGenres);
            ds.FillPublishers(cboPublisher);
            ds.FillShelves(cboShelves);
            txtBookTitle.Focus();

        }
        private void ClearForm(bool clearShelID)
        {
            if (cboAuthorName.Items.Count > 0) cboAuthorName.SelectedIndex = 0;
            if (cboGenres.Items.Count > 0) cboGenres.SelectedIndex = 0;
            if (cboPublisher.Items.Count > 0) cboPublisher.SelectedIndex = 0;
            if (cboShelves.Items.Count > 0 && clearShelID) cboShelves.SelectedIndex = 0;
            txtBookTitle.Text = "";
            txtISBN.Text = "";
            txtPublicationDate.Text = "";
            updPageCount.Value = updPageCount.Minimum;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm(true);
        }

        public ComboBoxItem ChosenAuthor { get; set; }
        public ComboBoxItem ChosenPublisher { get; set; }
        public ComboBoxItem ChosenGenre { get; set; }
        public ComboBoxItem ChosenShelf { get; set; }
        private void cboAuthorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenAuthor = cboAuthorName.GetSelectedItem();
        }

        private void cboPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenPublisher = cboPublisher.GetSelectedItem();
        }

        private void cboGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenGenre = cboGenres.GetSelectedItem();
        }

        private void cboShelves_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenShelf = cboShelves.GetSelectedItem();
        }

        private int GetNextBookID()
        {
            string qry = "SELECT COALESCE(MAX(BookID), 0) + 1 as NextBookID FROM MyBooks";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text.Trim() != "")
            {
                if (txtPublicationDate.Text.Trim() != "")
                {
                    try
                    {
                        string qryAddBook = @"
        INSERT INTO MyBooks (BookID, BookTitle, AuthorID, BookISBN, PublisherID, PublicationDate, GenreID, Pages, ShelfID, DateAdded)
        VALUES (@BookID, @BookTitle, @AuthorID, @BookISBN, @PublisherID, @PublicationDate, @GenreID, @Pages, @ShelfID, @DateAdded);";
                        var paramAddBook = new
                        {
                            BookID = GetNextBookID(),
                            BookTitle = txtBookTitle.Text,
                            AuthorID = this.ChosenAuthor.TableID,
                            BookISBN = txtISBN.Text.Length == 0 ? null : txtISBN.Text,
                            PublisherID = this.ChosenPublisher.TableID,
                            PublicationDate = txtPublicationDate.Text,
                            GenreID = this.ChosenGenre.TableID,
                            Pages = Convert.ToInt32(updPageCount.Value),
                            ShelfID = this.ChosenShelf.TableID,
                            DateAdded=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.FFF")
                        };
                        DapperBasis db = new DapperBasis();
                        int rowsAffected = db.ExecuteQuery(qryAddBook, paramAddBook);
                        DialogResult result = MessageBox.Show($"Book {txtBookTitle.Text} was added Successfully.\nDo you want to add another book?", "MyLibraryApp7", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            ClearForm(false);
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Adding Book {txtBookTitle.Text} FAILED due to {ex.ToString()}");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid Publication Date.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid Book Title.");
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            using (frmAddAuthor frm = new frmAddAuthor())
            {
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    DapperSpecifics ds = new DapperSpecifics();
                    ds.FillAuthors(cboAuthorName);
                }
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            frmAddPublisher frm = new frmAddPublisher();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DapperSpecifics ds = new DapperSpecifics();
                ds.FillPublishers(cboPublisher);
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            frmAddGenre frm = new frmAddGenre();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DapperSpecifics ds = new DapperSpecifics();
                ds.FillGenres(cboGenres);
            }
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            frmAddShelf frm = new frmAddShelf();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                DapperSpecifics ds = new DapperSpecifics();
                ds.FillShelves(cboShelves);
            }
        }
    }
}
