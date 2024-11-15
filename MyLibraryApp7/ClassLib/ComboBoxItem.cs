using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp7.ClassLib
{
    public class ComboBoxItem
    {
        public string TableID { get; set; }
        public string TableString { get; set; }
        public override string ToString()
        {
            return TableString;
        }
    }
}
