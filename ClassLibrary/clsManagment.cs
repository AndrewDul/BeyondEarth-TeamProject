using System;

namespace ClassLibrary
{
    public class clsManagment
    {
        // Private data members
        private Int32 mCustomerId;
        private string mFirstName;
        private string mLastName;
        private string mEmailAddress;
        private string mPostCode;
        private string mPhoneNumber;
        private bool mActive;
        private DateTime mDateAdded;

        // Public properties
        public bool Active
        {
            get { return mActive; }
            set { mActive = value; }
        }
        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }
        public Int32 CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }
        public string PostCode
        {
            get { return mPostCode; }
            set { mPostCode = value; }
        }
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }
        public string EmailAddress
        {
            get { return mEmailAddress; }
            set { mEmailAddress = value; }
        }

        /***** FIND METHOD ******/
        public bool Find(int CustomerId)
        {
            mCustomerId = 10;
            mFirstName = "Will";
            mLastName = "Mike";
            mEmailAddress = "Mike@gmail.com";
            mPostCode = "NG1 7TW";
            mPhoneNumber = "0004";
            mDateAdded = Convert.ToDateTime(DateTime.Now);
            mActive = true;

            //return false indicating there is a problem
            return false;
            
        }

        public string Valid(string firstName, string lastName, string emailAddress, string phoneNumber, string dateAdded)
        {
            return "";
        }
    }
}
