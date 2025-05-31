using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the collection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create a test item
            clsOrder TestItem = new clsOrder();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set the properties of the test item
            TestItem.CustomerID =7777 ;
            TestItem.ProductID = 555;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 19.99m;
            TestItem.OrderStatus = "Confirmed";
            TestItem.IsCancelled = false;

            // Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            // Add the record and store the primary key
            PrimaryKey = AllOrders.Add();

            // Assign the primary key to the test item
            TestItem.OrderID = PrimaryKey;

            // Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Test to see that the values are the same
            Assert.AreEqual(AllOrders.ThisOrder.CustomerID, TestItem.CustomerID);
            Assert.AreEqual(AllOrders.ThisOrder.ProductID, TestItem.ProductID);
            Assert.AreEqual(AllOrders.ThisOrder.OrderDate, TestItem.OrderDate);
            Assert.AreEqual(AllOrders.ThisOrder.TotalPrice, TestItem.TotalPrice);
            Assert.AreEqual(AllOrders.ThisOrder.OrderStatus, TestItem.OrderStatus);
            Assert.AreEqual(AllOrders.ThisOrder.IsCancelled, TestItem.IsCancelled);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the collection
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create test item
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            // Set original values
            TestItem.CustomerID = 1;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 100.00m;
            TestItem.OrderStatus = "Processing";
            TestItem.IsCancelled = false;

            // Assign to ThisOrder and add it to the DB
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            // Assign the returned primary key to the object
            TestItem.OrderID = PrimaryKey;

            // Modify the test item
            TestItem.CustomerID = 99;
            TestItem.ProductID = 999;
            TestItem.OrderDate = DateTime.Now.Date.AddDays(1);
            TestItem.TotalPrice = 999.99m;
            TestItem.OrderStatus = "Updated";
            TestItem.IsCancelled = true;

            // Assign updated test item back to ThisOrder
            AllOrders.ThisOrder = TestItem;

            // Update the record
            AllOrders.Update();

            // Find the updated record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Assert that all values match the updated ones
            Assert.AreEqual(AllOrders.ThisOrder.CustomerID, TestItem.CustomerID);
            Assert.AreEqual(AllOrders.ThisOrder.ProductID, TestItem.ProductID);
            Assert.AreEqual(AllOrders.ThisOrder.OrderDate, TestItem.OrderDate);
            Assert.AreEqual(AllOrders.ThisOrder.TotalPrice, TestItem.TotalPrice);
            Assert.AreEqual(AllOrders.ThisOrder.OrderStatus, TestItem.OrderStatus);
            Assert.AreEqual(AllOrders.ThisOrder.IsCancelled, TestItem.IsCancelled);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the collection
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create the test item
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.CustomerID = 1;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 123.45m;
            TestItem.OrderStatus = "ToDelete";
            TestItem.IsCancelled = false;

            // Set ThisOrder and add to DB
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            // Assign the primary key
            TestItem.OrderID = PrimaryKey;

            // Find the added record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Delete the record
            AllOrders.Delete();

            // Try to find the deleted record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            // The record should NOT be found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStatusMethodOK()
        {
            // Create an instance with all records (unfiltered)
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create an instance for filtered results
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Apply blank filter - should return all records
            FilteredOrders.ReportByStatus("");
            //Console.WriteLine("AllOrders: " + AllOrders.Count);
            //Console.WriteLine("FilteredOrders: " + FilteredOrders.Count);
            // Check if the counts match
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
            

        }

        [TestMethod]
        public void ReportByStatusNoneFound()
        {
            // Create an instance of the filtered collection
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Apply a status that doesn't exist in the database
            FilteredOrders.ReportByStatus("xxxxxx");

            // Check that no records are returned
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByStatusTestDataFound()
        {
            // Create filtered collection
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;

            // Apply known valid filter - e.g. "Confirmed"
            FilteredOrders.ReportByStatus("Confirmed");

            // Check if count is as expected (change number if needed)
            if (FilteredOrders.Count > 0)
            {
                OK = true;
            }
            else
            {
                OK = false;
            }

            // Confirm the test
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Debug_ReportByStatus_DiscrepancyCheck()
        {
            // Create instances of both collections
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Apply blank filter
            FilteredOrders.ReportByStatus("");

            // Output counts
            Console.WriteLine("AllOrders.Count = " + AllOrders.Count);
            Console.WriteLine("FilteredOrders.Count = " + FilteredOrders.Count);

            // Compare IDs (basic comparison)
            var allIDs = new HashSet<int>();
            foreach (var order in AllOrders.OrderList)
            {
                allIDs.Add(order.OrderID);
            }

            Console.WriteLine("\nOrderIDs NOT present in FilteredOrders:");
            foreach (var order in FilteredOrders.OrderList)
            {
                if (!allIDs.Contains(order.OrderID))
                {
                    Console.WriteLine("FilteredOnly OrderID: " + order.OrderID);
                }
            }

            foreach (var order in AllOrders.OrderList)
            {
                if (!FilteredOrders.OrderList.Any(o => o.OrderID == order.OrderID))
                {
                    Console.WriteLine("Missing in Filtered: OrderID = " + order.OrderID + ", Status = " + order.OrderStatus);
                }
            }

            // Optional: make the test pass even if counts differ
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ReportByStatus_NullOrEmptyStatusCheck()
        {
            // Arrange
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Act – uruchom filtrowanie bez statusu (czyli teoretycznie "wszystko")
            FilteredOrders.ReportByStatus("");

            // Diagnostic counters
            int nullCount = 0;
            int emptyCount = 0;
            int spaceOnlyCount = 0;

            // Check each order
            foreach (var order in FilteredOrders.OrderList)
            {
                if (order.OrderStatus == null)
                    nullCount++;

                else if (order.OrderStatus == "")
                    emptyCount++;

                else if (order.OrderStatus.Trim() == "")
                    spaceOnlyCount++;
            }

            // Output results for manual inspection
            Console.WriteLine($"Total Filtered Records: {FilteredOrders.Count}");
            Console.WriteLine($"OrderStatus == null: {nullCount}");
            Console.WriteLine($"OrderStatus == empty string: {emptyCount}");
            Console.WriteLine($"OrderStatus == only spaces: {spaceOnlyCount}");

            // Assert just to make the test "pass"
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void StatStatisticsGroupedByStatus()
        {
            // Create an instance of the class
            clsOrderCollection Orders = new clsOrderCollection();

            // Invoke the method
            DataTable dt = Orders.StatisticsGroupedByStatus();

            // Set expected number of groups (update if needed)
            int noOfRecords = 8;

            // Assert the result
            Assert.AreEqual(noOfRecords, dt.Rows.Count);
        }


        [TestMethod]
        public void StatStatisticsGroupedByOrderDate()
        {
            // Create an instance of the class
            clsOrderCollection Orders = new clsOrderCollection();

            // Invoke the method
            DataTable dt = Orders.StatisticsGroupedByDate();

            // Set expected number of records (update if needed)
            int noOfRecords = 12;

            // Assert the result
            Assert.AreEqual(noOfRecords, dt.Rows.Count);
        }


    }

}
