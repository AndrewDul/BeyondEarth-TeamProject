using System;
using ClassLibrary;

public partial class DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // No need to add anything here unless needed
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsStaff
        clsStaff staff = new clsStaff(""); // Pass a position string if needed

        // Get values from text boxes
        string fullName = txtFullName.Text;
        string email = txtEmail.Text;
        string department = txtDepartment.Text;

        // Call the validation method
        string errorMsg = staff.Valid(fullName, email, department);

        // Check if validation passed
        if (string.IsNullOrEmpty(errorMsg))
        {
            // Assign properties (optional)
            staff.FullName = fullName;
            staff.Email = email;
            staff.Department = department;
            staff.IsActive = chkIsActive.Checked;

            lblError.ForeColor = System.Drawing.Color.Green;
            lblError.Text = "Validation passed. Staff data is ready!";
        }
        else
        {
            // Display errors
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = errorMsg.Replace("\n", "<br/>");
        }
    }
}
