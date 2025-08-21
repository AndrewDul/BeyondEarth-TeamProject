using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            var user = new clsStockUser();
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            var user = new clsStockUser();
            int test = 1;
            user.UserID = test;
            Assert.AreEqual(test, user.UserID);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            var user = new clsStockUser();
            string test = "ahmed";
            user.UserName = test;
            Assert.AreEqual(test, user.UserName);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            var user = new clsStockUser();
            string test = "123456ahmed";
            user.Password = test;
            Assert.AreEqual(test, user.Password);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            var user = new clsStockUser();
            string test = "Stock";
            user.Department = test;
            Assert.AreEqual(test, user.Department);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            var user = new clsStockUser();
            bool found = user.FindUser("Ahmed", "123456ahmed");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void FindUserNamePW()
        {
            var user = new clsStockUser();
            bool found = user.FindUser("Ahmed", "123456ahmed");
            if (user.UserName != "Ahmed" && user.Password != "123456ahmed")
            {
                Assert.Fail("UserName or Password not found.");
            }
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void FindUser_ValidCredentials_PopulatesAllFields()
        {
            var user = new clsStockUser();
            bool found = user.FindUser("ahmed", "123456ahmed");
            Assert.IsTrue(found);
            Assert.AreEqual(1, user.UserID);
            Assert.AreEqual("ahmed", user.UserName, true);
            Assert.AreEqual("123456ahmed", user.Password);
            Assert.AreEqual("Stock", user.Department);
        }

        [TestMethod]
        public void FindUser_UserName_IsCaseInsensitive()
        {
            var user = new clsStockUser();
            bool found = user.FindUser("AHMED", "123456ahmed");
            Assert.IsTrue(found);
            Assert.AreEqual(1, user.UserID);
        }

        [TestMethod]
        public void FindUser_WrongPassword_ReturnsFalse()
        {
            var user = new clsStockUser();
            bool found = user.FindUser("ahmed", "wrongpass");
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void FindUser_UnknownUser_ReturnsFalse()
        {
            var user = new clsStockUser();
            bool found = user.FindUser("no_such_user_xyz", "123456ahmed");
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void FindUser_EmptyInputs_ReturnsFalse()
        {
            var user = new clsStockUser();
            Assert.IsFalse(user.FindUser("", ""));
            Assert.IsFalse(user.FindUser(null, null));
            Assert.IsFalse(user.FindUser(" ", " "));
        }
    }
}
