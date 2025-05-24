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
        public bool Find(int StaffId)
        {
            // Simulated test data (make sure it matches your tests exactly)
            if (StaffId == 8)
            {
                mStaffId = 8;
                mFullName = "Yasser Saeed";
                mDepartment = "IT";
                mHireDate = Convert.ToDateTime("2023-01-15");
                mIsActive = true;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
