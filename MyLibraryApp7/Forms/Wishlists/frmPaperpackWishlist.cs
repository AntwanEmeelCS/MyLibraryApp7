using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.Forms.Author;
using MyLibraryApp7.Forms.Genre;
using MyLibraryApp7.Forms.Publisher;
using MyLibraryApp7.Forms.SearchForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.Wishlists
{
    public partial class frmPaperpackWishlist : Form
    {
        public frmPaperpackWishlist()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenAuthor { get; set; }
        public ComboBoxItem ChosenPublisher { get; set; }
        public ComboBoxItem ChosenGenre { get; set; }
        private void frmPaperpackWishlist_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            updYearIndex.Value = DateTime.Now.Year;
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillAuthors(cboAuthors);
            ds.FillGenres(cboGenre);
            ds.FillPublishers(cboPublisher);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text.Trim()!="")
            {
                try
                {
                    string qry = @"INSERT INTO PaperbackWishlist
(BookTitle, AuthorID, PublisherID, GenreID, PriceBefore, PriceAfter, YearIndex, Notes)
VALUES
(@BookTitle, @AuthorID, @PublisherID, @GenreID, @PriceBefore, @PriceAfter, @YearIndex, @Notes);";
                    var parameters = new
                    {
                        BookTitle = txtBookTitle.Text,
                        AuthorID = this.ChosenAuthor.TableID,
                        PublisherID = this.ChosenPublisher.TableID,
                        GenreID = this.ChosenGenre.TableID,
                        PriceBefore = updPriceBefore.Value == 0 ? null : updPriceBefore.Value.ToString(),
                        PriceAfter = updPriceAfter.Value == 0 ? null : updPriceAfter.Value.ToString(),
                        YearIndex = updYearIndex.Value,
                        Notes = txtNotes.Text.Trim() == "" ? null : txtNotes.Text.Trim()
                    };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qry, parameters);
                    DialogResult dr = MessageBox.Show($"Book {txtBookTitle.Text} added successfully.\n Do you want to add other books?", "MyLibraryApp7", MessageBoxButtons.YesNo);
                    if (dr==DialogResult.Yes)
                    {
                        ClearForm();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding book due to:\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid booktitle");
            }
        }

        private void ClearForm()
        {
            txtBookTitle.Text = "";
            if (cboAuthors.Items.Count>0)
            {
                cboAuthors.SelectedIndex = 0;
            }
            if (cboPublisher.Items.Count > 0)
            {
                cboPublisher.SelectedIndex = 0;
            }
            if (cboGenre.Items.Count > 0)
            {
                cboGenre.SelectedIndex = 0;
            }
            updPriceBefore.Value = 0;
            updPriceAfter.Value = 0;
            txtNotes.Text = "";
        }

        private void cboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenAuthor = (ComboBoxItem)cboAuthors.SelectedItem;
        }

        private void cboPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenPublisher = (ComboBoxItem)cboPublisher.SelectedItem;

        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenGenre = (ComboBoxItem)cboGenre.SelectedItem;

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

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            using (frmAddAuthor frm = new frmAddAuthor())
            {
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    DapperSpecifics ds = new DapperSpecifics();
                    ds.FillAuthors(cboAuthors);
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
                ds.FillGenres(cboGenre);
            }
        }
    }
}
