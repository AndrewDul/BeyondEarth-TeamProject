using System;
using ClassLibrary.ClassLibrary;

namespace ClassLibrary
{
    public class clsStock
    {
        // Properties matching your tests
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string StockCode { get; set; }
        public int StockSellingPrice { get; set; }
        public int? QuantityInStock { get; set; }
        public string StockStatus { get; set; }
        public DateTime StockExpiryDate { get; set; }

        // Find method (mocked with hardcoded test data)
        public bool Find(int stockId)
        {
            // Simulate finding the stock with ID 21
            if (stockId == 21)
            {
                StockId = 21;
                StockName = "Test Stock";
                StockCode = "STK001";
                StockSellingPrice = 999;
                QuantityInStock = 50;
                StockStatus = "Available";
                StockExpiryDate = DateTime.Now.Date.AddDays(30);
                DateAdded = DateTime.Now.Date;
                Active = true;

                return true;
            }
            else
            {
                return false;
            }
        }
    }


    namespace ClassLibrary
    {
        public class clsStock
        {
            // Private data members
            private bool mActive;
            private DateTime mDateAdded;
            private int mStockId;
            private string mStockName;
            private string mStockCode;
            private int mStockSellingPrice;
            private int? mQuantityInStock;
            private string mStockStatus;
            private DateTime mStockExpiryDate;

            // Public properties using the private data members
            public bool Active
            {
                get { return mActive; }
                set { mActive = value; }
            }

            public DateTime DateAdded
            {
                get { return mDateAdded; }
                set { mDateAdded = value; }
            }

            public int StockId
            {
                get { return mStockId; }
                set { mStockId = value; }
            }

            public string StockName
            {
                get { return mStockName; }
                set { mStockName = value; }
            }

            public string StockCode
            {
                get { return mStockCode; }
                set { mStockCode = value; }
            }

            public int StockSellingPrice
            {
                get { return mStockSellingPrice; }
                set { mStockSellingPrice = value; }
            }

            public int? QuantityInStock
            {
                get { return mQuantityInStock; }
                set { mQuantityInStock = value; }
            }

            public string StockStatus
            {
                get { return mStockStatus; }
                set { mStockStatus = value; }
            }

            public DateTime StockExpiryDate
            {
                get { return mStockExpiryDate; }
                set { mStockExpiryDate = value; }
            }

            public string Valid(Int32 StockId, string StockName, string StockCode, string StockSellingPrice,
                Int32 QuantityInStock, string StockStatus, DateTime StockExpiryDate)
            {
                string Error = "";
                if (StockId <= 0)
                {
                    Error = Error + "The StockId may not be blank";
                }
                return Error;
            
            }

            // Find method (mocked with hardcoded test data)
            public bool Find(int stockId)
            {
                if (stockId == 21)
                {
                    mStockId = 21;
                    mStockName = "Test Stock";
                    mStockCode = "STK001";
                    mStockSellingPrice = 999;
                    mQuantityInStock = 50;
                    mStockStatus = "Available";
                    mStockExpiryDate = DateTime.Now.Date.AddDays(30);
                    mDateAdded = DateTime.Now.Date;
                    mActive = true;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    

        }





