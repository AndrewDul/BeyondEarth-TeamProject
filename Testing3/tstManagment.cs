using System;
using System.IO;
using System.Net.Mail;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstManagment
    {

        //GOOD TEST DATA
        string FirstName = "Will";
        string LastName = "Mike";
        string EmailAddress = "Will@gmail.com";
        string PhoneNumber = "0004";
        string DateAdded = DateTime.Now.ToShortDateString();




        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsManagment AnAddress = new clsManagment();
            //test to see that it exists.
            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //Create an instance of the class we want to create
            clsManagment AnAddress = new clsManagment();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            AnAddress.Active = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnAddress.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            DateTime TestData = DateTime.Now.Date; // Assign today's date
            //assign the data to the property
            AnManagement.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.DateAdded, TestData);
        }


        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            int TestData = 123; // Example integer ID
            //assign the data to the property
            AnManagement.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.CustomerId, TestData);
        }


        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "Will";
            //assign the data to the property
            AnManagement.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.FirstName, TestData);
        }


        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "Mike";
            //assign the data to the property
            AnManagement.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.LastName, TestData);
        }


        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "john.doe@example.com";
            //assign the data to the property
            AnManagement.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.EmailAddress, TestData);
        }



        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "LE1 1AA"; // Example UK postcode
            //assign the data to the property
            AnManagement.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.PostCode, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "0116 123 4567"; // Example UK phone number
            //assign the data to the property
            AnManagement.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.PhoneNumber, TestData);
        }

        public class FindMethod
        {
            [TestMethod]
            public void FindMethodOK()
            {
                //Create an instance of the clas we want to create
                clsManagment AnManagment = new clsManagment();
                //create a Boolean variable to store reults of the validation
                Boolean Found = false;
                //create some test data to use with the method
                Int32 CustomerId = 10;
                //Invoke the method
                Found = AnManagment.Find(CustomerId);
                //test to see if the result is true
                Assert.IsTrue(Found);
            }
        }




        [TestMethod]

        public void ValidMethodOK()
        {

            //create an instance of the class we want to create
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PhoneNumber, DateAdded);

            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void TestCustomerIdProprtyFound()
        {
            //Crete an instance of class we ant to create
            clsManagment AnManagment = new clsManagment();
            //cretae boolean variable to store result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK
            Boolean OK = true;
            // create some test data to use with method
            Int32 CustomerId = 10;
            //Invoke the method
            Found = AnManagment.Find(CustomerId);
            //check the address ID
            if (AnManagment.CustomerId != 10)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create 
            clsManagment AnManagement = new clsManagment();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 10;
            //invoke the method
            Found = AnManagement.Find(CustomerId);
            //check the dateAdded property
            if (AnManagement.DateAdded != Convert.ToDateTime(DateTime.Now))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsManagment AnManagement = new clsManagment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 10;
            Found = AnManagement.Find(CustomerId);
            if (AnManagement.FirstName != "Will")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsManagment AnManagement = new clsManagment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 10;
            Found = AnManagement.Find(CustomerId);
            if (AnManagement.LastName != "Mike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsManagment AnManagement = new clsManagment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 10;
            Found = AnManagement.Find(CustomerId);
            if (AnManagement.EmailAddress != "Mike@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            clsManagment AnManagement = new clsManagment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 10;
            Found = AnManagement.Find(CustomerId);
            if (AnManagement.PostCode != "NG1 7TW")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsManagment AnManagement = new clsManagment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 10;
            Found = AnManagement.Find(CustomerId);
            if (AnManagement.PhoneNumber != "0004")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}
