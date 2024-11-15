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

namespace MyLibraryApp7.Forms.Publisher
{
    public partial class frmDeletePublisher : Form
    {
        public frmDeletePublisher()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenPublisher { get; set; }
       
        private void frmDeletePublisher_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillPublishers(cboPublishers);
        }

        private void cboPublishers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenPublisher = cboPublishers.GetSelectedItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetPublisherBookCount(this.ChosenPublisher.TableID) == 0)
                {
                    string qryDeletePublisher = "DELETE FROM Publisher WHERE PublisherID=@PublisherID;";
                    var paramDeletePublisher = new { PublisherID = this.ChosenPublisher.TableID };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qryDeletePublisher, paramDeletePublisher);
                    MessageBox.Show($"Publisher {this.ChosenPublisher.TableString} Deleted Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"Cannot delete a publisher that has books!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deleting Publisher {this.ChosenPublisher.TableString} Wasn't Successful due to {ex.ToString()}");
            }
        }

        private int GetPublisherBookCount(string chosenPublisherID)
        {
            string qry = "SELECT COUNT(0) FROM MyBooks WHERE PublisherID=@PublisherID;";
            var parameters = new { PublisherID = chosenPublisherID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry, parameters);
        }
    }
}
