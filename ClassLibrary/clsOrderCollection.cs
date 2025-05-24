using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList = new List<clsOrder>();

        // Constructor// Constructor for the class
        public clsOrderCollection()
        {
            // Create the first test order
            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 1;
            TestItem.CustomerID = 101;
            TestItem.ProductID = 201;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 9.99m;
            TestItem.OrderStatus = "Pending";
            TestItem.IsCancelled = false;

            // Add the test item to the list
            mOrderList.Add(TestItem);

            // Create another test order
            TestItem = new clsOrder();

            TestItem.OrderID = 2;
            TestItem.CustomerID = 102;
            TestItem.ProductID = 202;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 19.99m;
            TestItem.OrderStatus = "Approved";
            TestItem.IsCancelled = true;

            // Add the second test item to the list
            mOrderList.Add(TestItem);
        }


        public List<clsOrder> OrderList
        {
            get { return mOrderList; }
            set { mOrderList = value; }
        }

        public int Count
        {
            get { return mOrderList.Count; }
            set { }
        }

        public clsOrder ThisOrder { get; set; }


    }
}
