using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsManagment
        clsManagment AnManagment = new clsManagment();


        //capture the FirstName

        AnManagment.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnManagment.FirstName = (txtFirstNameId.Text);
        AnManagment.LastName = (txtLastNameid.Text);
        AnManagment.EmailAddress = (txtEmailAddressId.Text);
        AnManagment.PostCode = (txtPostCode.Text);
        AnManagment.PhoneNumber = (txtPhoneNumber.Text);
        AnManagment.DateAdded = Convert.ToDateTime(txtDateAddedId.Text);



        //Store the firstName in the session object
        Session["AnManagment"] = AnManagment;
      
        
        
        //navigate to the view page
        Response.Redirect("3Viewer.aspx");
    }
}