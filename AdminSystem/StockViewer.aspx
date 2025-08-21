<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="StockViewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Stock Details</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: lightsteelblue;
            background-image: url('4.jpg');
            background-size: cover;
            background-position: center;
            padding-top: 50px;
        }

        .card-custom {
            max-width: 600px;
            margin: auto;
            background-color: rgba(255, 255, 255, 0.95);
            border-radius: 15px;
            padding: 30px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="card card-custom">
            <h3 class="text-center mb-4">Stock Details</h3>

            <asp:Label ID="lblDetails" runat="server" Text="" CssClass="form-control-plaintext"></asp:Label>

            <div class="text-center mt-4">
                <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-primary" OnClick="btnOK_Click" />
            </div>
        </div>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>
