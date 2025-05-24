using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAddress AStaff = new clsAddress();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsAddress AStaff = new clsAddress();
            int TestData = 8;
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsAddress AStaff = new clsAddress();
            string TestData = "Yasser Saeed";
            AStaff.FullName = TestData;
            Assert.AreEqual(AStaff.FullName, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsAddress AStaff = new clsAddress();
            string TestData = "IT";
            AStaff.Department = TestData;
            Assert.AreEqual(AStaff.Department, TestData);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            clsAddress AStaff = new clsAddress();
            DateTime TestData = DateTime.Now.Date;
            AStaff.HireDate = TestData;
            Assert.AreEqual(AStaff.HireDate, TestData);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            clsAddress AStaff = new clsAddress();
            bool TestData = true;
            AStaff.IsActive = TestData;
            Assert.AreEqual(AStaff.IsActive, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsAddress AStaff = new clsAddress();
            bool Found = false;
            int StaffId = 8;
            Found = AStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsAddress AStaff = new clsAddress();
            bool Found = AStaff.Find(8);
            bool OK = true;
            if (AStaff.StaffId != 8) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsAddress AStaff = new clsAddress();
            bool Found = AStaff.Find(8);
            bool OK = true;
            if (AStaff.FullName != "Yasser Saeed") OK = false;
            Assert.IsTrue(OK);
        }

        

        [TestMethod]
        public void TestDepartmentFound()
        {
            clsAddress AStaff = new clsAddress();
            bool Found = AStaff.Find(8);
            bool OK = true;
            if (AStaff.Department != "IT") OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateFound()
        {
            clsAddress AStaff = new clsAddress();
            bool Found = AStaff.Find(8);
            bool OK = true;
            if (AStaff.HireDate != Convert.ToDateTime("2023-01-15")) OK = false;
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            clsAddress AStaff = new clsAddress();
            bool Found = AStaff.Find(8);
            bool OK = true;
            if (AStaff.IsActive != true) OK = false;
            Assert.IsTrue(OK);
        }
    }
}
