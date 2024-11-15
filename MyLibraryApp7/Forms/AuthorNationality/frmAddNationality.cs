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

namespace MyLibraryApp7.Forms.AuthorNationality
{
    public partial class frmAddNationality : Form
    {
        public frmAddNationality()
        {
            InitializeComponent();
        }

        private void frmAddNationality_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            txtNationality.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private int GetNextNationalityID()
        {
            string qry = "SELECT COALESCE(MAX(NationalityID), 0) + 1 as NextNationalityID FROM Nationality";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNationality.Text.Trim() != "")
            {
                try
                {
                    string qryAddNewNationality = "INSERT INTO Nationality (NationalityID, NationalityName) VALUES (@NationalityID, @NationalityName);";
                    var paramAddNewNationality = new { NationalityID = GetNextNationalityID(), NationalityName = txtNationality.Text };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryAddNewNationality, paramAddNewNationality);
                    MessageBox.Show($"Nationality {paramAddNewNationality.NationalityName} Added Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Nationality due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Nationality Name.");
            }
        }
    }
}
