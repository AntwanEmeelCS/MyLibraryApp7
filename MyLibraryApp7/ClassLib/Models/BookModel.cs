using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string BookISBN { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public string PublicationDate { get; set; }
        public int GenreID { get; set; }
        public int Pages { get; set; }
        public int ShelfID { get; set; }
        public static List<BookModificationRecord> CompareModifications(BookModel InitialBook, BookModel ChangedBook)
        {
            List<BookModificationRecord> mods = new List<BookModificationRecord>();
            if (InitialBook!=null)
            {
                if (ChangedBook!=null)
                {
                    if (InitialBook.BookID == ChangedBook.BookID)
                    {
                        if (InitialBook.BookTitle != ChangedBook.BookTitle)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "BookTitle", ValueBefore = InitialBook.BookTitle, ValueAfter = ChangedBook.BookTitle });
                        }
                        if (InitialBook.BookISBN != ChangedBook.BookISBN)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "BookISBN", ValueBefore = InitialBook.BookISBN, ValueAfter = ChangedBook.BookISBN });
                        }
                        if (InitialBook.AuthorID != ChangedBook.AuthorID)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "AuthorID", ValueBefore = InitialBook.AuthorID.ToString(), ValueAfter = ChangedBook.AuthorID.ToString() });
                        }
                        if (InitialBook.PublisherID != ChangedBook.PublisherID)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "PublisherID", ValueBefore = InitialBook.PublisherID.ToString(), ValueAfter = ChangedBook.PublisherID.ToString() });
                        }
                        if (InitialBook.PublicationDate != ChangedBook.PublicationDate)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "PublicationDate", ValueBefore = InitialBook.PublicationDate, ValueAfter = ChangedBook.PublicationDate });
                        }
                        if (InitialBook.GenreID != ChangedBook.GenreID)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "GenreID", ValueBefore = InitialBook.GenreID.ToString(), ValueAfter = ChangedBook.GenreID.ToString() });
                        }
                        if (InitialBook.Pages != ChangedBook.Pages)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "Pages", ValueBefore = InitialBook.Pages.ToString(), ValueAfter = ChangedBook.Pages.ToString() });
                        }
                        if (InitialBook.ShelfID != ChangedBook.ShelfID)
                        {
                            mods.Add(new BookModificationRecord { BookID = InitialBook.BookID, ModifiedFieldName = "ShelfID", ValueBefore = InitialBook.ShelfID.ToString(), ValueAfter = ChangedBook.ShelfID.ToString() });
                        }
                        return mods;
                    }
                    else
                    {
                        throw new InvalidOperationException("Cannot Compare Book Items WITH Different BookID");
                    }
                }
                else
                {
                    throw new NullReferenceException("Cannot compare BookModel to null");
                }
            }
            else
            {
                throw new NullReferenceException("Cannot compare null to a BookModel");
            }
        }
    }
}
