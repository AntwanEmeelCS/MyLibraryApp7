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

namespace MyLibraryApp7.Forms.Publisher
{
    public partial class frmAddPublisher : Form
    {
        public frmAddPublisher()
        {
            InitializeComponent();
        }
        public string ChosenLocationID { get; set; }
        
        private void frmAddPublisher_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillLocations(cboLocations);
        }

        private void cboLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenLocationID = cboLocations.GetSelectedItemID();
        }
        private int GetNextPublisherID()
        {
            string qry = "SELECT COALESCE(MAX(PublisherID), 0) + 1 as NextLocationID FROM Publisher";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPublisherName.Text.Trim() != "")
            {
                try
                {
                    string qryAddNewPublisher = "INSERT INTO Publisher (PublisherID, PublisherName, PublisherLocationID) VALUES (@PublisherID, @PublisherName, @PublisherLocationID);";
                    var paramAddNewPublisher = new { PublisherID = GetNextPublisherID(), PublisherName = txtPublisherName.Text, PublisherLocationID=this.ChosenLocationID };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryAddNewPublisher, paramAddNewPublisher);
                    MessageBox.Show($"Publisher {paramAddNewPublisher.PublisherName} Added Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Adding Publisher due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Publisher Name.");
            }
        }
    }
}
