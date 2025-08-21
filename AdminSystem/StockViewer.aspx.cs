using System;
using System.Text;
using System.Web.UI;
using ClassLibrary;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayStock();
        }
    }

    private void DisplayStock()
    {
        // Validate session value
        if (Session["StockId"] == null)
        {
            lblDetails.Text = "No Stock ID in session.";
            return;
        }

        int stockId;
        if (!Int32.TryParse(Session["StockId"].ToString(), out stockId))
        {
            lblDetails.Text = "Invalid Stock ID in session.";
            return;
        }

        // Load stock
        var aStock = new clsStock();
        if (!aStock.Find(stockId))
        {
            lblDetails.Text = "Stock not found.";
            return;
        }

        // Build HTML (C# 5 friendly)
        var sb = new StringBuilder();
        sb.AppendFormat("<strong>ID:</strong> {0}<br/>", aStock.StockId);
        sb.AppendFormat("<strong>Name:</strong> {0}<br/>", Server.HtmlEncode(aStock.StockName));
        sb.AppendFormat("<strong>Supplier:</strong> {0}<br/>", Server.HtmlEncode(aStock.SupplierName));
        sb.AppendFormat("<strong>Selling Price:</strong> £{0}<br/>", aStock.StockSellingPrice);
        sb.AppendFormat("<strong>Quantity:</strong> {0}<br/>", aStock.StockQuantity);
        sb.AppendFormat("<strong>Date Added:</strong> {0}<br/>", aStock.DateAdded.ToString("yyyy-MM-dd"));
        sb.AppendFormat("<strong>Active:</strong> {0}", aStock.Active ? "Yes" : "No");

        lblDetails.Text = sb.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
