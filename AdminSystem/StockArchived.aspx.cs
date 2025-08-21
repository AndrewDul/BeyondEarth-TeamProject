using System;
using System.Web.UI;
using ClassLibrary;

public partial class StockArchive : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayArchivedStocks();
        }
    }

    private void DisplayArchivedStocks()
    {
        try
        {
            clsStockCollection stockCollection = new clsStockCollection();
            lstStockArchived.Items.Clear();

            // Loop through archived items
            foreach (var stock in stockCollection.StockList)
            {
                if (!stock.Active) // archived means inactive
                {
                    lstStockArchived.Items.Add(
                        new System.Web.UI.WebControls.ListItem(
                            stock.StockName + " (ID: " + stock.StockId + ")",
                            stock.StockId.ToString()
                        )
                    );
                }
            }

            if (lstStockArchived.Items.Count == 0)
            {
                lblErrorArchivedList.Text = "No archived stock items found.";
            }
            else
            {
                lblErrorArchivedList.Text = "";
            }
        }
        catch (Exception ex)
        {
            lblErrorArchivedList.Text = "Error loading archived stocks: " + ex.Message;
        }
    }

    protected void btnUnarchive_Click(object sender, EventArgs e)
    {
        try
        {
            if (lstStockArchived.GetSelectedIndices().Length == 0)
            {
                lblErrorArchivedList.Text = "Please select at least one stock to unarchive.";
                return;
            }

            clsStockCollection stockCollection = new clsStockCollection();

            foreach (System.Web.UI.WebControls.ListItem item in lstStockArchived.Items)
            {
                if (item.Selected)
                {
                    int stockId = Convert.ToInt32(item.Value);

                    // Find stock and unarchive it
                    if (stockCollection.ThisStock.Find(stockId))
                    {
                        stockCollection.ThisStock.Active = true;
                        stockCollection.Update();
                    }
                }
            }

            lblErrorArchivedList.Text = "Selected items have been unarchived.";
            DisplayArchivedStocks(); // refresh list
        }
        catch (Exception ex)
        {
            lblErrorArchivedList.Text = "Error unarchiving stock: " + ex.Message;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
