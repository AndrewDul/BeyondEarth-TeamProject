using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsManagement
        clsManagment AnManagment = new clsManagment();

        //get the data from the session object
        AnManagment = (clsManagment)Session["AnManagment"];


        //Display the firstName for this entry
        Response.Write("Customer ID: " + AnManagment.CustomerId + "<br />");
        Response.Write("First Name: " + AnManagment.FirstName + "<br />");
        Response.Write("Last Name: " + AnManagment.LastName + "<br />");
        Response.Write("Email Address: " + AnManagment.EmailAddress + "<br />");
        Response.Write("Post Code: " + AnManagment.PostCode + "<br />");
        Response.Write("Phone Number: " + AnManagment.PhoneNumber + "<br />");
        Response.Write("Date Added: " + AnManagment.DateAdded.ToShortDateString());



    }
}