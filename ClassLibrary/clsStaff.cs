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
            private string _fullName;
            private string _email;
            private string _department;
            private DateTime _hireDate;
            private bool _isActive;

            // Public properties (accessors)
            public int StaffID
            {
                get { return _staffID; }
                set { _staffID = value; }
            }

            public string FullName
            {
                get { return _fullName; }
                set { _fullName = value; }
            }

            public string Email
            {
                get { return _email; }
                set { _email = value; }
            }

            public string Department
            {
                get { return _department; }
                set { _department = value; }
            }

            public DateTime HireDate
            {
                get { return _hireDate; }
                set { _hireDate = value; }
            }

            public bool IsActive
            {
                get { return _isActive; }
                set { _isActive = value; }
            }

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



