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


        /****** FIND METHOD ******/
        public bool Find(int AddressId)
        {
            // set the private data members to the test data value
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AddressId" , AddressId);
            DB.Execute("sporc_tblAddress_FilterByAddressId");
            if (DB.Count == 1 )
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
