using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public List<clsStock> StockList { get; set; } = new List<clsStock>();
        public int Count => StockList?.Count ?? 0;
        public clsStock ThisStock { get; set; } = new clsStock();

        public clsStockCollection()
        {
            RefreshAll();
        }

        public int Add()
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@StockName", ThisStock.StockName);
            DB.AddParameter("@SupplierName", ThisStock.SupplierName);
            DB.AddParameter("@StockSellingPrice", ThisStock.StockSellingPrice);
            DB.AddParameter("@StockQuantity", ThisStock.StockQuantity);
            DB.AddParameter("@Active", ThisStock.Active);

            int newId = DB.Execute("sproc_tblStock_Insert");
            ThisStock.StockId = newId;
            RefreshAll();
            return newId;
        }

        public void Update()
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@StockId", ThisStock.StockId);
            DB.AddParameter("@StockName", ThisStock.StockName);
            DB.AddParameter("@SupplierName", ThisStock.SupplierName);
            DB.AddParameter("@StockSellingPrice", ThisStock.StockSellingPrice);
            DB.AddParameter("@StockQuantity", ThisStock.StockQuantity);
            DB.AddParameter("@Active", ThisStock.Active);

            DB.Execute("sproc_tblStock_Update");
            RefreshAll();
        }

        public void Delete()
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@StockId", ThisStock.StockId);
            DB.Execute("sproc_tblStock_Delete");
            RefreshAll();
        }

        public void ReportByStockName(string StockName)
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@StockName", StockName ?? string.Empty);
            DB.Execute("sproc_tblStock_FilterByStockName");
            PopulateArray(DB);
        }

        // Add inside ClassLibrary.clsStockCollection
        public void ReportBySupplierName(string supplierOrName)
        {
        // Backward compatible alias if other pages still call this
         ReportByStockName(supplierOrName);
        }


        private void PopulateArray(clsDataConnection DB)
        {
            var list = new List<clsStock>();
            for (int i = 0; i < DB.Count; i++)
            {
                var row = DB.DataTable.Rows[i];
                var s = new clsStock
                {
                    StockId = Convert.ToInt32(row["StockId"]),
                    StockName = Convert.ToString(row["StockName"]),
                    SupplierName = Convert.ToString(row["SupplierName"]),
                    DateAdded = Convert.ToDateTime(row["DateAdded"]),
                    StockSellingPrice = Convert.ToInt32(row["StockSellingPrice"]),
                    StockQuantity = Convert.ToInt32(row["StockQuantity"]),
                    Active = Convert.ToBoolean(row["Active"])
                };
                list.Add(s);
            }
            StockList = list;
        }

        private void RefreshAll()
        {
            var DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
        }
    }
}
