using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Variable to store the OrderID of the order to be deleted
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the OrderID of the order to be deleted from the session
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Order collection
        clsOrderCollection OrderList = new clsOrderCollection();
        //find the record to delete
        OrderList.ThisOrder.OrderID = OrderID;
        //delete the record
        OrderList.Delete();
        //redirect back to the Order List page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the Order List page without deleting
        Response.Redirect("OrderList.aspx");
    }
}