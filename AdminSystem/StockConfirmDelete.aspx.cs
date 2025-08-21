using System;
using System.Web.UI;
using ClassLibrary;

public partial class StockConfirmDelete : System.Web.UI.Page
{
    // variable to store the primary key value of the record to be deleted  
    Int32 StockId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the stock item to be deleted from the session object
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
