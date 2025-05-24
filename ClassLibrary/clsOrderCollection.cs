using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // Private data member to hold the list of orders
        private List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrder
        clsOrder mThisOrder = new clsOrder();




        // Constructor// Constructor for the class
        public clsOrderCollection()
        {
            // Index for the loop
            Int32 Index = 0;

            // Store the number of records
            Int32 RecordCount = 0;

            // Create a connection to the database
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("tblOrder_SelectAll");


            // Get the number of records returned
            RecordCount = DB.Count;

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank order
                clsOrder AnOrder = new clsOrder();

                // Read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.IsCancelled = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCancelled"]);

                // Add the order to the list
                mOrderList.Add(AnOrder);

                // Move to the next record
                Index++;
            }
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

        public clsOrder ThisOrder 
        { 
            get { return mThisOrder; }

            set { mThisOrder = value; }

        }

        public int Add()
        {
            //add a record to the database based on the values of thisOrder
            //set the primary key of the new record
            mThisOrder.OrderID = 2;
            //rerturn the primary key of the new record
            return mThisOrder.OrderID;
        }
    }
}
