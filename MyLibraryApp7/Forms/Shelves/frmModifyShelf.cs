using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.ClassLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.Shelves
{
    public partial class frmModifyShelf : Form
    {
        public frmModifyShelf()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenShelf { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmModifyShelf_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillShelves(cboShelves);
        }

        
        private void cboShelves_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenShelf = cboShelves.GetSelectedItem();
            FillShelfData();
        }

        private void FillShelfData()
        {
            string qryShelfData = "SELECT ShelfID, ShelfName, Notes FROM Shelves WHERE ShelfID=@ShelfID;";
            var paramShelfData = new { ShelfID = this.ChosenShelf.TableID };
            DapperBasis db = new DapperBasis();
            ShelfItem[] items = db.GetResultList<ShelfItem>(qryShelfData, paramShelfData).ToArray();
            txtNewShelfName.Text = items[0].ShelfName;
            txtNewNotes.Text = items[0].Notes;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewShelfName.Text.Trim()!="")
                {
                    string qryModifyShelf = @"UPDATE Shelves
                                        SET ShelfName=@ShelfName,
	                                        Notes=@Notes
                                        WHERE ShelfID=@ShelfID;";
                    var paramModifyShelf = new { ShelfID = this.ChosenShelf.TableID, ShelfName = txtNewShelfName.Text, Notes = txtNewNotes.Text };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryModifyShelf, paramModifyShelf);
                    MessageBox.Show($"Shelf {this.ChosenShelf.TableString} Modified Successfully.");
                    this.DialogResult = DialogResult.OK; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Modifying Shelf {this.ChosenShelf.TableString} due to {ex.ToString()}");
            }
        }
    }
}
