using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.ClassLib.Models;
using MyLibraryApp7.Forms.Author;
using MyLibraryApp7.Forms.Genre;
using MyLibraryApp7.Forms.Publisher;
using MyLibraryApp7.Forms.SearchForms;
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
    public partial class frmModifyBook : Form
    {
        public frmModifyBook()
        {
            InitializeComponent();
        }

        private void frmModifyBook_Load(object sender, EventArgs e)
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
            txtBookID.Text = "";
            txtBookID.Focus();
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
                        //calculate modifications
                        BookModel initial = GetBookInfo(int.Parse(txtBookID.Text));
                        BookModel changed = new BookModel
                        {
                            BookID = int.Parse(txtBookID.Text),
                            AuthorID = int.Parse(this.ChosenAuthor.TableID),
                            BookISBN = txtISBN.Text,
                            BookTitle = txtBookTitle.Text,
                            GenreID = int.Parse(this.ChosenGenre.TableID),
                            Pages = int.Parse(updPageCount.Value.ToString()),
                            PublicationDate = txtPublicationDate.Text,
                            PublisherID = int.Parse(this.ChosenPublisher.TableID),
                            ShelfID = int.Parse(this.ChosenShelf.TableID)
                        };
                        List<BookModificationRecord> mods = BookModel.CompareModifications(initial, changed);
                        //update book if necessary
                        if (mods.Count>0)
                        {
                            //main update
                            string qryAddBook = @"
UPDATE MyBooks
SET	BookTitle=@BookTitle,
	AuthorID=@AuthorID,
	BookISBN=@BookISBN,
	PublisherID=@PublisherID,
	PublicationDate=@PublicationDate,
	GenreID=@GenreID,
	Pages=@Pages,
	ShelfID=@ShelfID,
	DateLastModified=@DateLastModified
WHERE BookID=@BookID";
                            var paramAddBook = new
                            {
                                BookID = int.Parse(txtBookID.Text),
                                BookTitle = txtBookTitle.Text,
                                AuthorID = this.ChosenAuthor.TableID,
                                BookISBN = txtISBN.Text.Length == 0 ? null : txtISBN.Text,
                                PublisherID = this.ChosenPublisher.TableID,
                                PublicationDate = txtPublicationDate.Text,
                                GenreID = this.ChosenGenre.TableID,
                                Pages = Convert.ToInt32(updPageCount.Value),
                                ShelfID = this.ChosenShelf.TableID,
                                DateLastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.FFF")
                            };
                            DapperBasis db = new DapperBasis();
                            int rowsAffected = db.ExecuteQuery(qryAddBook, paramAddBook);
                            //record modifications itself
                            foreach (BookModificationRecord item in mods)
                            {
                                item.RecordModificationField();
                            }
                            //success
                            DialogResult result = MessageBox.Show($"Book {txtBookTitle.Text} was updated Successfully.", "MyLibraryApp7", MessageBoxButtons.OK);
                            this.DialogResult = DialogResult.OK;
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Book info are left intact, no modifications done!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Updating Book {txtBookTitle.Text} FAILED due to {ex.ToString()}");
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

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            frmLookupSearch frmSearchAuthor = new frmLookupSearch("Author", "AuthorID", "AuthorName");
            frmSearchAuthor.ShowDialog(this);
        }

        private void btnSearchPublisher_Click(object sender, EventArgs e)
        {
            frmLookupSearch frmSearchPublisher = new frmLookupSearch("Publisher", "PublisherID", "PublisherName");
            frmSearchPublisher.ShowDialog(this);
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            frmLookupSearch frmSearchGenre = new frmLookupSearch("Genre", "GenreID", "GenreName");
            frmSearchGenre.ShowDialog(this);
        }

        private void btnSearchShelf_Click(object sender, EventArgs e)
        {
            frmLookupSearch frmSearchShelf = new frmLookupSearch("Shelves", "ShelfID", "ShelfName");
            frmSearchShelf.ShowDialog(this);
        }

        private void btnSearchBookID_Click(object sender, EventArgs e)
        {
            frmLookupSearch frmSearchAuthor = new frmLookupSearch("V_MyBooks", "BookID", "CONCAT(BookTitle, ' - ', AuthorName)");
            frmSearchAuthor.ShowDialog(this);
        }
        public void SelectComboBoxItemById(ComboBox comboBox, string tableId)
        {
            foreach (ComboBoxItem item in comboBox.Items)
            {
                if (item.TableID == tableId)
                {
                    comboBox.SelectedItem = item;
                    goto ItemFound;
                }
            }
        ItemFound:;
        }
        private BookModel GetBookInfo(int BookID)
        {
            //query book info
            string qryBookInfo = @"SELECT BookID, BookTitle, AuthorID, BookISBN, PublisherID, PublicationDate, GenreID, Pages, ShelfID
FROM V_MyBooks
WHERE BookID=@BookID";
            var paramBookInfo = new { BookID = BookID };
            DapperBasis db = new DapperBasis();
            List<BookModel> BookList = db.GetResultList<BookModel>(qryBookInfo, paramBookInfo).ToList();
            return BookList.Count == 0 ? null : BookList[0];
        }
        private void FillBookInfo(int BookID)
        {
            BookModel foundBook = GetBookInfo(BookID);
            if (foundBook != null)
            {
                txtBookTitle.Text = foundBook.BookTitle;
                SelectComboBoxItemById(cboAuthorName, foundBook.AuthorID.ToString());
                txtISBN.Text = foundBook.BookISBN;
                SelectComboBoxItemById(cboPublisher, foundBook.PublisherID.ToString());
                txtPublicationDate.Text = foundBook.PublicationDate;
                SelectComboBoxItemById(cboGenres, foundBook.GenreID.ToString());
                updPageCount.Value = foundBook.Pages;
                SelectComboBoxItemById(cboShelves, foundBook.ShelfID.ToString());
            }
        }

   

        private void txtBookID_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text.Trim(), out int BookID) == true)
            {
                FillBookInfo(BookID);
            }
            else
            {
                MessageBox.Show("Invalid Book ID Entry");
                txtBookID.Focus();
            }
        }

        
    }
}
