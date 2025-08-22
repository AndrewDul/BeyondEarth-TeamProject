using System;
using ClassLibrary;    // for clsStockCollection

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        clsStockCollection StockCollection = new clsStockCollection();
        lstStockList.DataSource = StockCollection.StockList;
        lstStockList.DataValueField = "StockId";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockId"] = -1;    // so we can add new stock
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstStockList.SelectedIndex != -1)
        {
            int StockId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockId"] = StockId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstStockList.SelectedIndex != -1)
        {
            int StockId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockId"] = StockId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection FilteredStocks = new clsStockCollection();
        FilteredStocks.ReportByStockName(txtFilterStock.Text);
        lstStockList.DataSource = FilteredStocks.StockList;
        lstStockList.DataValueField = "StockId";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        txtFilterStock.Text = "";
        DisplayStocks();
        lblError.Text = "";
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStockCollection FilteredStocks = new clsStockCollection();
        FilteredStocks.ReportByStockName(txtFilterStock.Text);
        lstStockList.DataSource = FilteredStocks.StockList;
        lstStockList.DataValueField = "StockId";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
