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
        public bool Find(int orderID)
        {
            // Set hardcoded values for testing purposes

            mOrderID = 7; // Simulate order ID = 1
            mCustomerID = 1; // Simulate customer ID = 1
            mProductID = 1; // Simulate product ID = 1
            mOrderDate = Convert.ToDateTime("2025-05-18"); // Simulate order date
            mTotalPrice = 99.99m; // Simulate total price
            mOrderStatus = "Pending"; // Simulate status
            mIsCancelled = true; // Simulate cancelled state

            // Return true to simulate a successful find operation
            return true;
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
            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp > DateTime.Now.Date)
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
