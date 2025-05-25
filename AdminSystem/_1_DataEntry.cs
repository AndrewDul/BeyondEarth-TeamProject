using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object AnManagment { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsManagment
        clsManagment AnManagment = new clsManagment();


        //capture the FirstName and other entries

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

    


    protected void Button1_Click1(object sender, EventArgs e)
    {
        clsManagment AnManagment = new clsManagment();

        Int32 CustomerId;

        Boolean Found = false;

        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        Found = AnManagment.Find(CustomerId);

        if (Found == true)
        {
            txtFirstNameId.Text = AnManagment.FirstName;
            txtLastNameid.Text = AnManagment.LastName;
            txtEmailAddressId.Text = AnManagment.EmailAddress;
            txtPhoneNumber.Text = AnManagment.PhoneNumber;
            txtPostCode.Text = AnManagment.PostCode;
            txtDateAddedId.Text = AnManagment.DateAdded.ToString();
            chkActive.Checked = AnManagment.Active;
        }
    }

    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    
}