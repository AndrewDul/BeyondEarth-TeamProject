using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderCollection clsOrder = new clsOrderCollection();

        // Statistics by Status
        DataTable dt = clsOrder.StatisticsGroupedByStatus();
        GridViewStGroupByStatus.DataSource = dt;
        GridViewStGroupByStatus.DataBind();
        GridViewStGroupByStatus.HeaderRow.Cells[0].Text = " Total ";

        // Statistics by OrderDate
        dt = clsOrder.StatisticsGroupedByDate();
        GridViewStGroupedByOrderDate.DataSource = dt;
        GridViewStGroupedByOrderDate.DataBind();
        GridViewStGroupedByOrderDate.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void btnPreviousPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}