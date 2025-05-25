using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // Private data member to hold the list of orders
        private List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for thisOrder
        private clsOrder mThisOrder = new clsOrder();




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

            //populate the array with the data from the database
            PopulateArray(DB);


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
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@IsCancelled", mThisOrder.IsCancelled);

            // Execute the query and return the primary key value (OrderID)
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameter for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            // Execute the stored procedure to delete the record
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByStatus(string OrderStatus)
        {
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Send the OrderStatus parameter to the database
            DB.AddParameter("@OrderStatus", OrderStatus);

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByStatus");
            // Populate the array with the data from the database
            PopulateArray(DB);



        }

        public void Update()
        {
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@IsCancelled", mThisOrder.IsCancelled);

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Initialise the index
            Int32 Index = 0;

            // Get the number of records
            Int32 RecordCount = DB.Count;

            // Clear the private list
            mOrderList = new List<clsOrder>();

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank order
                clsOrder AnOrder = new clsOrder();

                // Read in the fields from the current row
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.IsCancelled = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCancelled"]);

                // Add the order to the private list
                mOrderList.Add(AnOrder);

                // Move to the next record
                Index++;
            }
        }

    }
    }
