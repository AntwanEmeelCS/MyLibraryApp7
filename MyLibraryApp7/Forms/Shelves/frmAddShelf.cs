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

namespace MyLibraryApp7.Forms.Shelves
{
    public partial class frmAddShelf : Form
    {
        public frmAddShelf()
        {
            InitializeComponent();
        }

        private void frmAddShelf_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            txtShelfName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private int GetNextShelfID()
        {
            string qry = "SELECT COALESCE(MAX(ShelfID), 0) + 1 as NextShelfID FROM Shelves";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtShelfName.Text.Trim() != "")
            {
                try
                {
                    string qryAddNewShelf = "INSERT INTO Shelves (ShelfID, ShelfName, Notes) VALUES (@ShelfID, @ShelfName, @Notes);";
                    var paramAddNewShelf = new { ShelfID=GetNextShelfID(), ShelfName = txtShelfName.Text, Notes = txtNotes.Text };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryAddNewShelf, paramAddNewShelf);
                    MessageBox.Show($"Shelf {paramAddNewShelf.ShelfName} Added Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Shelf due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Shelf Name.");
            }
        }
    }
}
