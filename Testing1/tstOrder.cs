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
        string OrderID = "1";
        string CustomerID = "2";
        string ProductID = "3";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalPrice = "99.99";
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
            Error = AnOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /// <summary>
        /// Customer ID
        /// </summary>
        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "-1000000"; // extreme invalid value, too low
                                            // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "0"; // invalid, less than min
                                     // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "1"; // valid minimum value


            // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "2"; // valid minimum value


            // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "2147483647"; // technically valid Int32, but beyond allowed range for user
                                              // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "999998"; // valid, just below max
                                          // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "999999"; // valid, max boundary
                                          // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "1000000"; // invalid, above max
                                           // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "500000"; // valid, mid-range value
                                          // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void CustomerIDInvalidDataType()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string customerID = "abc"; // invalid, non-numeric input
                                       // Act
            error = anOrder.Valid(customerID, ProductID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }



        ///////////////Product////////////

        [TestMethod]
        public void ProductIDExtremeMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "-1000000"; // extreme invalid value, too low
                                           // Act
            error = anOrder.Valid("1", productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void ProductIDMinLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "0"; // invalid, below minimum allowed value
                                    // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ProductIDMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "1"; // valid minimum value
                                    // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "2"; // valid, just above minimum
                                    // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }


        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "999998"; // valid, just below maximum
                                         // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ProductIDMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "999999"; // valid, maximum boundary
                                         // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "1000000"; // invalid, above maximum allowed
                                          // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ProductIDMid()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "500000"; // valid, mid-range value
                                         // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "2147483647"; // technically valid Int32, but beyond acceptable range
                                             // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ProductIDInvalidDataType()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string productID = "xyz"; // invalid, non-numeric input
                                      // Act
            error = anOrder.Valid(CustomerID, productID, OrderDate, TotalPrice, OrderStatus);
            // Assert
            Assert.AreNotEqual("", error);
        }

        ////// OrderDate///////
        ///

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date.AddYears(-100); // 100 years ago
            string orderDate = testDate.ToString(); // convert to string for validation

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date.AddDays(-1); // yesterday
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void OrderDateMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date; // today's date
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date.AddDays(1); // tomorrow
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void OrderDateMid()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date; // mid = today (logical midpoint)
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date.AddYears(100); // 100 years into the future
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void OrderDateMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date; // today's date = max allowed
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void OrderDateMaxPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date.AddDays(1); // tomorrow = beyond max
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void OrderDateMaxLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            DateTime testDate = DateTime.Now.Date.AddDays(-1); // yesterday = just below max
            string orderDate = testDate.ToString();

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void OrderDateInvalidDataType()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderDate = "not-a-date"; // invalid, not a valid date format

            // Act
            error = anOrder.Valid(CustomerID, ProductID, orderDate, TotalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        ///// Total Price//////
        ///

        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "-1000000"; // extreme negative value, invalid

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "-1"; // just below the minimum allowed (0)

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "0"; // minimum allowed value

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "1"; // just above minimum

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "9999"; // just below the maximum allowed

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void TotalPriceMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "10000"; // maximum allowed value

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "10001"; // just above the allowed maximum

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void TotalPriceMid()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "5000"; // mid-range valid value

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void TotalPriceExtremeMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "1000000"; // extreme high value, invalid

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void TotalPriceInvalidDataType()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string totalPrice = "ten pounds"; // invalid, non-numeric input

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, totalPrice, OrderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }


        /// <summary>
        /// /Order Status
        /// </summary>
        /// 


        [TestMethod]
        public void OrderStatusExtremeMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = ""; // empty string, invalid

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = ""; // zero characters, invalid (less than min)

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void OrderStatusMin()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = "A"; // minimum valid length

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = "AB"; // just above minimum length

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = new string('A', 19); // 19 characters

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void OrderStatusMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = new string('A', 20); // 20 characters

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = new string('A', 21); // 21 characters (too long)

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void OrderStatusMid()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = "Processing"; // 10 characters

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = new string('A', 100); // 100 characters (extremely too long)

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void OrderStatusInvalidDataType()
        {
            // Arrange
            clsOrder anOrder = new clsOrder();
            string error;
            string orderStatus = "@#$%^&*()"; // non-alphabetic, potentially invalid input

            // Act
            error = anOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, orderStatus);

            // Assert
            Assert.AreEqual("", error); // or AreNotEqual depending on your validation logic
        }

    }

}
