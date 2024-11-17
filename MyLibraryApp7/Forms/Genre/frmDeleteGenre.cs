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

namespace MyLibraryApp7.Forms.Genre
{
    public partial class frmDeleteGenre : Form
    {
        public frmDeleteGenre()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenGenre { get; set; }
        
        private void frmDeleteGenre_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillGenres(cboGenres);
        }

        private void cboGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenGenre = cboGenres.GetSelectedItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetGenreBookCount(this.ChosenGenre.TableID)==0)
                {
                    string qryDeleteGenre = "DELETE FROM Genre WHERE GenreID=@GenreID;";
                    var paramDeleteGenre = new { GenreID = this.ChosenGenre.TableID };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qryDeleteGenre, paramDeleteGenre);
                    MessageBox.Show($"Genre {this.ChosenGenre.TableString} Deleted Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cannot Delete a Genre that has books!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Genre {this.ChosenGenre.TableString} due to {ex.ToString()}");
            }
        }

        private int GetGenreBookCount(string chosenGenreID)
        {
            string qryCount = "SELECT COUNT(0) FROM MyBooks WHERE GenreID=@GenreID;";
            var paramCount = new { GenreID = chosenGenreID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qryCount, paramCount);
        }
    }
}
