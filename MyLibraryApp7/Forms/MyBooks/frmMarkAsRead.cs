using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.ClassLib.Models;
using MyLibraryApp7.Forms.SearchForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.MyBooks
{
    
    public partial class frmMarkAsRead : Form
    {
        public frmMarkAsRead()
        {
            InitializeComponent();
        }

        private void btnSearchBookID_Click(object sender, EventArgs e)
        {
            frmLookupSearch frmSearchAuthor = new frmLookupSearch("V_MyBooks", "BookID", "CONCAT(BookTitle, ' - ', AuthorName)","isRead=0");
            frmSearchAuthor.ShowDialog(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmMarkAsRead_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            txtPass.Focus();
        }

        private void txtBookID_Leave(object sender, EventArgs e)
        {
            if (txtBookID.Text.Trim()!="")
            {
                if (int.TryParse(txtBookID.Text.Trim(), out int BookID)==true)
                {
                    string qryBookInfo = @"SELECT BookTitle, AuthorName
FROM V_MyBooks
WHERE BookID=@BookID AND IsRead=0";
                    var paramBokkInfo = new { BookID = BookID };
                    DapperBasis db = new DapperBasis();
                    List<BookTitleAuthor> results = db.GetResultList<BookTitleAuthor>(qryBookInfo, paramBokkInfo).ToList();
                    if (results.Count>0)
                    {
                        lblBookTitle.Text = results[0].BookTitle;
                        lblAuthorName.Text = results[0].AuthorName;
                    }
                    else
                    {
                        MessageBox.Show("Book with ID " + txtBookID.Text + " wan NOT FOUND");
                        txtBookID.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid BookID.");
                    txtBookID.Focus();
                }
            }
            else
            {
                MessageBox.Show("BookID cannot be left empty.");
                txtBookID.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string qry = @"UPDATE MyBooks
SET	IsRead=1,
	ReadCompletedDate=@ReadCompletedDate
WHERE BookID=@BookID";
            var parameters = new { BookID = txtBookID.Text, ReadCompletedDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") };
            DapperBasis db = new DapperBasis();
            try
            {
                db.ExecuteQuery(qry, parameters);
                MessageBox.Show("Updating Book " + lblBookTitle.Text + " Completed Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
