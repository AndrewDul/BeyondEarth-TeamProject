using System;
using Testing4;  // adjust namespace if needed
using ClassLibrary;

public partial class StockConfirmDelete : System.Web.UI.Page
{
    int StockId;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockList = new clsStockCollection();
        StockList.ThisStock.Find(StockId);
        StockList.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
