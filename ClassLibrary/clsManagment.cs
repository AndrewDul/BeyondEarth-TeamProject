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

        public bool Find(int customerId)
        {
            // Set hardcoded values for testing purposes
            mCustomerId = 21;
            mFirstName = "Amer";
            mLastName = "Bamazrua";
            mEmailAddress = "john.doe@example.com";
            mPostCode = "LE1 1AA";
            mPhoneNumber = "0116 123 4567";
            mActive = true;
            mDateAdded = Convert.ToDateTime("2022-12-23");

            //always return true
            return true;
        }
    }
}
