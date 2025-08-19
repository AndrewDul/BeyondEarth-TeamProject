using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clStock AStock = new clStock();

            // Test to see that it exists
            Assert.IsNotNull(AStock);
        }
    }
}
