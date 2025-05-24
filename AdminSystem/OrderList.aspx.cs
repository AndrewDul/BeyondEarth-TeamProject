using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        // create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();

        // set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;

        // set the name of the primary key (hidden value)
        lstOrderList.DataValueField = "OrderID";

        // set the field to display in the list box (you can change it if needed)
        lstOrderList.DataTextField = "DisplayInfo";

        // bind the data to the list box
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1; // Set OrderID to -1 for adding a new order
        // Redirect to the Add page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
