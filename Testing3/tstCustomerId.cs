using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomerId
    {
       


        [TestMethod]
        public void TestCustomerIdFound()
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
    }
}
