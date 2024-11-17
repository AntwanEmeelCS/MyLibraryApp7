using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib.GoogleBooksAPI
{
    public class GoogleBooksResponse
    {
        public string Kind { get; set; }
        public int TotalItems { get; set; }
        public GoogleBook[] Items { get; set; }
    }
}
