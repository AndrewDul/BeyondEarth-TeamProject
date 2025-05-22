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
        string PostCode = "NG1 7TW";
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



        [TestMethod]

        public void ValidMethodOK()
        {

            //create an instance of the class we want to create
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsManagment AnManagment = new clsManagment();

            string Error = "";

            string FirstName = "";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void FirstNameMin()
        {
            clsManagment AnManagment = new clsManagment();
            string Error = "";
            string FirstName = "W";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstNamePlusOne()
        {
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            string FirstName = "ww";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirsNameMaxLessOne()
        {
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            string FirstName = "wwwwwwww";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMax()
        {
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            string FirstName = "wwwwwwwww";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreEqual(Error, "");

        }


        [TestMethod]

        public void FirstNameMid()
        {
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            string FirstName = "wwww";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsManagment AnManagment = new clsManagment();
            String Error = "";

            string FirstName = "wwwwwwwwww";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string FirstName = "";
            FirstName = FirstName.PadRight(1000, 'w');

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            Assert.AreNotEqual(Error, "");
        }



        //Last Name


        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMin()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "m";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "mm";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "";
            LastName = LastName.PadRight(49, 'm');

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMax()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "";
            LastName = LastName.PadRight(50, 'm');

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNamePlusOne()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMid()
        {

            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string LastName = "";
            LastName = LastName.PadRight(25, 'm');

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressLessOne()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string EmailAddress = "";

            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);


            //Test
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //creste an instance
            clsManagment AnManagment = new clsManagment();

            //String variable for error message
            String Error = "";

            string EmailAddress = "w";

            //Invoke the method
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to see result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //creste an instance
            clsManagment AnManagment = new clsManagment();

            //String variable for error message
            String Error = "";

            string EmailAddress = "ww";

            //Invoke the method
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to see result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //creste an instance
            clsManagment AnManagment = new clsManagment();

            //String variable for error message
            String Error = "";

            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(49, 'w');

            //Invoke the method
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //creste an instance
            clsManagment AnManagment = new clsManagment();

            //String variable for error message
            String Error = "";

            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(50, 'w');

            //Invoke the method
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to see result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressPlusOne()
        {
            //creste an instance
            clsManagment AnManagment = new clsManagment();

            //String variable for error message
            String Error = "";

            string EmailAddress = "";

            //Invoke the method
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to see result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressMid()
        {
            //creste an instance
            clsManagment AnManagment = new clsManagment();

            //String variable for error message
            String Error = "";

            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(25, 'w');

            //Invoke the method
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to see result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMid1()
        {

            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "N";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMinPlusOne1()
        {
            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "NN";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMaxLess1()
        {
            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "NNNNNNNN";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "NNNNNNNNN";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMaxPlus1()
        {
            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "NNNNNNNNN";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store any error message
            String Error = "";

            string PostCode = "NNNN";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test to check if correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLess1()
        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";

            string PhoneNumber = "";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void PhoneNumberMinimum()

        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";

            string PhoneNumber = "0";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMinimumPlus1()
        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";

            string PhoneNumber = "00";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMaxLess1()
        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(19, '0');

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaximum()
        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(20, '0');

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PhoneNumberMaximumPlus1()
        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(21, '0');

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PhoneNumberMidium()
        {
            //create instance of class we want to create
            clsManagment AnManagment = new clsManagment();

            //string variable to store errors message
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(10, '0');

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //Test
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // Arrange
            clsManagment AnManagment = new clsManagment();
            String Error = "";
            DateTime TestDate;
            DateTime testDate = DateTime.Now.Date.AddYears(-100); // 100 years ago
            string DateAdded = testDate.ToString(); // convert to string for validation

            // Act
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            // Assert
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void DateAddedMinLess1()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string DateAdded = TestDate.ToString();

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //teset to see errors message
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateAddedMin()
        {

            clsManagment AnManagment = new clsManagment();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string DateAdded = TestDate.ToString();

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //teset to see errors message
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DateAddedMinPlus1()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string DateAdded = TestDate.ToString();

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //teset to see errors message
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string DateAdded = TestDate.ToString();

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //teset to see errors message
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsManagment AnManagment = new clsManagment();

            String Error = "";

            string DateAdded = "This is not a date! ";

            //Invoke
            Error = AnManagment.Valid(FirstName, LastName, EmailAddress, PostCode, PhoneNumber, DateAdded);

            //teset to see errors message
            Assert.AreNotEqual(Error, "");
        }

    }
}
