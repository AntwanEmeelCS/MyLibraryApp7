using MyLibraryApp7.ClassLib.GoogleBooksAPI;
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
        private async Task GetBookResult(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    GoogleBooksResponse books = JsonConvert.DeserializeObject<GoogleBooksResponse>(jsonData);
                    //TODO: fill a datagridview with items
                    MessageBox.Show($"{books.Items.Length} Books Found!");
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
    }
}
