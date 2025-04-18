﻿using MyLibraryApp7.ClassLib;
using MyLibraryApp7.ClassLib.DapperWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp7.Forms.SearchForms
{
    public partial class frmLookupSearch : Form
    {
        public frmLookupSearch(string TableName, string TableID_field, string TableString_field)
        {
            InitializeComponent();
            this.DBTableName = TableName;
            this.TableID_Field = TableID_field;
            this.TableString_Field = TableString_field;
            this.Text = $"Search {this.SearchObjectName}";
            //added 2025-04-02 for debugging an issue
            this.AdditionalConditions = "";
        }
        public frmLookupSearch(string TableName, string TableID_field, string TableString_field, string AdditionalConditions="")
        {
            InitializeComponent();
            this.DBTableName = TableName;
            this.TableID_Field = TableID_field;
            this.TableString_Field = TableString_field;
            this.Text = $"Search {this.SearchObjectName}";
            this.AdditionalConditions = AdditionalConditions;
        }
        public string SearchObjectName { get; set; }
        public string DBTableName { get; set; }
        public string TableID_Field { get; set; }
        public string TableString_Field { get; set; }
        public string AdditionalConditions { get; set; }
        public enum FilterFieldName
        {
            none, ID, String
        };
        public string GetSelectString(FilterFieldName fieldName=FilterFieldName.none, string filterValue="")
        {
            string qry = $"SELECT {this.TableID_Field} as TableID, {this.TableString_Field} as TableString FROM {this.DBTableName}\n";
            if (fieldName==FilterFieldName.ID)
            {
                qry += $"WHERE {this.TableID_Field} = '{filterValue}'";
            }
            if (fieldName == FilterFieldName.String)
            {
                qry += $"WHERE {this.TableString_Field} like '%{filterValue}%'";
            }
            //NOT USED
            //TODO: you should pass AdditionalConditions to the function as a FilterValue instead of directly accessing it.
            //if (this.AdditionalConditions.Trim()!="")
            //{
            //    qry += "\n AND " + this.AdditionalConditions;
            //}
            return qry;
        }
        public List<ComboBoxItem> GetSearchResults(FilterFieldName fieldName = FilterFieldName.none, string filterValue = "")
        {
            string qry = GetSelectString(fieldName, filterValue);
            DapperBasis db = new DapperBasis();
            return db.GetResultList<ComboBoxItem>(qry).ToList();
        }
        public void FillDataGridView(DataGridView dgv, FilterFieldName fieldName = FilterFieldName.none, string filterValue = "")
        {
            List<ComboBoxItem> list = GetSearchResults(fieldName, filterValue);
            dgv.DataSource = list;
            dgv.Columns["TableID"].HeaderText = "ID";
            dgv.Columns["TableString"].HeaderText = "String";
        }
        private void frmLookupSearch_Load(object sender, EventArgs e)
        {
            GeneralMethods.SetFormIcon(this);
            FillDataGridView(dgvSearchResults);
        }

        private void txtSearchKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchKeyword.Text.Trim()!="")
            {
                FilterFieldName fieldName = rdbTableID.Checked ? FilterFieldName.ID : FilterFieldName.String;
                FillDataGridView(dgvSearchResults,fieldName,txtSearchKeyword.Text);
            }
            else
            {
                FillDataGridView(dgvSearchResults);
            }
        }
    }
}
