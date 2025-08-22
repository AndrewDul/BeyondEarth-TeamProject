<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockUpdate.aspx.cs" Inherits="StockUpdate" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Stock</title>

    <!-- Bootstrap 5 + Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />

    <style>
        :root{
            --ink:#0f172a; --panel:#111827; --panel-2:#1f2937; --line:#2d3748;
            --muted:#9ca3af; --brand:#14b8a6; --brand-2:#0ea5a4;
        }
        body{
            background: radial-gradient(1000px 600px at 10% -10%, #0b2447 0%, #000 40%) fixed,
                        radial-gradient(800px 400px at 110% 10%, #051937 0%, #000 50%) fixed,
                        #000; color:#e5e7eb;
        }
        .app-header{
            background: linear-gradient(180deg, rgba(20,20,28,.85), rgba(20,20,28,.75));
            border-bottom:1px solid var(--line); backdrop-filter: blur(6px);
        }
        .shell{ max-width: 960px; }
        .panel{
            background: linear-gradient(180deg, rgba(17,24,39,.92), rgba(17,24,39,.86));
            border:1px solid var(--line); border-radius:16px; box-shadow:0 10px 30px rgba(0,0,0,.5);
        }
        .panel-heading{
            padding:16px 18px; border-bottom:1px solid var(--line);
            display:flex; align-items:center; gap:10px;
            background: linear-gradient(180deg, rgba(31,41,55,.7), rgba(31,41,55,.4));
            border-top-left-radius:16px; border-top-right-radius:16px;
        }
        .panel-body{ padding:28px; }
        .form-label{ color:#cbd5e1; font-weight:500; }
        .form-control{ background:#0b1220; border:1px solid var(--line); color:#e5e7eb; }
        .form-control::placeholder{ color:#94a3b8; }
        .form-check-label{ color:#cbd5e1; }
        .btn-brand{ background:var(--brand); border-color:var(--brand); color:#001b1a; font-weight:600; }
        .btn-brand:hover{ background:var(--brand-2); border-color:var(--brand-2); color:#001b1a; }
        .btn-ghost{ background:transparent; border:1px solid var(--line); color:#e5e7eb; }
        .btn-ghost:hover{ background:#0f172a; border-color:#384151; }
        .error-message{ color:#fca5a5; font-weight:600; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header class="app-header sticky-top">
            <div class="container shell d-flex align-items-center justify-content-between py-3">
                <div class="d-flex align-items-center gap-3">
                    <i class="bi bi-pencil-square" style="font-size:1.35rem;color:var(--brand)"></i>
                    <span class="h5 m-0">Update Stock</span>
                </div>
                <a href="StockList.aspx" class="btn btn-ghost"><i class="bi bi-arrow-left"></i> Back to List</a>
            </div>
        </header>

        <!-- Content -->
        <div class="container shell my-4">
            <div class="panel">
                <div class="panel-heading">
                    <i class="bi bi-clipboard-data"></i>
                    <span class="fw-semibold">Update Stock Information</span>
                </div>
                <div class="panel-body">
                    <!-- Stock ID -->
                    <div class="mb-3 row">
                        <asp:Label ID="lblStockId" runat="server" CssClass="col-sm-4 col-form-label" Text="Stock ID:"></asp:Label>
                        <div class="col-sm-8">
                            <asp:Label ID="lblIdValue" runat="server" CssClass="form-control-plaintext text-white"></asp:Label>
                        </div>
                    </div>

                    <!-- Stock Name -->
                    <div class="mb-3 row">
                        <asp:Label ID="lblName" runat="server" Text="Stock Name" CssClass="col-sm-4 col-form-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Enter stock name"></asp:TextBox>
                        </div>
                    </div>

                    <!-- Supplier -->
                    <div class="mb-3 row">
                        <asp:Label ID="lblSupplier" runat="server" Text="Supplier Name" CssClass="col-sm-4 col-form-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtSupplier" runat="server" CssClass="form-control" placeholder="Enter supplier name"></asp:TextBox>
                        </div>
                    </div>

                    <!-- Price -->
                    <div class="mb-3 row">
                        <asp:Label ID="lblPrice" runat="server" Text="Selling Price" CssClass="col-sm-4 col-form-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" placeholder="e.g. 250"></asp:TextBox>
                        </div>
                    </div>

                    <!-- Quantity -->
                    <div class="mb-3 row">
                        <asp:Label ID="lblQty" runat="server" Text="Quantity" CssClass="col-sm-4 col-form-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control" placeholder="e.g. 50"></asp:TextBox>
                        </div>
                    </div>

                    <!-- Active -->
                    <div class="mb-3 row">
                        <div class="offset-sm-4 col-sm-8 form-check">
                            <asp:CheckBox ID="chkActive" runat="server" CssClass="form-check-input" />
                            <asp:Label runat="server" AssociatedControlID="chkActive" Text="Active" CssClass="form-check-label"></asp:Label>
                        </div>
                    </div>

                    <!-- Error -->
                    <asp:Label ID="lblError" runat="server" CssClass="error-message d-block mb-3"></asp:Label>

                    <!-- Actions -->
                    <div class="text-center mt-4">
                        <asp:Button ID="btnOK" runat="server" Text="Save" CssClass="btn btn-brand me-3 px-4" OnClick="btnOK_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-ghost px-4" OnClick="btnCancel_Click" />
                    </div>
                </div>
            </div>

            <div class="text-center mt-3 small text-secondary">
                &copy; 2025 Stock Management System — All rights reserved.
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
