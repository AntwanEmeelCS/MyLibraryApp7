using MyLibraryApp7.ClassLib.DapperWork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib.Models
{
    public class BookModificationRecord
    {
        public int BookID { get; set; }
        public string ModifiedFieldName { get; set; }
        public string ValueBefore { get; set; }
        public string ValueAfter { get; set; }
        public void RecordModificationField()
        {
            string qry = @"INSERT INTO BookModifications
                        (BookID, ModifiedFieldName, ValueBefore, ValueAfter, ModificationTimestamp)
                        VALUES
                        (@BookID, @ModifiedFieldName, @ValueBefore, @ValueAfter, @ModificationTimestamp)";
            var parameters = new
            {
                BookID = this.BookID,
                ModifiedFieldName = this.ModifiedFieldName,
                ValueBefore = this.ValueBefore,
                ValueAfter = this.ValueAfter,
                ModificationTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
            DapperBasis db = new DapperBasis();
            db.ExecuteQuery(qry, parameters);
        }
    }
}
