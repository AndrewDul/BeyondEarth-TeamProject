<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="StockConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Record</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
 
        <style>
            body {
                padding-top: 50px;
                background-color: #f8f9fa;
                font-family: Arial, sans-serif;
            }
    
            .container {
                max-width: 500px;
                padding: 30px;
                background-color: #ffffff;
                border-radius: 8px;
                box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
            }
    
            .alert {
                font-size: 18px;
                font-weight: bold;
            }
    
            .d-flex {
                gap: 20px;
            }
    
            .btn {
                padding: 12px 25px;
                font-size: 16px;
                font-weight: bold;
                border-radius: 8px;
                transition: all 0.3s ease;
                width: 120px;
            }
    
            .btn-danger {
                background-color: #dc3545;
                border-color: #dc3545;
            }
    
            .btn-danger:hover {
                background-color: #c82333;
                border-color: #bd2130;
            }
    
            .btn-secondary {
                background-color: #6c757d;
                border-color: #6c757d;
            }
    
            .btn-secondary:hover {
                background-color: #5a6268;
                border-color: #4e555b;
            }
    
            .btn:focus {
                box-shadow: none;
            }
    
        </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="alert alert-warning text-center" role="alert">
                <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this stock item?"></asp:Label>
            </div>
            <div class="d-flex justify-content-center">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn btn-danger" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="btn btn-secondary" />
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>

