using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class FindMethod
    {
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the clas we want to create
            clsManagment AnManagment = new clsManagment();
            //create a Boolean variable to store reults of the validation
            Boolean Found =false;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //Invoke the method
            Found = AnManagment.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
    }
}
