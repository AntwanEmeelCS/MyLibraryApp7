using MyLibraryApp7.ClassLib;
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
    public partial class frmDeleteAuthor : Form
    {
        public frmDeleteAuthor()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenAuthor { get; set; }
        
        private void frmDeleteAuthor_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillAuthors(cboAuthors);
        }

        private void cboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenAuthor = cboAuthors.GetSelectedItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetAuthorBookCount(this.ChosenAuthor.TableID) == 0)
                {
                    string qryDeleteAuthor = "DELETE FROM Author WHERE AuthorID=@AuthorID;";
                    var paramDeleteAuthor = new { AuthorID = this.ChosenAuthor.TableID };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qryDeleteAuthor, paramDeleteAuthor);
                    MessageBox.Show($"Author {this.ChosenAuthor.TableString} Deleted Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"Cannot delete an author that has books!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deleting Author {this.ChosenAuthor.TableString} Wasn't Successful due to {ex.ToString()}");
            }
        }

        private int GetAuthorBookCount(string chosenAuthorID)
        {
            string qry = "SELECT COUNT(0) FROM MyBooks WHERE AuthorID=@AuthorID;";
            var parameters = new { AuthorID = chosenAuthorID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry, parameters);
        }
    }
}
