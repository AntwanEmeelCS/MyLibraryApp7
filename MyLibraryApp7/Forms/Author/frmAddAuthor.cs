using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.Forms.AuthorNationality;
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
    public partial class frmAddAuthor : Form
    {
        public frmAddAuthor()
        {
            InitializeComponent();
        }
        public string ChosenNationalityID { get; set; }
        
        private void frmAddAuthor_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillNationalities(cboNationality);
        }

        private void cboNationalities_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenNationalityID = cboNationality.GetSelectedItemID();
        }
        private int GetNextAuthorID()
        {
            string qry = "SELECT COALESCE(MAX(AuthorID), 0) + 1 as NextAuthorID FROM Author";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
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
                    string qryAddNewAuthor = "INSERT INTO Author (AuthorID, AuthorName, AuthorNationalityID) VALUES (@AuthorID, @AuthorName, @AuthorNationalityID);";
                    var paramAddNewAuthor = new { AuthorID = GetNextAuthorID(), AuthorName = txtAuthorName.Text, AuthorNationalityID = this.ChosenNationalityID };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryAddNewAuthor, paramAddNewAuthor);
                    MessageBox.Show($"Author {paramAddNewAuthor.AuthorName} Added Successfully.");
                    //this.DialogResult = DialogResult.None;
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Author due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Author Name.");
            }
        }

        private void btnAddNationality_Click(object sender, EventArgs e)
        {
            using (frmAddNationality frm = new frmAddNationality())
            {
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    DapperSpecifics ds = new DapperSpecifics();
                    ds.FillNationalities(cboNationality);
                }
            }
        }
    }
}
