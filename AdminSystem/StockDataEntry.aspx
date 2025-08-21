<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="StockDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            background-color: grey;
            background-image: url('4.jpg');
            background-size: cover;
            background-position: center;
            padding: 20px;
        }
        .container {
            max-width: 700px;
            background-color: dimgray;
            border-radius: 10px;
            padding: 40px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            margin-top: 20px;
        }
        .btn:hover { transform: scale(1.05); transition: 0.3s; }
    </style>
</head>
<body>

<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <div class="container-fluid">
        &nbsp;<div class="collapse navbar-collapse">
            <ul class="navbar-nav">
                <li class="nav-item"><a class="nav-link active" href="StockDataEntry.aspx">Add Stock</a></li>
                <li class="nav-item"><a class="nav-link" href="StockList.aspx">Stock List</a></li>
                <li class="nav-item"><a class="nav-link" href="TeamMainMenu.aspx">Logout</a></li>
            </ul>
        </div>
    </div>
</nav>

<form id="form1" runat="server">
    <div class="container mt-4">

        <!-- Stock ID -->
        <div class="row mb-3 align-items-center">
            <asp:Label ID="lblStockID" runat="server" Text="Stock ID" CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-3">
                <asp:TextBox ID="txtStockID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn btn-primary" OnClick="btnFind_Click"/>
            </div>
        </div>

        <!-- Stock Name -->
        <div class="row mb-3">
            <asp:Label ID="lblName" runat="server" Text="Stock Name" CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <!-- Supplier Name -->
        <div class="row mb-3">
            <asp:Label ID="lblSupplier" runat="server" Text="Supplier Name" CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtSupplierName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <!-- Selling Price -->
        <div class="row mb-3">
            <asp:Label ID="lblPrice" runat="server" Text="Selling Price" CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <!-- Quantity -->
        <div class="row mb-3">
            <asp:Label ID="lblQty" runat="server" Text="Quantity" CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <!-- Active -->
        <div class="row mb-3">
            <div class="offset-sm-2 col-sm-5 form-check">
                <asp:CheckBox ID="chkActive" runat="server" CssClass="form-check-input" />
                <asp:Label ID="lblActive" runat="server" AssociatedControlID="chkActive" Text="Active" CssClass="form-check-label"></asp:Label>
            </div>
        </div>

        <!-- Buttons -->
        <div class="mb-3 row">
            <div class="offset-sm-2 col-sm-5">
                <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-success me-2" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
            </div>
        </div>

        <!-- Error label -->
        <div class="row mb-3">
            <div class="offset-sm-2 col-sm-5">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="fw-bold"></asp:Label>
            </div>
        </div>
    </div>
</form>
</body>
</html>
