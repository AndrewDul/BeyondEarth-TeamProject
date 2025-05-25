using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffViewer : System.Web.UI.Page
{
    protected Label lblStaffIdValue;
    protected Label lblFullNameValue;
    protected Label lblPositionValue;
    protected Label lblActiveValue;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Only run if the page is loading for the first time (not on postback)  
        if (!IsPostBack)
        {
            // Retrieve the object from session  
            clsStaff staff = (clsStaff)Session["Staff"];

            // Display the data in the labels  
            lblStaffIdValue.Text = staff.StaffId.ToString();
            lblFullNameValue.Text = staff.FullName;
            lblPositionValue.Text = staff.Position;
            lblActiveValue.Text = staff.IsActive ? "Yes" : "No";
        }
    }
}
