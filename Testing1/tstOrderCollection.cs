using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the collection class
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // Create an instance of the collection class
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some data to assig to the property
            //in this case the data is a list of clsOrder objects
            List<clsOrder> TestList = new List<clsOrder>();
            // Add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // Set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ProductID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 10.00m;
            TestItem.OrderStatus = "Pending";
            TestItem.IsCancelled = false;
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllOrders.OrderList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }


    }
}
