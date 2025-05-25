using System;

namespace ClassLibrary
{
    public class clsAddress
    {
        // Private data members
        private int mStaffId;
        private string mFullName;
        private string mDepartment;
        private DateTime mHireDate;
        private bool mIsActive;

        // Public properties
        public int StaffId
        {
            get { return mStaffId; }
            set { mStaffId = value; }
        }

        public string FullName
        {
            get { return mFullName; }
            set { mFullName = value; }
        }

        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        public DateTime HireDate
        {
            get { return mHireDate; }
            set { mHireDate = value; }
        }

        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        // ✅ Valid method to validate user input
        public string Valid(string fullName, string department, string hireDate)
        {
            
            string Error = "";

            
            DateTime DateTemp;

            // Get today's date
            DateTime Today = DateTime.Now.Date;

            // ================================
            // FullName Validation
            // ================================
            if (fullName.Length == 0)
            {
                Error += "The full name may not be blank : ";
            }
            if (fullName.Length > 50)
            {
                Error += "The full name must be less than or equal to 50 characters : ";
            }

            // ================================
            // Department Validation
            // ================================
            if (department.Length == 0)
            {
                Error += "The department may not be blank : ";
            }
            if (department.Length > 30)
            {
                Error += "The department must be less than or equal to 30 characters : ";
            }

            // ================================
            // HireDate Validation
            // ================================
            try
            {
                // Try to convert string to date
                DateTemp = Convert.ToDateTime(hireDate);

                // Check for too far in the past
                if (DateTemp < Today.AddYears(-50))
                {
                    Error += "The hire date cannot be more than 50 years in the past : ";
                }

                // Check for future dates
                if (DateTemp > Today)
                {
                    Error += "The hire date cannot be in the future : ";
                }
            }
            catch
            {
                // If conversion fails
                Error += "The hire date was not a valid date : ";
            }

            // Return the error string (empty if valid)
            return Error;
        }

        // Find Method
        public bool Find(int AddressId)
        {
            // Set the private data members to the test data value
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AddressId", AddressId);
            DB.Execute("sporc_tblAddress_FilterByAddressId");

            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
