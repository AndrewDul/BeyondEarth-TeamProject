using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstArchivedStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            Assert.IsNotNull(archivedStock);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            int testData = 1;
            archivedStock.StockId = testData;
            Assert.AreEqual(testData, archivedStock.StockId);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string testData = "Old iPhone 11 (Archive)";
            archivedStock.StockName = testData;
            Assert.AreEqual(testData, archivedStock.StockName);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string testData = "Apple";
            archivedStock.SupplierName = testData;
            Assert.AreEqual(testData, archivedStock.SupplierName);
        }

        [TestMethod]
        public void StockSellingPricePropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            int testData = 399;
            archivedStock.StockSellingPrice = testData;
            Assert.AreEqual(testData, archivedStock.StockSellingPrice);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            int testData = 2;
            archivedStock.StockQuantity = testData;
            Assert.AreEqual(testData, archivedStock.StockQuantity);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            DateTime testData = DateTime.Now.Date;
            archivedStock.DateAdded = testData;
            Assert.AreEqual(testData, archivedStock.DateAdded);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            bool testData = false;
            archivedStock.Active = testData;
            Assert.AreEqual(testData, archivedStock.Active);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            bool found = archivedStock.Find(1); // Your DB has StockId = 1 (Old iPhone 11)
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void FindStockIdTest()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            bool found = archivedStock.Find(1);
            if (found)
            {
                Assert.AreEqual(1, archivedStock.StockId);
                Assert.AreEqual("Old Iphone 11", archivedStock.StockName);
                Assert.AreEqual("Apple", archivedStock.SupplierName);
                Assert.AreEqual(399, archivedStock.StockSellingPrice);
                Assert.AreEqual(2, archivedStock.StockQuantity);
                Assert.IsFalse(archivedStock.Active);
            }
            else
            {
                Assert.Fail("Record not found.");
            }
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string error = archivedStock.Valid("iPad Mini 4 (Archive)", "Apple", "249", "3");
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void StockNameMaxLength()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string stockName = new string('a', 50);
            string error = archivedStock.Valid(stockName, "Apple", "249", "3");
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void StockNameTooLong()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string stockName = new string('a', 51);
            string error = archivedStock.Valid(stockName, "Apple", "249", "3");
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void StockSellingPriceInvalid()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string error = archivedStock.Valid("iPad Mini 4 (Archive)", "Apple", "abc", "3");
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void StockQuantityInvalid()
        {
            clsArchivedStock archivedStock = new clsArchivedStock();
            string error = archivedStock.Valid("iPad Mini 4 (Archive)", "Apple", "249", "xyz");
            Assert.AreNotEqual("", error);
        }
    }
}
