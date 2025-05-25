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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the CustomerId to search for
            DB.AddParameter("@CustomerId", CustomerId);

            //execute the stored procedure
            DB.Execute("sprc_tblCustomer_FilterByCustomerId");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}
