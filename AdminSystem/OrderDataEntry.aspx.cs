using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the OrderID from the session
        OrderID = Convert.ToInt32(Session["OrderID"]);

        if (!IsPostBack)
        {
            // If this is not a new record, display existing data
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // Capture input values as strings
        
        string CustomerID = txtCustomerID.Text;
        string ProductID = txtProductID.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalPrice = txtTotalPrice.Text;
        string OrderStatus = txtOrderStatus.Text;

        // Variable to store any error message
        string Error = "";

        // Validate the input
        Error = AnOrder.Valid(CustomerID, ProductID, OrderDate, TotalPrice, OrderStatus);

        if (Error == "")
        {
            // No errors – assign data
            AnOrder.OrderID = OrderID; // ← DON'T MISS THIS BIT!!!
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.ProductID = Convert.ToInt32(ProductID);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalPrice = Convert.ToDecimal(TotalPrice);
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.IsCancelled = chkIsCancelled.Checked;

            // Create the collection instance
            clsOrderCollection OrderList = new clsOrderCollection();

            // ADD or UPDATE?
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID); // (optional but recommended)
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }

            // Go back to list
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            // Show error
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderID;
        //ctreate a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key value entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);


        //if the record was found, display the data in the form
        
        if (Found)
        {
            //display the data for this record
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtProductID.Text = AnOrder.ProductID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString("yyyy-MM-dd");
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus;
            chkIsCancelled.Checked = AnOrder.IsCancelled;
        }
        else
        {
            lblError.Text = "Record not found.";
        }
    }

    void DisplayOrder()
    {
        // Create an instance of the order collection
        clsOrderCollection OrderList = new clsOrderCollection();

        // Find the record based on OrderID from session
        OrderList.ThisOrder.Find(OrderID);

        // Display the data in the form controls
        txtOrderID.Text = OrderList.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderList.ThisOrder.CustomerID.ToString();
        txtProductID.Text = OrderList.ThisOrder.ProductID.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString("yyyy-MM-dd");
        txtTotalPrice.Text = OrderList.ThisOrder.TotalPrice.ToString("F2");
        txtOrderStatus.Text = OrderList.ThisOrder.OrderStatus;
        chkIsCancelled.Checked = OrderList.ThisOrder.IsCancelled;
    }

}