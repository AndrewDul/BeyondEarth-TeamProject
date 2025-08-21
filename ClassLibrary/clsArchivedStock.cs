using System;

namespace ClassLibrary
{
    public class clsArchivedStock
    {
        // ------- Properties -------
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string SupplierName { get; set; }
        public int StockSellingPrice { get; set; }   // int to match your example/tests
        public int StockQuantity { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Active { get; set; }

        // ------- Methods -------
        public bool Find(int stockId)
        {
            var DB = new clsDataConnection();
            DB.AddParameter("@StockId", stockId);
            DB.Execute("sproc_tblArchivedStock_FilterByStockId");

            if (DB.Count == 1)
            {
                var row = DB.DataTable.Rows[0];
                StockId = Convert.ToInt32(row["StockId"]);
                StockName = Convert.ToString(row["StockName"]);
                SupplierName = Convert.ToString(row["SupplierName"]);
                DateAdded = Convert.ToDateTime(row["DateAdded"]);
                StockSellingPrice = Convert.ToInt32(Convert.ToDecimal(row["StockSellingPrice"]));
                StockQuantity = Convert.ToInt32(row["StockQuantity"]);
                Active = Convert.ToBoolean(row["Active"]);
                return true;
            }
            return false;
        }

        public string Valid(string stockName, string supplierName, string stockSellingPrice, string stockQuantity)
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(stockName) || stockName.Length > 50)
                error += "StockName invalid; ";

            if (string.IsNullOrWhiteSpace(supplierName) || supplierName.Length > 50)
                error += "SupplierName invalid; ";

            int price;
            if (!int.TryParse(stockSellingPrice, out price) || price < 1 || price > 100000)
                error += "StockSellingPrice invalid; ";

            int qty;
            if (!int.TryParse(stockQuantity, out qty) || qty < 0 || qty > 100000)
                error += "StockQuantity invalid; ";

            return error;
        }

        // ------- Override Equals (for Assert.AreEqual in tests) -------
        public override bool Equals(object obj)
        {
            if (obj is clsArchivedStock other)
            {
                return StockId == other.StockId &&
                       StockName == other.StockName &&
                       SupplierName == other.SupplierName &&
                       StockSellingPrice == other.StockSellingPrice &&
                       StockQuantity == other.StockQuantity &&
                       DateAdded == other.DateAdded &&
                       Active == other.Active;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return StockId.GetHashCode();
        }
    }
}
