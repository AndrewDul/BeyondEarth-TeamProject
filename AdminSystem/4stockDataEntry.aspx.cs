using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsStock
        clsStock AStock = new clsStock();

        // Assign value from text box
        AStock.StockName = txtStockName.Text;

        // Store the object in the session
        Session["AStock"] = AStock;

        // Redirect to viewer page
        Response.Redirect("4stockViewer.aspx");
    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}
