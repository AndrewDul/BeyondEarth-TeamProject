<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="StockConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Stock</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-image: url('4.jpg');
            background-size: cover;
            background-position: center;
            padding-top: 100px;
        }
        .card-custom {
            max-width: 500px;
            margin: auto;
            padding: 40px;
            background-color: rgba(255, 255, 255, 0.96);
            border-radius: 15px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card card-custom text-center">
            <h4 class="mb-4 text-danger"><i class="bi bi-exclamation-triangle-fill"></i> Delete Confirmation</h4>
            <p class="lead">Are you sure you want to delete this stock item?</p>

            <div>
                <asp:Button ID="btnYes" runat="server" Text="Yes, Delete" CssClass="btn btn-danger me-3" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" Text="No, Cancel" CssClass="btn btn-secondary" OnClick="btnNo_Click" />
            </div>
        </div>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>
