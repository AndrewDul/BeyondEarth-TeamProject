using System;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary;
using ClassLibrary.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {

        Int32 StockId = 13;
        string StockName = "abc";
        string StockCode = "C30";
        Int32 StockSellingPrice = 230;
        Int32 QuantityInStock = 12;
        string StockStatus = "In Stock";
        DateTime StockExpiryDate = new DateTime (2025, 01, 30);
       



        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();


            string Error = "";

            Error = AStock.Valid(StockId, StockName, StockSellingPrice, QuantityInStock, StockStatus, StockExpiryDate);


            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIdMinLessOne()
        {
            // Create an instance of the class we want to test
            clsStock AStock = new clsStock();

            // String variable to store any error message
            string Error = "";
            Int32 StockId = 32;
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus,
                StockExpiryDate );
            Assert.AreNotEqual(Error, "");
        }




        /// 
        /// Stock Name Tests
        




        [TestMethod]
        public void StockNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "a"; //this should be ok
                                    //invoke the method
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockName = "aa"; //this should be ok
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockName = "aaaaa"; //this should be ok
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockName = "aaaaaa"; //this should be ok
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockName = "aaa"; //this should be ok
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }






        /// Stock Id Tests





        [TestMethod]
        public void StockIdMin()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockId = 1; // this should be ok (minimum valid ID)
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockId = 2; // this should be ok
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMaxLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockId = 9998; // example max limit minus one
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockId = 9999; // example max limit
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockId = 5000; // example middle value
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }







        /// <summary>
        /// /
        /// </summary>




        [TestMethod]
        public void StockCodeMin()
        {
            // Create an instance of the class we want to test
            clsStock AStock = new clsStock();

            // String variable to store any error message
            string Error = "";

            // Create some test data to pass to the method
            string StockCode = "A"; // This should be valid (minimum length is 1)

            // Invoke the method
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCodeMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockCode = "AB"; // This should be valid
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCodeMaxLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockCode = new string('A', 9); // One less than the maximum length
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCodeMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockCode = new string('A', 10); // Maximum valid length
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCodeMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockCode = new string('A', 5); // Midpoint length
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }






        /// <summary>
        /// /
        /// </summary>
        /// 




        [TestMethod]
        public void StockSellingPriceMin()
        {
            // Create an instance of the class we want to test
            clsStock AStock = new clsStock();

            // String variable to store any error message
            string Error = "";

            // Create some test data to pass to the method
            int StockSellingPrice = 1; // This should be valid (minimum value)

            // Invoke the method
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockSellingPriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockSellingPrice = 2; // This should be valid
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockSellingPriceMaxLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockSellingPrice = 999999; // One less than the maximum value
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockSellingPriceMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockSellingPrice = 1000000; // Maximum valid value
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockSellingPriceMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            int StockSellingPrice = 500000; // Midpoint value
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }






        /// <summary>
        /// //
        /// </summary>






        [TestMethod]
        public void StockStatusMin()
        {
            // Create an instance of the class we want to test
            clsStock AStock = new clsStock();

            // String variable to store any error message
            string Error = "";

            // Create some test data to pass to the method
            string StockStatus = "A"; // This should be valid (minimum length is 1)

            // Invoke the method
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockStatusMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockStatus = "AB"; // This should be valid
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockStatusMaxLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockStatus = new string('A', 9); // One less than the maximum length
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockStatusMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockStatus = new string('A', 10); // Maximum valid length
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockStatusMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            string StockStatus = new string('A', 5); // Midpoint length
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }







        /// <summary>
        /// /
        /// </summary>





        [TestMethod]
        public void StockExpiryDateMin()
        {
            // Create an instance of the class we want to test
            clsStock AStock = new clsStock();

            // String variable to store any error message
            string Error = "";

            // Create some test data to pass to the method
            DateTime StockExpiryDate = DateTime.Now.AddDays(1); // This should be valid (not in the past)

            // Invoke the method
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockExpiryDateMinPlusOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime StockExpiryDate = DateTime.Now.AddDays(2); // This should be valid
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockExpiryDateMaxLessOne()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime StockExpiryDate = DateTime.Now.AddDays(1824); // One less than the maximum length (5 years - 1 day)
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockExpiryDateMax()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime StockExpiryDate = DateTime.Now.AddDays(1825); // Maximum valid length (5 years)
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockExpiryDateMid()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            DateTime StockExpiryDate = DateTime.Now.AddDays(912); // Midpoint length (approximately 2.5 years)
            Error = AStock.Valid(StockId, StockName, StockCode, StockSellingPrice,
                QuantityInStock, StockStatus, StockExpiryDate);
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock AStock = new clsStock();
            bool TestData = true;
            AStock.Active = TestData;
            Assert.AreEqual(TestData, AStock.Active);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(TestData, AStock.DateAdded);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            ClassLibrary.ClassLibrary.clsStock AStock = new ClassLibrary.ClassLibrary.clsStock();
            int TestData = 123;
            AStock.StockId = TestData;
            Assert.AreEqual(TestData, AStock.StockId);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Test Stock";
            AStock.StockName = TestData;
            Assert.AreEqual(TestData, AStock.StockName);
        }

        [TestMethod]
        public void StockCodePropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "STK001";
            AStock.StockCode = TestData;
            Assert.AreEqual(TestData, AStock.StockCode);
        }

        [TestMethod]
        public void StockSellingPricePropertyOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 999;
            AStock.StockSellingPrice = TestData;
            Assert.AreEqual(TestData, AStock.StockSellingPrice);
        }

        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            clsStock AStock = new clsStock();
            int? TestData = 50;
            AStock.QuantityInStock = TestData;
            Assert.AreEqual(TestData, AStock.QuantityInStock);
        }

        [TestMethod]
        public void StockStatusPropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Available";
            AStock.StockStatus = TestData;
            Assert.AreEqual(TestData, AStock.StockStatus);
        }

        [TestMethod]
        public void StockExpiryDatePropertyOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date.AddDays(30);
            AStock.StockExpiryDate = TestData;
            Assert.AreEqual(TestData, AStock.StockExpiryDate);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            ClassLibrary.ClassLibrary.clsStock AStock = new ClassLibrary.ClassLibrary.clsStock();
            bool Found = AStock.Find(21);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            ClassLibrary.ClassLibrary.clsStock AStock = new ClassLibrary.ClassLibrary.clsStock();
            bool Found = AStock.Find(21);
            Assert.IsTrue(Found);
        }
    }
}
