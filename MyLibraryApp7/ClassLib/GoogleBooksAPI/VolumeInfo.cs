using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib.GoogleBooksAPI
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string publishedDate { get; set; }
        public IndustryIdentifier[] IndustryIdentifiers { get; set; }
        public int pageCount { get; set; }
        public string GetISBN()
        {
            foreach (IndustryIdentifier item in IndustryIdentifiers)
            {
                if (item.Type== "ISBN_13")
                {
                    return item.Identifier;
                }
            }
            //not found isbn13, find isbn10
            foreach (IndustryIdentifier item in IndustryIdentifiers)
            {
                if (item.Type == "ISBN_10")
                {
                    return item.Identifier;
                }
            }
            //no found isbn
            return "";
        }
    }
}
