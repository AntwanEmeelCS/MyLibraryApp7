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

namespace MyLibraryApp7.Forms.Shelves
{
    public partial class frmDeleteShelf : Form
    {
        public frmDeleteShelf()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenShelf { get; set; }
        
        private void frmDeleteShelf_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillShelves(cboShelves);
        }

        private void cboShelves_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenShelf = cboShelves.GetSelectedItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetShelfBookCount(this.ChosenShelf.TableID)==0)
                {
                    string qryDeleteShelf = "DELETE FROM Shelves WHERE ShelfID=@ShelfID;";
                    var paramDeleteShelf = new { ShelfID = this.ChosenShelf.TableID };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qryDeleteShelf, paramDeleteShelf);
                    MessageBox.Show($"Shelf {this.ChosenShelf.TableString} Deleted Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cannot Delete a Shelf that has books!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Shelf {this.ChosenShelf.TableString} due to {ex.ToString()}");
            }
        }

        private int GetShelfBookCount(string chosenShelfID)
        {
            string qryCount = "SELECT COUNT(0) FROM MyBooks WHERE ShelfID=@ShelfID;";
            var paramCount = new { ShelfID = chosenShelfID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qryCount, paramCount);
        }
    }
}
