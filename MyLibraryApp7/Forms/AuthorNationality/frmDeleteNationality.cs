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
    public partial class frmDeleteNationality : Form
    {
        public frmDeleteNationality()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenNationality{ get; set; }
        
        private void frmDeleteNationality_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillNationalities(cboNationality);
        }

        private void cboNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenNationality = cboNationality.GetSelectedItem(); ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetNationalityAuthorCount(this.ChosenNationality.TableID) ==0)
                {
                    string qryDeleteNationality = "DELETE FROM Nationality WHERE NationalityID=@NationalityID;";
                    var paramDeleteNationality = new { NationalityID = this.ChosenNationality.TableID };
                    DapperBasis db = new DapperBasis();
                    db.ExecuteQuery(qryDeleteNationality, paramDeleteNationality);
                    MessageBox.Show($"Nationality {this.ChosenNationality.TableString} Deleted Successfully.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cannot Delete a Nationality that has authors!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Nationality {this.ChosenNationality.TableString} due to {ex.ToString()}");
            }
        }

        private int GetNationalityAuthorCount(string chosenNationalityID)
        {
            string qryCount = "SELECT COUNT(0) FROM Author WHERE AuthorNationalityID=@NationalityID;";
            var paramCount = new { NationalityID = chosenNationalityID };
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qryCount, paramCount);
        }
    }
}
