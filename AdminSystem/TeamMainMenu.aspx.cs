using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOrderMgmt_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnCustomerMgmt_Click(object sender, EventArgs e)
    {
        Response.Redirect("2List.aspx");
    }

    protected void btnStaffMgmt_Click(object sender, EventArgs e)
    {
        Response.Redirect("2List.aspx");
    }
    protected void btnStockMgmt_Click(object sender, EventArgs e)
    {
        Response.Redirect("2List.aspx"); // lub poprawna strona Moeeza
    }

}