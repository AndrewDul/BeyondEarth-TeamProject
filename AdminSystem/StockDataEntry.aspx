<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="StockDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock — Data Entry</title>

    <!-- Bootstrap 5 + Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />

    <style>
        :root{
            --ink:#0f172a; --panel:#111827; --panel-2:#1f2937; --line:#2d3748;
            --muted:#9ca3af; --brand:#14b8a6; --brand-2:#0ea5a4; --danger:#ef4444;
            --card:#0b1220; --shadow:0 10px 30px rgba(0,0,0,.35);
        }
        html,body{height:100%;}
        body{
            background: radial-gradient(1000px 600px at 10% -10%, #0b2447 0%, #000 40%) fixed,
                        radial-gradient(800px 400px at 110% 10%, #051937 0%, #000 50%) fixed,
                        #000; color:#e5e7eb;
        }
        .app-header{
            background: linear-gradient(180deg, rgba(20,20,28,.85), rgba(20,20,28,.75));
            border-bottom:1px solid var(--line); backdrop-filter: blur(6px);
        }
        .shell{ max-width: 1100px; }

        .panel{
            background: linear-gradient(180deg, rgba(17,24,39,.92), rgba(17,24,39,.86));
            border:1px solid var(--line); border-radius:16px; box-shadow: var(--shadow);
        }
        .panel-heading{
            padding:16px 18px; border-bottom:1px solid var(--line);
            display:flex; align-items:center; gap:10px;
            background: linear-gradient(180deg, rgba(31,41,55,.7), rgba(31,41,55,.4));
            border-top-left-radius:16px; border-top-right-radius:16px;
        }
        .panel-body{ padding:22px; }

        .field-card{
            background: var(--panel-2);
            border:1px solid var(--line);
            border-radius:12px;
            padding:14px 14px 10px 14px;
        }
        .form-control, .form-check-input{
            background:#0b1220; color:#e5e7eb; border:1px solid var(--line);
        }
        .form-control::placeholder{ color:#94a3b8; }
        .form-label{ color:#cbd5e1; }

        .btn-brand{ background:var(--brand); border-color:var(--brand); color:#001b1a; font-weight:600; }
        .btn-brand:hover{ background:var(--brand-2); border-color:var(--brand-2); color:#001b1a; }
        .btn-ghost{ background:transparent; border:1px solid var(--line); color:#e5e7eb; }
        .btn-ghost:hover{ background:#0f172a; border-color:#384151; }
        .btn-danger-soft{ background: rgba(239,68,68,.12); border:1px solid rgba(239,68,68,.35); color:#fecaca; }
        .btn-danger-soft:hover{ background: rgba(239,68,68,.22); border-color: rgba(239,68,68,.55); }

        .error-message{ color:#fca5a5; font-weight:600; }
        .muted{ color:var(--muted); }
        .sp-12{height:12px;} .sp-16{height:16px;} .sp-24{height:24px;}

        @media (max-width: 991.98px){
            .stack-md{flex-direction:column;}
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header class="app-header sticky-top">
            <div class="container shell d-flex align-items-center justify-content-between py-3">
                <div class="d-flex align-items-center gap-3">
                    <i class="bi bi-box-seam" style="font-size:1.35rem;color:var(--brand)"></i>
                    <span class="h5 m-0">Stock — Data Entry</span>
                </div>
                <div class="d-flex gap-2">
                    <a href="StockList.aspx" class="btn btn-ghost"><i class="bi bi-list-ul"></i> Stock List</a>
                    <a href="TeamMainMenu.aspx" class="btn btn-ghost"><i class="bi bi-door-open"></i> Main Menu</a>
                </div>
            </div>
        </header>

        <!-- Content -->
        <div class="container shell my-4">
            <div class="panel">
                <div class="panel-heading">
                    <i class="bi bi-pencil-square"></i>
                    <span class="fw-semibold">Enter / Edit Stock Details</span>
                </div>
                <div class="panel-body">
                    <!-- Stock ID & Find -->
                    <div class="row g-3 align-items-end">
                        <div class="col-md-3">
                            <label for="txtStockID" class="form-label">Stock ID</label>
                            <asp:TextBox ID="txtStockID" runat="server" CssClass="form-control" placeholder="e.g., 101"></asp:TextBox>
                        </div>
                        <div class="col-md-2 d-grid">
                            <label class="form-label">&nbsp;</label>
                            <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn btn-ghost" OnClick="btnFind_Click" />
                        </div>
                        <div class="col-md-7">
                            <div class="muted small">Tip: Use <em>Find</em> to load an existing stock record by ID.</div>
                        </div>
                    </div>

                    <div class="sp-24"></div>

                    <!-- Two-column form -->
                    <div class="row g-4 stack-md">
                        <div class="col-lg-6">
                            <div class="field-card">
                                <label for="txtName" class="form-label">Stock Name</label>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Product name"></asp:TextBox>
                            </div>
                            <div class="sp-16"></div>
                            <div class="field-card">
                                <label for="txtSupplierName" class="form-label">Supplier Name</label>
                                <asp:TextBox ID="txtSupplierName" runat="server" CssClass="form-control" placeholder="Supplier"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="field-card">
                                <label for="txtPrice" class="form-label">Selling Price</label>
                                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" placeholder="e.g., 199.99"></asp:TextBox>
                            </div>
                            <div class="sp-16"></div>
                            <div class="field-card">
                                <label for="txtQuantity" class="form-label">Quantity</label>
                                <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control" placeholder="e.g., 25"></asp:TextBox>
                            </div>
                            <div class="sp-16"></div>
                            <div class="form-check">
                                <asp:CheckBox ID="chkActive" runat="server" CssClass="form-check-input" />
                                <asp:Label ID="lblActive" runat="server" AssociatedControlID="chkActive" Text="Active" CssClass="form-check-label"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="sp-24"></div>

                    <!-- Actions -->
                    <div class="d-flex flex-wrap gap-2">
                        <asp:Button ID="btnOK" runat="server" Text="Save" CssClass="btn btn-brand px-4" OnClick="btnOK_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-ghost px-4" OnClick="btnCancel_Click" />
                        <span class="ms-auto"></span>
                    </div>

                    <div class="sp-16"></div>
                    <!-- Error -->
                    <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>
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
