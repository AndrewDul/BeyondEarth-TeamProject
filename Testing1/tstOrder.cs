using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the valid method
        int OrderID = 1;
        int CustomerID = 1;
        int ProductID = 1;
        string OrderDate = DateTime.Now.ToShortDateString();
        decimal TotalPrice = 99.99m;
        string OrderStatus = "Pending";
       // bool IsCancelled = true;


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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // create a Boolean variable to store the result of the search
            Boolean Found = false;

            // create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 OrderID = 7;

            // invoke the method
            Found = AnOrder.Find(OrderID);

            // check the OrderID property
            if (AnOrder.OrderID != 7)
            {
                OK = false;
            }

            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.ProductID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("2025-05-18"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalPrice != 99.99m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderStatus != "Pending")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsCancelledFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            bool OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.IsCancelled != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }   



    }

}
