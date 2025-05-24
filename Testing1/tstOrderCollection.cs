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

       
       
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ProductID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 99.99m;
            TestItem.OrderStatus = "Pending";
            TestItem.IsCancelled = false;

            AllOrders.ThisOrder = TestItem;

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create some test data to assign to the property (a list of clsOrder)
            List<clsOrder> TestList = new List<clsOrder>();

            // Create the test item
            clsOrder TestItem = new clsOrder();

            // Set its properties
            
            TestItem.OrderID = 2;
            TestItem.CustomerID = 123;
            TestItem.ProductID = 456;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 49.99m;
            TestItem.OrderStatus = "Processing";
            TestItem.IsCancelled = false;

            // Add the test item to the test list
            TestList.Add(TestItem);

            // Assign the test list to the collection's property
            AllOrders.OrderList = TestList;

            // Check that the Count property matches the number of items in the test list
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        

    }
}
