using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using MyLibraryApp7.ClassLib.GoogleBooksAPI;
using MyLibraryApp7.ClassLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.MyBooks
{
    public partial class frmGoogleBooksSearch : Form
    {
        public frmGoogleBooksSearch()
        {
            InitializeComponent();
        }
        public ComboBoxItem ChosenShelf { get; set; }
        private async Task GetBookResult(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    GoogleBooksResponse books = JsonConvert.DeserializeObject<GoogleBooksResponse>(jsonData);
                    //fill books
                    dgvFoundBooks.Rows.Clear();
                    foreach (GoogleBook item in books.Items)
                    {
                        VolumeInfo vol = item.VolumeInfo;
                        dgvFoundBooks.Rows.Add(vol.Title, vol.GetAuthorName(), vol.GetPublisherName(), vol.GetPublicationDate(), vol.GetISBN(), vol.pageCount, vol.GetGenre());
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string queryTitle = txtSearchTitle.Text.Trim();
            string queryAuthor = txtSearchAuthor.Text.Trim();
            string searchQuery;
            if (queryTitle != "" && queryAuthor!="")
            {
                searchQuery= $"{Uri.EscapeDataString(queryTitle)}+inauthor:{Uri.EscapeDataString(queryAuthor)}";
                
            }
            else if (queryTitle != "" && queryAuthor == "")
            {
                searchQuery = $"{Uri.EscapeDataString(queryTitle)}";
            }
            else if (queryTitle == "" && queryAuthor != "")
            {
                searchQuery = $"inauthor:{Uri.EscapeDataString(queryAuthor)}";
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Title or Author Name.");
                return;
            }
            string url= $"https://www.googleapis.com/books/v1/volumes?q={searchQuery}&langRestrict=ar";
            await GetBookResult(url);
        }

        private void frmGoogleBooksSearch_Load(object sender, EventArgs e)
        {
            DapperSpecifics ds = new DapperSpecifics();
            ds.FillShelves(cboShelves);
        }
        private int GetNextBookID()
        {
            string qry = "SELECT COALESCE(MAX(BookID), 0) + 1 as NextBookID FROM MyBooks";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            if (dgvFoundBooks.Rows.Count>0 && dgvFoundBooks.SelectedRows.Count>0)
            {
                foreach (DataGridViewRow item in dgvFoundBooks.SelectedRows)
                {
                    string title="";
                    try
                    {
                        //initialz
                        title = item.Cells["colTitle"].Value.ToString();
                        string authorname = item.Cells["colAuthor"].Value.ToString();
                        string isbn = item.Cells["colISBN"].Value.ToString();
                        string publisherName = item.Cells["colPublisher"].Value.ToString();
                        string pubDate = item.Cells["colPubDate"].Value?.ToString();
                        string genreName = item.Cells["colGenre"].Value.ToString();
                        string pageCountString = item.Cells["colPageCount"].Value.ToString();
                        string qryAddBook = @"
        INSERT INTO MyBooks (BookID, BookTitle, AuthorID, BookISBN, PublisherID, PublicationDate, GenreID, Pages, ShelfID, DateAdded)
        VALUES (@BookID, @BookTitle, @AuthorID, @BookISBN, @PublisherID, @PublicationDate, @GenreID, @Pages, @ShelfID, @DateAdded);";
                        var paramAddBook = new
                        {
                            BookID = GetNextBookID(),
                            BookTitle = title,
                            AuthorID = FindOrAddAuthor(authorname),
                            BookISBN = isbn.Length == 0 ? null : isbn,
                            PublisherID = FindOrAddPublisher(publisherName),
                            PublicationDate = pubDate.Length == 0 ? "1900-01-01" : pubDate,
                            GenreID = FindOrAddGenre(genreName),
                            Pages = Convert.ToInt32(pageCountString),
                            ShelfID = this.ChosenShelf.TableID,
                            DateAdded = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.FFF")
                        };
                        DapperBasis db = new DapperBasis();
                        int rowsAffected = db.ExecuteQuery(qryAddBook, paramAddBook);
                        DialogResult result = MessageBox.Show($"Book {title} was added Successfully.", "MyLibraryApp7");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Adding Book {title} FAILED due to {ex.ToString()}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty list or no sdelected books.");
            }
        }
        private int GetNextAuthorID()
        {
            string qry = "SELECT COALESCE(MAX(AuthorID), 0) + 1 as NextAuthorID FROM Author";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private object FindOrAddAuthor(string authorname)
        {
            if (authorname.Trim() != "")
            {
                string qry = "SELECT AuthorID FROM Author WHERE AuthorName=@AuthorName;";
                var parameters = new { AuthorName = authorname };
                DapperBasis db = new DapperBasis();
                int authorID = db.ExecuteScalar<int>(qry, parameters);
                if (authorID == 0)
                {
                    try
                    {
                        int nextAuthorID = GetNextAuthorID();
                        string qryAddNewAuthor = "INSERT INTO Author (AuthorID, AuthorName, AuthorNationalityID) VALUES (@AuthorID, @AuthorName, 1);";
                        var paramAddNewAuthor = new { AuthorID = nextAuthorID, AuthorName = authorname };
                        int rowsAffected = db.ExecuteQuery(qryAddNewAuthor, paramAddNewAuthor);
                        return nextAuthorID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Adding Author due to {ex.ToString()}");
                        return null;
                    }
                }
                else
                {
                    return authorID;
                }
            }
            else
            {
                return 11;//unknown author
            }
        }

        private int GetNextGenreID()
        {
            string qry = "SELECT COALESCE(MAX(GenreID), 0) + 1 as NextGenreID FROM Genre";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private object FindOrAddGenre(string genreName)
        {
            if (genreName.Trim()!="")
            {
                string qry = "SELECT GenreID FROM Genre WHERE GenreName=@GenreName;";
                var parameters = new { GenreName = genreName };
                DapperBasis db = new DapperBasis();
                int genreID = db.ExecuteScalar<int>(qry, parameters);
                if (genreID == 0)
                {
                    try
                    {
                        int nextGenreID = GetNextGenreID();
                        string qryAddNewGenre = "INSERT INTO Genre (GenreID, GenreName) VALUES (@GenreID, @GenreName);";
                        var paramAddNewGenre = new { GenreID = nextGenreID, GenreName = genreName };
                        int rowsAffected = db.ExecuteQuery(qryAddNewGenre, paramAddNewGenre);
                        return nextGenreID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Adding Genre due to {ex.ToString()}");
                        return null;
                    }
                }
                else
                {
                    return genreID;
                } 
            }
            else
            {
                return 40;//unknown genre
            }
        }
        private int GetNextPublisherID()
        {
            string qry = "SELECT COALESCE(MAX(PublisherID), 0) + 1 as NextLocationID FROM Publisher";
            DapperBasis db = new DapperBasis();
            return db.ExecuteScalar<int>(qry);
        }
        private object FindOrAddPublisher(string publisherName)
        {
            if (publisherName.Trim()!="")
            {
                string qry = "SELECT PublisherID FROM Publisher WHERE PublisherName=@PublisherName;";
                var parameters = new { PublisherName = publisherName };
                DapperBasis db = new DapperBasis();
                int publisherID = db.ExecuteScalar<int>(qry, parameters);
                if (publisherID == 0)
                {
                    try
                    {
                        int nextPublisherID = GetNextPublisherID();
                        string qryAddNewPublisher = "INSERT INTO Publisher (PublisherID, PublisherName, PublisherLocationID) VALUES (@PublisherID, @PublisherName, 1);";
                        var paramAddNewPublisher = new { PublisherID = nextPublisherID, PublisherName = publisherName };
                        int rowsAffected = db.ExecuteQuery(qryAddNewPublisher, paramAddNewPublisher);
                        return nextPublisherID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Adding Publisher due to {ex.ToString()}");
                        return null;
                    }
                }
                else
                {
                    return publisherID;
                } 
            }
            else
            {
                return 7;//unknown publisher
            }
        }

        private void cboShelves_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChosenShelf = cboShelves.GetSelectedItem();
        }
    }
}
