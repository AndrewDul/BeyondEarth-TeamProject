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
        AnOrder = (clsOrder)Session["Anorder"];

        // Display the Order Status for this entry
        Response.Write(AnOrder.OrderStatus);
    }
}