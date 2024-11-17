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

namespace MyLibraryApp7.Forms.PublisherLocation
{
    public partial class frmDeleteLocation : Form
    {
        public frmDeleteLocation()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenLocation { get; set; }
       
        private void frmDeleteLocation_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillLocations(cboLocation);
        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenLocation = cboLocation.GetSelectedItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetLocationPublisherCount(this.ChosenLocation.TableID)==0)
                {
                    string qryDeleteLocation = "DELETE FROM PublisherLocation WHERE LocationID=@LocationID;";
                    var paramDeleteLocation = new { LocationID = this.ChosenLocation.TableID };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qryDeleteLocation, paramDeleteLocation);
                    MessageBox.Show($"Location {this.ChosenLocation.TableString} Deleted Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cannot Delete a Location that has Publishers!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Location {this.ChosenLocation.TableString} due to {ex.ToString()}");
            }
        }

        private int GetLocationPublisherCount(string chosenLocationID)
        {
            string qryCount = "SELECT COUNT(0) FROM Publisher WHERE PublisherLocationID=@LocationID;";
            var paramCount = new { LocationID = chosenLocationID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qryCount, paramCount);
        }
    }
}
