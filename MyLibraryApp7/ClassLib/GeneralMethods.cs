using MyLibraryApp7.ClassLib.DapperWork;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.ClassLib
{
    public static class GeneralMethods
    {
        public static void SetFormIcon(Form frm)
        {
            string appPath = Application.StartupPath;
            frm.Icon = new Icon(appPath + "\\assets\\MyLibraryApp7.ico");
        }
        public static ComboBoxItem GetSelectedItem(this ComboBox box)
        {
            return (ComboBoxItem)box.SelectedItem;
        }
        public static string GetSelectedItemID(this ComboBox box)
        {
            return ((ComboBoxItem)box.SelectedItem).TableID;
        }
        public static string GetSelectedItemString(this ComboBox box)
        {
            return ((ComboBoxItem)box.SelectedItem).TableString;
        }
    }
}
