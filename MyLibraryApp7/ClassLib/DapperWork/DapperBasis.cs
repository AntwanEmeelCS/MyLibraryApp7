using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace MyLibraryApp7.ClassLib.DapperWork
{
    public class DapperBasis
    {
        public static string db_path = Application.StartupPath + "\\assets\\MyLibraryApp7.db";
        public static string connectionString = $"Data Source={db_path};Version=3;";
        public int ExecuteQuery(string qry, object parameters=null)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();//creates db if don't exist
                return conn.Execute(qry, parameters);
            }
        }
        public T ExecuteScalar<T>(string qry, object parameters=null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();//creates db if don't exist
                return conn.ExecuteScalar<T>(qry, parameters);
            }
        }
        public IEnumerable<T> GetResultList<T>(string qry, object parameters=null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();//creates db if don't exist
                return conn.Query<T>(qry, parameters);
            }
        }
        public void FillComboBox(ComboBox box, string qry, object parameters=null)
        {
            ComboBoxItem[] items = GetResultList<ComboBoxItem>(qry, parameters).ToArray();
            box.Items.Clear();
            box.BeginUpdate();
            box.Items.AddRange((object[])items);
            box.EndUpdate();
            if (box.Items.Count>0)
            {
                box.SelectedIndex = 0;
            }
        }
    }
}
