using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstManagment
    {
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
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "Amer";
            //assign the data to the property
            AnManagement.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManagement.FirstName, TestData);
        }


        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsManagment AnManagement = new clsManagment();
            //create some test data
            string TestData = "Bamazrua";
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
        public void PostCodePropertyOK()
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


    }
}
