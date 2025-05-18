using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Primary Key - Order ID
        public int OrderID { get; set; }

        // Foreign Key to Customer table
        public int CustomerID { get; set; }

        // Foreign Key to Product/Experience table
        public int ProductID { get; set; }

        // Date the order was placed
        public DateTime OrderDate { get; set; }

        // Total price of the order
        public decimal TotalPrice { get; set; }

        // Status of the order, e.g., Pending, Approved
        public string OrderStatus { get; set; }

        // Whether the order has been cancelled
        public bool IsCancelled { get; set; }
    }
}
