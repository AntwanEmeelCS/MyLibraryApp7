using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.Author
{
    public partial class frmModifyAuthor : Form
    {
        public frmModifyAuthor()
        {
            InitializeComponent();
        }
        public string ChosenNationalityID { get; set; }
        public string ChosenAuthorID { get; set; }
       
        private void frmModifyAuthor_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillNationalities(cboNationalities);
            ds.FillAuthors(cboAuthors);
        }

        private void cboNationalities_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenNationalityID = cboNationalities.GetSelectedItemID();
        }

        private void cboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenAuthorID = cboAuthors.GetSelectedItemID();
            txtAuthorName.Text = GetAuthorName(this.ChosenAuthorID);
            SelectComboBoxItemById(cboNationalities, GetAuthorNationality(this.ChosenAuthorID));
        }

        private string GetAuthorNationality(string chosenAuthorID)
        {
            string qry = "SELECT AuthorNationalityID FROM Author WHERE AuthorID=@AuthorID";
            var parameters = new { AuthorID = chosenAuthorID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<string>(qry, parameters);
        }
        private string GetAuthorName(string chosenAuthorID)
        {
            string qry = "SELECT AuthorName FROM Author WHERE AuthorID=@AuthorID";
            var parameters = new { AuthorID = chosenAuthorID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<string>(qry, parameters);
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

            NotFoundItem(tableId);
        ItemFound:;
        }

        public void NotFoundItem(string tableId)
        {
            throw new Exception($"Nationality {tableId} NOT Found!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.Text.Trim() != "")
            {
                try
                {
                    string qryUpdateAuthor = @"UPDATE Author
                                                SET AuthorName=@AuthorName,
	                                                AuthorNationalityID=@AuthorNationalityID
                                                WHERE AuthorID=@AuthorID;";
                    var paramUpdateAuthor = new { AuthorID = this.ChosenAuthorID, AuthorName = txtAuthorName.Text, AuthorNationalityID = this.ChosenNationalityID };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryUpdateAuthor, paramUpdateAuthor);
                    MessageBox.Show($"Author {paramUpdateAuthor.AuthorName} Updated Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Updating Author due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Author Name.");
            }
        }
    }
}
