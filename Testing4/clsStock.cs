using System;
using System.Runtime.Remoting.Messaging;

namespace Testing4
{
    internal class clsStock
    {
        public clsStock()
        {
        }

        public int StockSellingPrice { get; internal set; }
        public int? QuantityInStock { get; internal set; }
        public string StockStatus { get; internal set; }
        public DateTime StockExpiryDate { get; internal set; }
        public string StockName { get; internal set; }
        public string StockCode { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public bool Active { get; internal set; }

       
internal string Valid(int stockId, string stockName, string stockCode, int stockSellingPrice, int quantityInStock, string stockStatus, DateTime stockExpiryDate)
        {
            throw new NotImplementedException();
        }

        internal string Valid(int stockId, string stockName, int stockSellingPrice, int quantityInStock, string stockStatus, DateTime stockExpiryDate)
        {
            throw new NotImplementedException();
        }
    }
    }
