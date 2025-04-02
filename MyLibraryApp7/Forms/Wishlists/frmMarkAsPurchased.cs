using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.ClassLib.Models;
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
    
    public partial class frmMarkAsPurchased : Form
    {
        public frmMarkAsPurchased()
        {
            InitializeComponent();
        }

        public string ChosenBookTitle { get; set; }
        public string ChosenAuthorID { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmMarkAsPurchased_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            LoadBookTitles();
        }

        private void LoadBookTitles()
        {
            DapperBasis db = new DapperBasis();
            string qry = @"SELECT BookTitle as TableID, BookTitle as TableString FROM PaperbackWishlist WHERE Purchased=0 ORDER BY TableID";
            db.FillComboBox(cboTitle, qry);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string qry = @"UPDATE PaperbackWishlist
SET Purchased=1
WHERE BookTitle=@BookTitle AND AuthorID=@AuthorID;";
            var parameters = new { BookTitle = this.ChosenBookTitle, AuthorID=this.ChosenAuthorID };
            DapperBasis db = new DapperBasis();
            try
            {
                db.ExecuteQuery(qry, parameters);
                MessageBox.Show("Updating Book " + this.ChosenBookTitle + " Completed Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenBookTitle = ((ComboBoxItem)cboTitle.SelectedItem).TableID;
            FillAvailableAuthors(this.ChosenBookTitle);
        }

        private void FillAvailableAuthors(string chosenBookTitle)
        {
            DapperBasis db = new DapperBasis();
            string qry = @"SELECT p.AuthorID as TableID, a.AuthorName as TableString
FROM PaperbackWishlist as p
INNER JOIN Author a ON p.AuthorID=a.AuthorID
WHERE p.Purchased=0 AND p.BookTitle=@BookTitle;";
            var parameters = new { BookTitle = chosenBookTitle };
            db.FillComboBox(cboAuthor, qry, parameters);
        }

        private void cboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenAuthorID = ((ComboBoxItem)cboAuthor.SelectedItem).TableID;
        }
    }
}
