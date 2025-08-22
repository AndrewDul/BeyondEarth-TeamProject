//using System;
//using System.Web.UI.WebControls;
//using ClassLibrary;

//public partial class ArchivedStock : System.Web.UI.Page
//{
//    protected void Page_Load(object sender, EventArgs e)
//    {
//        if (!IsPostBack)
//        {
//            DisplayArchivedStocks();
//        }
//    }

//    private void DisplayArchivedStocks()
//    {
//        try
//        {
//            clsStockCollection stockCollection = new clsStockCollection();
//            lstStockArchived.Items.Clear();

//            foreach (clsStock stock in stockCollection.StockList)
//            {
//                if (!stock.Active)
//                {
//                    string text = string.Format("{0} (ID: {1})", stock.StockName, stock.StockId);
//                    lstStockArchived.Items.Add(new ListItem(text, stock.StockId.ToString()));
//                }
//            }

//            if (lstStockArchived.Items.Count == 0)
//            {
//                lblErrorArchivedList.Text = "No archived stock items found.";
//            }
//            else
//            {
//                lblErrorArchivedList.Text = "";
//            }
//        }
//        catch (Exception ex)
//        {
//            lblErrorArchivedList.Text = "Error loading archived stocks: " + ex.Message;
//        }
//    }

//    protected void btnUnarchive_Click(object sender, EventArgs e)
//    {
//        try
//        {
//            if (lstStockArchived.GetSelectedIndices().Length == 0)
//            {
//                lblErrorArchivedList.Text = "Please select at least one stock to unarchive.";
//                return;
//            }

//            clsStockCollection stockCollection = new clsStockCollection();

//            foreach (ListItem item in lstStockArchived.Items)
//            {
//                if (item.Selected)
//                {
//                    int stockId = Convert.ToInt32(item.Value);
//                    if (stockCollection.ThisStock.Find(stockId))
//                    {
//                        stockCollection.ThisStock.Active = true;
//                        stockCollection.Update();
//                    }
//                }
//            }

//            lblErrorArchivedList.Text = "Selected items have been unarchived.";
//            DisplayArchivedStocks();
//        }
//        catch (Exception ex)
//        {
//            lblErrorArchivedList.Text = "Error unarchiving stock: " + ex.Message;
//        }
//    }

//    protected void btnCancel_Click(object sender, EventArgs e)
//    {
//        Response.Redirect("StockList.aspx");
//    }
//}
