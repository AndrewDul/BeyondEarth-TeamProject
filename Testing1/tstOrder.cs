using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsOrder
            clsOrder AnOrder = new clsOrder();
            // Test that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 101;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 202;
            AnOrder.ProductID = TestData;
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            decimal TestData = 99.99m;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Pending";
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void IsCancelledPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;
            AnOrder.IsCancelled = TestData;
            Assert.AreEqual(AnOrder.IsCancelled, TestData);
        }
    }

}
