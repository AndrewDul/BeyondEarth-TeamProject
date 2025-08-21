<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockUpdate.aspx.cs" Inherits="StockUpdate" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Stock</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: lightsteelblue;
            background-image: url('4.jpg');
            background-size: cover;
            background-position: center;
            padding-top: 50px;
        }

        .container-custom {
            max-width: 700px;
            background-color: rgba(255,255,255,0.95);
            border-radius: 12px;
            padding: 40px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container container-custom mt-4">
            <h3 class="mb-4 text-center">Update Stock Information</h3>

            <div class="mb-3 row">
                <asp:Label ID="lblStockId" runat="server" CssClass="col-sm-4 col-form-label" Text="Stock ID:"></asp:Label>
                <div class="col-sm-8">
                    <asp:Label ID="lblIdValue" runat="server" CssClass="form-control-plaintext"></asp:Label>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="lblName" runat="server" Text="Stock Name" CssClass="col-sm-4 col-form-label"></asp:Label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="lblSupplier" runat="server" Text="Supplier Name" CssClass="col-sm-4 col-form-label"></asp:Label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtSupplier" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="lblPrice" runat="server" Text="Selling Price" CssClass="col-sm-4 col-form-label"></asp:Label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="lblQty" runat="server" Text="Quantity" CssClass="col-sm-4 col-form-label"></asp:Label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <div class="offset-sm-4 col-sm-8 form-check">
                    <asp:CheckBox ID="chkActive" runat="server" CssClass="form-check-input" />
                    <asp:Label runat="server" AssociatedControlID="chkActive" Text="Active" CssClass="form-check-label"></asp:Label>
                </div>
            </div>

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>

            <div class="text-center mt-4">
                <asp:Button ID="btnOK" runat="server" Text="Save" CssClass="btn btn-success me-3" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
