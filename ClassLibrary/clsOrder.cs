using System; // Gives access to basic system types like Int32, DateTime, etc.

namespace ClassLibrary // Declares the namespace for class grouping
{
    public class clsOrder // Public class that represents an Order
    {
        // Private data members
        private Int32 mOrderID; // Stores the unique order ID
        private Int32 mCustomerID; // Stores the customer ID associated with the order
        private Int32 mProductID; // Stores the product ID associated with the order
        private DateTime mOrderDate; // Stores the date the order was placed
        private decimal mTotalPrice; // Stores the total price of the order
        private string mOrderStatus; // Stores the status of the order (e.g. Pending, Approved)
        private bool mIsCancelled; // Stores whether the order has been cancelled

        // Public properties (getters and setters)

        public int OrderID
        {
            get { return mOrderID; } // Returns the OrderID value
            set { mOrderID = value; } // Sets the OrderID value
        }

        public int CustomerID
        {
            get { return mCustomerID; } // Returns the CustomerID value
            set { mCustomerID = value; } // Sets the CustomerID value
        }

        public int ProductID
        {
            get { return mProductID; } // Returns the ProductID value
            set { mProductID = value; } // Sets the ProductID value
        }

        public DateTime OrderDate
        {
            get { return mOrderDate; } // Returns the OrderDate value
            set { mOrderDate = value; } // Sets the OrderDate value
        }

        public decimal TotalPrice
        {
            get { return mTotalPrice; } // Returns the TotalPrice value
            set { mTotalPrice = value; } // Sets the TotalPrice value
        }

        public string OrderStatus
        {
            get { return mOrderStatus; } // Returns the OrderStatus value
            set { mOrderStatus = value; } // Sets the OrderStatus value
        }

        public bool IsCancelled
        {
            get { return mIsCancelled; } // Returns the IsCancelled value (true/false)
            set { mIsCancelled = value; } // Sets the IsCancelled value
        }

        // FIND METHOD
        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mIsCancelled = Convert.ToBoolean(DB.DataTable.Rows[0]["IsCancelled"]);
                return true;
            }
            else
            {
                return false;
            }
        }


        // Valid METHOD
        public string Valid(string customerID, string productID, string orderDate, string totalPrice, string orderStatus)
        {
            string Error = "";

            // === CustomerID ===
            try
            {
                int custID = Convert.ToInt32(customerID);
                if (custID <= 0)
                {
                    Error += "Customer ID must be greater than zero: ";
                }
                if (custID > 999999)
                {
                    Error += "Customer ID must not exceed 999999: ";
                }
            }
            catch
            {
                Error += "Customer ID is not a valid integer: ";
            }


            // === ProductID ===
            try
            {
                int prodID = Convert.ToInt32(productID);
                if (prodID <= 0)
                {
                    Error += "Product ID must be greater than zero: ";
                }
                if (prodID > 999999)
                {
                    Error += "Product ID must not exceed 999999: ";
                }
            }
            catch
            {
                Error += "Product ID is not a valid integer: ";
            }


            // === OrderDate ===
            try
            {
                DateTime DateTemp = Convert.ToDateTime(orderDate);
                DateTime Today = DateTime.Now.Date;

                // Optional: strict boundary e.g. no earlier than 01/01/2000
                DateTime MinDate = new DateTime(2000, 1, 1);
                if (DateTemp < MinDate)
                {
                    Error += "Order Date cannot be earlier than 01/01/2000: ";
                }

                if (DateTemp < Today)
                {
                    Error += "Order Date cannot be in the past: ";
                }
                if (DateTemp > Today)
                {
                    Error += "Order Date cannot be in the future: ";
                }
            }
            catch
            {
                Error += "Order Date is not a valid date: ";
            }
            // === TotalPrice ===
            try
            {
                decimal price = Convert.ToDecimal(totalPrice);
                if (price < 0)
                {
                    Error += "Total Price cannot be negative: ";
                }
                if (price > 10000)
                {
                    Error += "Total Price exceeds the maximum allowed: ";
                }
            }
            catch
            {
                Error += "Total Price is not a valid number: ";
            }

            // === OrderStatus ===
            if (orderStatus.Length == 0)
            {
                Error += "Order Status may not be blank: ";
            }
            if (orderStatus.Length > 20)
            {
                Error += "Order Status must be less than or equal to 20 characters: ";
            }

            return Error;
        }

    }
}
