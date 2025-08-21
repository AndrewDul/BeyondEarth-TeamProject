using System;
using System.Web.UI;
using ClassLibrary;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // create an instance of the **stock user** class
        clsStockUser AnUser = new clsStockUser();

        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        if (string.IsNullOrEmpty(UserName))
        {
            lblErrorLogin.Text = "Please enter your username";
            return;
        }
        if (string.IsNullOrEmpty(Password))
        {
            lblErrorLogin.Text = "Please enter your password";
            return;
        }

        bool Found = AnUser.FindUser(UserName, Password);

        if (Found)
        {
            // login success
            Session["LoggedInUser"] = UserName;
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblErrorLogin.Text = "Invalid username or password. Please try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
