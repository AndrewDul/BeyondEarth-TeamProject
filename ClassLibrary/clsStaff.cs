using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
    {
        public class clsStaff
        {
            // Private fields
            private int _staffID;
            private string _FullName;
            private string _Email;
            private string _Department;
            private DateTime _HireDate;
            private bool _IsActive;
        private string _Position;

        public clsStaff(string position)
        {
            _Position = position;
        }

        // Public properties (accessors)
        public int StaffID
            {
                get { return _staffID; }
                set { _staffID = value; }
            }

        public object StaffId { get; set; }

        public string FullName
            {
                get { return _FullName; }
                set { _FullName = value; }
            }

            public string Email
            {
                get { return _Email; }
                set { _Email = value; }
            }

            public string Department
            {
                get { return _Department; }
                set { _Department = value; }
            }

            public DateTime HireDate
            {
                get { return _HireDate; }
                set { _HireDate = value; }
            }

            public bool IsActive
            {
                get { return _IsActive; }
                set { _IsActive = value; }
            }

        public string Position { get; set; }

        // Validation method
        public string Valid(string fullName, string email, string department)
            {
                string error = "";

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    error += "Full Name cannot be blank.\n";
                }

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                {
                    error += "Email is invalid.\n";
                }

                if (string.IsNullOrWhiteSpace(department))
                {
                    error += "Department cannot be blank.\n";
                }

                return error;
            }
        }
    }



