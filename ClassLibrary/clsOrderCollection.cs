using System;
using System.Collections.Generic;
using System.Data;
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
            // object for data connection
            clsDataConnection DB = new clsDataConnection();

            // execute the stored procedure to select all orders
            DB.Execute("tblOrder_SelectAll");

            // populate the array list with the data table
            PopulateArray(DB);
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

            // trim the status and send it as a parameter
            OrderStatus = OrderStatus.Trim();
            DB.AddParameter("@OrderStatus", OrderStatus);

            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByStatus");

            // populate the array list with the data table
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
        
        private void PopulateArray(clsDataConnection DB)
        {
            // Variable to store the index
            Int32 Index = 0;

            // Variable to store the record count
            Int32 RecordCount = DB.Count;

            // Clear the private list before populating
            mOrderList = new List<clsOrder>();

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank order object
                clsOrder AnOrder = new clsOrder();

                // Read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.IsCancelled = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCancelled"]);

                // Add the record to the private data member
                mOrderList.Add(AnOrder);

                // Point at the next record
                Index++;
            }
        }

        /****** Statistics Grouped by OrderDate METHOD ******/
        public DataTable StatisticsGroupedByDate()
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // execute the stored procedure
            DB.Execute("tblOrder_Count_GroupByDate");

            // return the result table
            return DB.DataTable;
        }

        /****** Statistics Grouped by OrderStatus METHOD ******/
        public DataTable StatisticsGroupedByStatus()
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // execute the stored procedure
            DB.Execute("tblOrder_Count_GroupByStatus");

            // return the result table
            return DB.DataTable;
        }

    }
}
