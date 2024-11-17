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
    public partial class frmModifyPublisher : Form
    {
        public frmModifyPublisher()
        {
            InitializeComponent();
        }
        public string ChosenLocationID { get; set; }
        public string ChosenPublisherID { get; set; }
        
        private void frmModifyPublisher_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillLocations(cboLocations);
            ds.FillPublishers(cboPublishers);
        }

        private void cboLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenLocationID = cboLocations.GetSelectedItemID();
        }

        private void cboPublishers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenPublisherID = cboPublishers.GetSelectedItemID();
            txtPublisherName.Text = GetPublisherName(this.ChosenPublisherID);
            SelectComboBoxItemById(cboLocations, GetPublisherLocation(this.ChosenPublisherID));
        }

        private string GetPublisherLocation(string chosenPublisherID)
        {
            string qry = "SELECT PublisherLocationID FROM Publisher WHERE PublisherID=@PublisherID";
            var parameters = new { PublisherID = chosenPublisherID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<string>(qry, parameters);
        }
        private string GetPublisherName(string chosenPublisherID)
        {
            string qry = "SELECT PublisherName FROM Publisher WHERE PublisherID=@PublisherID";
            var parameters = new { PublisherID = chosenPublisherID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<string>(qry, parameters);
        }
        public void SelectComboBoxItemById(ComboBox comboBox, string tableId)
        {
            int low = 0;
            int high = comboBox.Items.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (comboBox.Items[mid] is ComboBoxItem midItem)
                {
                    int comparison = string.Compare(midItem.TableID, tableId);
                    if (comparison == 0)
                    {
                        comboBox.SelectedItem = midItem;
                        return;
                    }
                    else if (comparison < 0)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            NotFoundItem(tableId);
        }

        public void NotFoundItem(string tableId)
        {
            throw new Exception($"PublisherID {tableId} NOT Found!");
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
                    string qryUpdatePublisher = @"UPDATE Publisher
                                                SET PublisherName=@PublisherName,
	                                                PublisherLocationID=@PublisherLocationID
                                                WHERE PublisherID=@PublisherID";
                    var paramUpdatePublisher = new { PublisherID = this.ChosenPublisherID, PublisherName = txtPublisherName.Text, PublisherLocationID = this.ChosenLocationID };
                    DapperBasis db = new DapperBasis();
                    int rowsAffected = db.ExecuteQuery(qryUpdatePublisher, paramUpdatePublisher);
                    MessageBox.Show($"Publisher {paramUpdatePublisher.PublisherName} Updated Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Updating Publisher due to {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Publisher Name.");
            }
        }
    }
}
