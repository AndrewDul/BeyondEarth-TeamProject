using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing4;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.StockId = 21;
            TestItem.StockName = "Phone";
            TestItem.SupplierName = "Apple";
            TestItem.StockSellingPrice = 1000;
            TestItem.StockQuantity = 5;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            TestList.Add(TestItem);
            AllStocks.StockList = TestList;

            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();

            TestItem.StockId = 21;
            TestItem.StockName = "Phone";
            TestItem.SupplierName = "Apple";
            TestItem.StockSellingPrice = 1000;
            TestItem.StockQuantity = 5;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            AllStocks.ThisStock = TestItem;
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.StockId = 21;
            TestItem.StockName = "Phone";
            TestItem.SupplierName = "Apple";
            TestItem.StockSellingPrice = 1000;
            TestItem.StockQuantity = 5;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            TestList.Add(TestItem);
            AllStocks.StockList = TestList;

            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();

            TestItem.StockName = "Phone";
            TestItem.SupplierName = "Apple";
            TestItem.StockSellingPrice = 1000;
            TestItem.StockQuantity = 5;
            TestItem.Active = true;

            AllStocks.ThisStock = TestItem;
            int PrimaryKey = AllStocks.Add();

            TestItem.StockId = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            int PrimaryKey = 0;

            TestItem.StockName = "Phone";
            TestItem.SupplierName = "Apple";
            TestItem.StockSellingPrice = 1000;
            TestItem.StockQuantity = 5;
            TestItem.Active = true;

            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.StockId = PrimaryKey;

            TestItem.StockName = "Laptop";
            TestItem.SupplierName = "Dell";
            TestItem.StockSellingPrice = 2000;
            TestItem.StockQuantity = 3;
            TestItem.Active = false;

            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            int PrimaryKey = 0;

            TestItem.StockName = "Phone";
            TestItem.SupplierName = "Apple";
            TestItem.StockSellingPrice = 1000;
            TestItem.StockQuantity = 5;
            TestItem.Active = true;

            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.StockId = PrimaryKey;

            AllStocks.ThisStock.Find(PrimaryKey);
            AllStocks.Delete();

            bool Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        // ******************* ReportBySupplierName Method ******************* //
        

        [TestMethod]
        public void ReportBySupplierNameMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();

            FilteredStocks.ReportBySupplierName("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }



        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportBySupplierName("NoSuchSupplierXYZ");
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {
            var filtered = new clsStockCollection();
            filtered.ReportBySupplierName("Apple");

            Assert.IsTrue(filtered.Count >= 1, "Expected at least one Apple record.");
            foreach (var s in filtered.StockList)
                Assert.AreEqual("Apple", s.SupplierName, "SupplierName should be Apple.");
        }

    }
}
