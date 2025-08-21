using System;
using ClassLibrary;

public partial class StockUpdate : System.Web.UI.Page
{
    int StockId;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
        if (!IsPostBack)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection collection = new clsStockCollection();
        collection.ThisStock.Find(StockId);

        lblIdValue.Text = collection.ThisStock.StockId.ToString();
        txtName.Text = collection.ThisStock.StockName;
        txtSupplier.Text = collection.ThisStock.SupplierName;
        txtPrice.Text = collection.ThisStock.StockSellingPrice.ToString();
        txtQuantity.Text = collection.ThisStock.StockQuantity.ToString();
        chkActive.Checked = collection.ThisStock.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStockCollection collection = new clsStockCollection();
        collection.ThisStock.Find(StockId);

        // Revalidate input
        string error = collection.ThisStock.Valid(
            txtName.Text,
            txtSupplier.Text,
            txtPrice.Text,
            txtQuantity.Text);

        if (error == "")
        {
            collection.ThisStock.StockName = txtName.Text;
            collection.ThisStock.SupplierName = txtSupplier.Text;
            collection.ThisStock.StockSellingPrice = Convert.ToInt32(txtPrice.Text);
            collection.ThisStock.StockQuantity = Convert.ToInt32(txtQuantity.Text);
            collection.ThisStock.Active = chkActive.Checked;

            collection.Update();
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
