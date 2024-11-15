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

namespace MyLibraryApp7.Forms.Genre
{
    public partial class frmAddGenre : Form
    {
        public frmAddGenre()
        {
            InitializeComponent();
        }

        private void frmAddGenre_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            txtGenreName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private int GetNextGenreID()
        {
            string qry = "SELECT COALESCE(MAX(GenreID), 0) + 1 as NextGenreID FROM Genre";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtGenreName.Text.Trim() != "")
            {
                try
                {
                    string qryAddNewGenre = "INSERT INTO Genre (GenreID, GenreName) VALUES (@GenreID, @GenreName);";
                    var paramAddNewGenre = new { GenreID = GetNextGenreID(), GenreName = txtGenreName.Text };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryAddNewGenre, paramAddNewGenre);
                    MessageBox.Show($"Genre {paramAddNewGenre.GenreName} Added Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Genre due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Genre Name.");
            }
        }
    }
}
