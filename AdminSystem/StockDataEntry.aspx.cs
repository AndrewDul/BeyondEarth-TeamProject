using System;
using ClassLibrary;

public partial class StockDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["StockID"] != null)
            {
                int StockID = Convert.ToInt32(Session["StockID"]);
                if (StockID != -1)
                {
                    DisplayStock(StockID);
                    txtStockID.Text = StockID.ToString();
                }
            }
        }
    }

    void DisplayStock(int stockID)
    {
        clsStockCollection StockList = new clsStockCollection();
        if (StockList.ThisStock.Find(stockID))
        {
            txtName.Text = StockList.ThisStock.StockName;
            txtSupplierName.Text = StockList.ThisStock.SupplierName;
            txtPrice.Text = StockList.ThisStock.StockSellingPrice.ToString();
            txtQuantity.Text = StockList.ThisStock.StockQuantity.ToString();
            chkActive.Checked = StockList.ThisStock.Active;
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Stock item not found.";
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        int stockID;
        if (int.TryParse(txtStockID.Text, out stockID))
        {
            if (aStock.Find(stockID))
            {
                txtName.Text = aStock.StockName;
                txtSupplierName.Text = aStock.SupplierName;
                txtPrice.Text = aStock.StockSellingPrice.ToString();
                txtQuantity.Text = aStock.StockQuantity.ToString();
                chkActive.Checked = aStock.Active;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "ID not found.";
                ClearControls();
            }
        }
        else
        {
            lblError.Text = "Please enter a valid numeric Stock ID.";
            ClearControls();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        string Error = aStock.Valid(txtName.Text, txtSupplierName.Text, txtPrice.Text, txtQuantity.Text);

        if (Error == "")
        {
            aStock.StockName = txtName.Text;
            aStock.SupplierName = txtSupplierName.Text;
            aStock.StockSellingPrice = Convert.ToInt32(txtPrice.Text);
            aStock.StockQuantity = Convert.ToInt32(txtQuantity.Text);
            aStock.Active = chkActive.Checked;

            clsStockCollection StockList = new clsStockCollection();
            int StockID = -1;
            if (Session["StockID"] != null) StockID = Convert.ToInt32(Session["StockID"]);

            if (StockID == -1)
            {
                StockList.ThisStock = aStock;
                StockList.Add();
                Session["SuccessMessage"] = "Record successfully added!";
            }
            else
            {
                aStock.StockId = StockID;
                StockList.ThisStock = aStock;
                StockList.Update();
                Session["SuccessMessage"] = "Record successfully updated!";
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    private void ClearControls()
    {
        txtName.Text = "";
        txtSupplierName.Text = "";
        txtPrice.Text = "";
        txtQuantity.Text = "";
        chkActive.Checked = false;
    }
}
