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

namespace MyLibraryApp7.Forms.PublisherLocation
{
    public partial class frmAddLocation : Form
    {
        public frmAddLocation()
        {
            InitializeComponent();
        }

        private void frmAddLocation_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            txtLocation.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private int GetNextLocationID()
        {
            string qry = "SELECT COALESCE(MAX(LocationID), 0) + 1 as NextLocationID FROM PublisherLocation";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text.Trim() != "")
            {
                try
                {
                    string qryAddNewLocation = "INSERT INTO PublisherLocation (LocationID, LocationName) VALUES (@LocationID, @LocationName);";
                    var paramAddNewLocation = new { LocationID = GetNextLocationID(), LocationName = txtLocation.Text };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryAddNewLocation, paramAddNewLocation);
                    MessageBox.Show($"Location {paramAddNewLocation.LocationName} Added Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Location due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Location Name.");
            }
        }
    }
}
