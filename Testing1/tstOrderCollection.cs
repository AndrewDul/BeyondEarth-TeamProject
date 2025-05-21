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

        
    }
}
