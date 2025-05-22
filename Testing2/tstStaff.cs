using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

    namespace Testing
    {
        [TestClass]
        public class tstStaff
        {
            [TestMethod]
            public void InstanceOK()
            {
                clsStaff staff = new clsStaff();
                Assert.IsNotNull(staff);
            }

            [TestMethod]
            public void StaffIDPropertyOK()
            {
                clsStaff staff = new clsStaff();
                int testData = 1;
                staff.StaffID = testData;
                Assert.AreEqual(staff.StaffID, testData);
            }

            [TestMethod]
            public void FullNamePropertyOK()
            {
                clsStaff staff = new clsStaff();
                string testData = "Ali Al-Qahtani";
                staff.FullName = testData;
                Assert.AreEqual(staff.FullName, testData);
            }

            [TestMethod]
            public void EmailPropertyOK()
            {
                clsStaff staff = new clsStaff();
                string testData = "ali@example.com";
                staff.Email = testData;
                Assert.AreEqual(staff.Email, testData);
            }

            [TestMethod]
            public void DepartmentPropertyOK()
            {
                clsStaff staff = new clsStaff();
                string testData = "IT Department";
                staff.Department = testData;
                Assert.AreEqual(staff.Department, testData);
            }

            [TestMethod]
            public void HireDatePropertyOK()
            {
                clsStaff staff = new clsStaff();
                DateTime testData = DateTime.Now.Date;
                staff.HireDate = testData;
                Assert.AreEqual(staff.HireDate, testData);
            }

            [TestMethod]
            public void IsActivePropertyOK()
            {
                clsStaff staff = new clsStaff();
                bool testData = true;
                staff.IsActive = testData;
                Assert.AreEqual(staff.IsActive, testData);
            }
        }

        internal class clsStaff
        {
            public bool IsActive { get; internal set; }
            public DateTime HireDate { get; internal set; }
            public string Department { get; internal set; }
            public string Email { get; internal set; }
            public string FullName { get; internal set; }
            public int StaffID { get; internal set; }
        }
    }



