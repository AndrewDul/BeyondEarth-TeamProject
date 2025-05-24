using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // Capture input values as strings
        string OrderID = txtOrderID.Text;
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
            // If no errors, assign values to the object
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.ProductID = Convert.ToInt32(ProductID);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalPrice = Convert.ToDecimal(TotalPrice);
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.IsCancelled = chkIsCancelled.Checked;

            // Store the order in the session object
            Session["AnOrder"] = AnOrder;

            // Navigate to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            // Display the error message
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
}