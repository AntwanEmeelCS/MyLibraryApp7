using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.ClassLib.DapperWork
{
    public class DapperSpecifics: DapperBasis
    {
        public void FillNationalities(ComboBox cboNationality)
        {
            string qry = "SELECT NationalityID AS TableID, substr('000' || NationalityID, -3) || ' - ' || NationalityName AS TableString FROM Nationality;";
            this.FillComboBox(cboNationality, qry);
        }
        public void FillAuthors(ComboBox cboAuthors)
        {
            string qry = "SELECT AuthorID AS TableID, substr('000' || AuthorID, -3) || ' - ' || AuthorName AS TableString FROM Author ORDER BY AuthorName;";
            this.FillComboBox(cboAuthors, qry);
        }
        public void FillGenres(ComboBox cboGenres)
        {
            string qry = "SELECT GenreID AS TableID, substr('000' || GenreID, -3) || ' - ' || GenreName AS TableString FROM Genre;";
            this.FillComboBox(cboGenres, qry);
        }
        public void FillLocations(ComboBox cboLocations)
        {
            string qry = "SELECT LocationID AS TableID, substr('000' || LocationID, -3) || ' - ' || LocationName AS TableString FROM PublisherLocation;";
            this.FillComboBox(cboLocations, qry);
        }
        public void FillPublishers(ComboBox cboPublishers)
        {
            string qry = "SELECT PublisherID AS TableID, substr('000' || PublisherID, -3) || ' - ' || PublisherName AS TableString FROM Publisher;";
            this.FillComboBox(cboPublishers, qry);
        }
        public void FillShelves(ComboBox cboShelves)
        {
            string qry = "SELECT ShelfID AS TableID, substr('000' || ShelfID, -3) || ' - ' || ShelfName AS TableString FROM Shelves;";
            this.FillComboBox(cboShelves, qry);
        }
    }
}
