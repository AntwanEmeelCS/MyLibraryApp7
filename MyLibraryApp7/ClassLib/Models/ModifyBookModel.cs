using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib.Models
{
    public class ModifyBookModel
    {
        public string BookTitle { get; set; }
        public string BookISBN { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public string PublicationDate { get; set; }
        public int GenreID { get; set; }
        public int Pages { get; set; }
        public int ShelfID { get; set; }
    }
}
