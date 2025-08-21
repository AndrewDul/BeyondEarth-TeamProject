using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        // Change this if your seed row uses a different ID
        private const int ExistingId = 1;

        // good test data for validation
        string StockName = "TestName";
        string SupplierName = "TestSupplier";
        string StockSellingPrice = "100";
        string StockQuantity = "10";

        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.StockId = TestData;
            Assert.AreEqual(TestData, aStock.StockId);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            clsStock aStock = new clsStock();
            string TestData = "Phone";
            aStock.StockName = TestData;
            Assert.AreEqual(TestData, aStock.StockName);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsStock aStock = new clsStock();
            string TestData = "Apple";
            aStock.SupplierName = TestData;
            Assert.AreEqual(TestData, aStock.SupplierName);
        }

        [TestMethod]
        public void StockSellingPricePropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 100;
            aStock.StockSellingPrice = TestData;
            Assert.AreEqual(TestData, aStock.StockSellingPrice);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 10;
            aStock.StockQuantity = TestData;
            Assert.AreEqual(TestData, aStock.StockQuantity);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock aStock = new clsStock();
            Boolean TestData = true;
            aStock.Active = TestData;
            Assert.AreEqual(TestData, aStock.Active);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found, $"Find({ExistingId}) returned false.");
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found);
            Assert.AreEqual(ExistingId, aStock.StockId);
        }

        [TestMethod]
        public void TestStockNameFound()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found);
            Assert.AreEqual("FoundItem", aStock.StockName);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found);
            Assert.AreEqual("foundsupplier", aStock.SupplierName);
        }

        [TestMethod]
        public void TestStockSellingPriceFound()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found);
            Assert.AreEqual(100, aStock.StockSellingPrice);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found);
            Assert.AreEqual(10, aStock.StockQuantity);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsStock aStock = new clsStock();
            bool found = aStock.Find(ExistingId);
            Assert.IsTrue(found);
            Assert.AreEqual(true, aStock.Active);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }

        // ---- StockName boundaries ----
        [TestMethod]
        public void StockNameMinLessOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid("", SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void StockNameMin()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid("a", SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void StockNameMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid("aa", SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void StockNameMid()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid("abcdefghij", SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void StockNameMaxLessOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(new string('a', 49), SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void StockNameMax()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(new string('a', 50), SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(new string('a', 51), SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void StockNameExtremeMax()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(new string('a', 500), SupplierName, StockSellingPrice, StockQuantity);
            Assert.AreNotEqual("", Error);
        }

        // ---- SupplierName boundaries ----
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, "", StockSellingPrice, StockQuantity);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, "a", StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, "aa", StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, new string('a', 25), StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, new string('a', 49), StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, new string('a', 50), StockSellingPrice, StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, new string('a', 51), StockSellingPrice, StockQuantity);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, new string('a', 500), StockSellingPrice, StockQuantity);
            Assert.AreNotEqual("", Error);
        }

        // ---- Price boundaries ----
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, "0", StockQuantity);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void PriceMin()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, "1", StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, "2", StockQuantity);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void PriceNegative()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, "-5", StockQuantity);
            Assert.AreNotEqual("", Error);
        }

        // ---- Quantity boundaries ----
        [TestMethod]
        public void QuantityNegative()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, StockSellingPrice, "-1");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void QuantityMin()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, StockSellingPrice, "0");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string Error = aStock.Valid(StockName, SupplierName, StockSellingPrice, "1");
            Assert.AreEqual("", Error);
        }
    }
}
