using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib.GoogleBooksAPI
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public IndustryIdentifier[] IndustryIdentifiers { get; set; }
        public int pageCount { get; set; }
        public string[] categories { get; set; }
        public string GetAuthorName()
        {
            if (Authors!=null)
            {
                if (Authors.Length == 1)
                {
                    return Authors[0];
                }
                else if (Authors.Length > 1)
                {
                    string FirstAuthorName = "";
                    Regex arabicRegex = new Regex(@"\p{IsArabic}");
                    foreach (string item in Authors)
                    {
                        if (arabicRegex.IsMatch(item))
                        {
                            if (FirstAuthorName == "")
                            {
                                FirstAuthorName = item;
                            }
                            else
                            {
                                return "مجموعة مؤلفين";
                            }
                        }
                    }
                    if (FirstAuthorName == "")
                    {
                        return "مؤلف غير معروف";
                    }
                    else
                    {
                        return FirstAuthorName;
                    }

                }
                else
                {
                    return "مؤلف غير معروف";
                } 
            }
            else
            {
                return "مؤلف غير معروف";
            }
        }
        public string GetISBN()
        {
            if (IndustryIdentifiers==null || IndustryIdentifiers.Length==0)
            {
                //no found isbn
                return "";
            }
            foreach (IndustryIdentifier item in IndustryIdentifiers)
            {
                if (item.Type == "ISBN_13")
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
            return "";
        }
        public string GetGenre()
        {
            if (categories!=null)
            {
                if (categories.Length != 0)
                {
                    return categories[0];
                }
                else
                {
                    return "";
                } 
            }
            else
            {
                return "";
            }
        }
        public string GetPublisherName()
        {
            if (Publisher == null || Publisher.Length == 0)
            {
                return "ناشر غير معروف";
            }
            else
            {
                return Publisher;
            }
        }
        public string GetPublicationDate()
        {
            if (PublishedDate == null || PublishedDate.Length == 0)
            {
                return "1900-01-01";
            }
            else
            {
                return PublishedDate;
            }
        }
    }
}
