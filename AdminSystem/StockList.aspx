<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock List</title>

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            padding-top: 50px;
            background-color: lightsteelblue;
            background-image: url('4.jpg');
            background-size: cover;
            background-position: center;
        }
        .container-custom {
            max-width: 950px;
            background-color: rgba(105,105,105, 0.9);
            border-radius: 10px;
            padding: 50px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.15);
        }
        .form-select {
            height: 300px;
            font-size: 1rem;
            border: 2px solid #007bff;
            border-radius: 10px;
            background-color: #f1f1f1;
            transition: transform 0.3s ease, background-color 0.3s ease;
        }
        .form-select:hover {
            transform: scale(1.05);
            background-color: #e2e2e2;
            border-color: #0056b3;
        }
        .btn:hover {
            transform: scale(1.05);
            transition: all 0.3s ease;
        }
        .btn-light-grey {
            background-color: #d3d3d3;
            border-color: #d3d3d3;
            color: #000;
        }
        .btn-light-grey:hover {
            background-color: #a9a9a9;
            border-color: #a9a9a9;
        }
        .button-container {
            display: flex;
            justify-content: space-between;
            gap: 10px;
        }
        .button-container .btn { width: 30%; }
        .transparent-textbox {
            background-color: transparent;
            border: 1px solid #ccc;
            color: #000;
            font-size: 1rem;
        }
        .transparent-textbox:focus {
            border-color: #007bff;
            outline: none;
        }
        .error-message {
            color: red;
            font-weight: bold;
        }
        .footer {
            background-color: #343a40;
            color: #fff;
            padding: 20px 0;
            text-align: center;
            font-size: 0.875rem;
            margin-top: 40px;
        }
        .footer a { color: #b0c4de; text-decoration: none; }
        .footer a:hover { text-decoration: underline; }
    </style>
</head>
<body>

    <!-- Navigation bar -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark sticky-top">
        <div class="container-fluid">
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="StockEntry.aspx">Add Stock</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active" href="StockList.aspx">Stock List</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="TeamMainMenu.aspx">Logout</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div class="container container-custom mt-4">

            <asp:Label ID="lblStockList" runat="server" Text="Stock List" CssClass="h4 text-center mb-3 text-white"></asp:Label>
            <asp:ListBox ID="lstStockList" runat="server" CssClass="form-select mb-3" Size="10" style="width:100%;"></asp:ListBox>

            <div class="button-container mb-4">
                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-light-grey" OnClick="btnAdd_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-light-grey" OnClick="btnEdit_Click" />
            </div>

            <div class="row align-items-center mb-3">
                <div class="col-auto">
                    <asp:Label ID="lblFilter" runat="server" Text="Enter Stock Name" CssClass="form-label text-white"></asp:Label>
                </div>
                <div class="col-auto">
                    <asp:TextBox ID="txtFilterStock" runat="server" CssClass="form-control transparent-textbox" Width="250px"></asp:TextBox>
                </div>
                <div class="col-auto">
                    <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btn btn-light-grey" OnClick="btnApplyFilter_Click" />
                    <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn btn-light-grey" OnClick="btnFind_Click" />
                </div>
                <div class="col-auto">
                    <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="btn btn-secondary" OnClick="btnClearFilter_Click" />
                </div>
            </div>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-message"></asp:Label>

            <div class="text-center mt-4">
                <asp:Button ID="btnLogout" runat="server" Text="Return To Main Menu" CssClass="btn btn-outline-dark" OnClick="btnLogout_Click" />
            </div>
        </div>

        <div class="footer">
            &copy; 2025 Golden Hour Watch Store. All rights reserved.
            <br />
            <a href="PrivacyPolicy.aspx">Privacy Policy</a> |
            <a href="TermsOfService.aspx">Terms of Service</a>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
