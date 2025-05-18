using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // create a new instance of clsOrder
       clsOrder AnOrder = new clsOrder();

        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];

        // Display the Order Status for this entry
        Response.Write("Order ID: " + AnOrder.OrderID + "<br />");
        Response.Write("Customer ID: " + AnOrder.CustomerID + "<br />");
        Response.Write("Product ID: " + AnOrder.ProductID + "<br />");
        Response.Write("Order Date: " + AnOrder.OrderDate.ToShortDateString() + "<br />");
        Response.Write("Total Price: £" + AnOrder.TotalPrice + "<br />");
        Response.Write("Order Status: " + AnOrder.OrderStatus + "<br />");
        Response.Write("Is Cancelled: " + AnOrder.IsCancelled + "<br />");
    }
}