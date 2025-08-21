<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Golden Hour Login Page</title>

    <!-- Bootstrap CSS CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    
    <style>
        /* General Body Styling */
        body {
            padding-top: 50px;
            background-color: #f4f6f9;
            background-image: url('3.jpg'); /* Add your background image here */
            background-size: cover;
            background-position: center;
        }

        /* Centering the form container */
        .container {
            max-width: 400px;
            background-color: dimgray; /* Slightly transparent background */
            border-radius: 10px;
            padding: 50px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }

        /* Hover effect for buttons */
        .btn:hover {
            transform: scale(1.05);
            transition: all 0.3s ease;
        }

        /* Styling for focused input fields */
        .form-control:focus {
            border-color: #d4af37; /* Gold color */
            box-shadow: 0 0 10px rgba(212, 175, 55, 0.5);
        }

        /* Adding subtle animation on form submission */
        .form-label {
            font-weight: 600;
        }

        /* Styling error message */
        .error-message {
            font-size: 0.875rem;
            color: red;
            font-weight: bold;
        }

        /* Styling hover effects on buttons */
        .btn-primary {
            background-color: #000;
            border-color: #000;
        }

        .btn-primary:hover {
            background-color: #d4af37; /* Gold color */
            border-color: #d4af37;
        }

        .btn-secondary {
            background-color: #6c757d;
            border-color: #6c757d;
        }

        .btn-secondary:hover {
            background-color: #5a6268;
            border-color: #5a6268;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <!-- Main container for centering content -->
        <div class="container">
           <center> </center>

            <!-- Page title (Centered) -->
            <h3 class="text-center mb-4">
                &nbsp;</h3>

            <!-- Username input field -->
            <div class="mb-3">
                <asp:Label ID="lblUserName" runat="server" Text="Username" AssociatedControlID="txtUserName" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Enter your username"></asp:TextBox>
            </div>

            <!-- Password input field -->
            <div class="mb-3">
                <asp:Label ID="lblPassword" runat="server" Text="Password" AssociatedControlID="txtPassword" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
            </div>

            <!-- Error message container -->
            <div class="mb-3">
                <asp:Label ID="lblErrorLogin" runat="server" CssClass="error-message"></asp:Label>
            </div>

            <!-- Login and Cancel buttons -->
            <div class="d-flex justify-content-center gap-3">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="btn btn-primary w-100" />
            </div>
            <div class="d-flex justify-content-center mt-2">
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="btn btn-secondary w-100" />
            </div>

        </div>

        <!-- Bootstrap JS Bundle -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

    </form>
</body>
</html>
