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

        public string Valid(string firstName, string lastName, string emailAddress,string postCode, string phoneNumber, string dateAdded)
        {
            String Error = "";
            DateTime DateTemp;


            if (firstName.Length == 0)
            {

                Error = Error + "the firstName may not be blank : ";

            }

            if (firstName.Length > 9)
            {
                Error = Error + "The first name must be less than 9 characters :";
            }

            if (lastName.Length == 0)
            {
                Error = Error + "Last name may not be blank: ";
            }
            if (lastName.Length > 50)
            {
                Error = Error + "The last name must be less than 50 characters :";
            }
            if (emailAddress.Length == 0)
            {
                Error = Error + "The emailAddress may not be blank :";
            }
            if (emailAddress.Length > 50)
            {
                Error = Error + "emailAddress characters may not be more than 50 :";
            }
            if (postCode.Length == 0)
            {
                Error = Error + "postCode may not be blank :";
            }
            if (postCode.Length > 9)
            {
                Error = Error + "postCode characters may not be more than 9 :";
            }
            if (phoneNumber.Length == 0)
            {
                Error = Error + "phoneNumber my not be blank :";
            }
            if (phoneNumber.Length > 20)
            {
                Error = Error + "phoneNumber shouldn't be more than 20 :";
            }
          

            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to DateTemp
                DateTemp = Convert.ToDateTime(dateAdded);



                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record error
                Error = Error + "Date was not valid date";
            }
            //return any error messages
            return Error;
                
        }
    }
}
