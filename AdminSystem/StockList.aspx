<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventory — Stock List</title>

    <!-- Bootstrap 5 -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Bootstrap Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />

    <style>
        :root{
            --ink:#0f172a;
            --panel:#111827;
            --panel-2:#1f2937;
            --line:#2d3748;
            --muted:#9ca3af;
            --brand:#14b8a6;
            --brand-2:#0ea5a4;
            --danger:#ef4444;
            --card:#0b1220;
            --shadow:0 10px 30px rgba(0,0,0,.35);
        }
        body {
            background: radial-gradient(1000px 600px at 10% -10%, #0b2447 0%, #000 40%) fixed,
                        radial-gradient(800px 400px at 110% 10%, #051937 0%, #000 50%) fixed,
                        #000;
            color: #e5e7eb;
        }
        .app-header {
            background: linear-gradient(180deg, rgba(20,20,28,.85), rgba(20,20,28,.75));
            backdrop-filter: blur(6px);
            border-bottom: 1px solid var(--line);
        }
        .shell { max-width: 1200px; }
        .panel {
            background: linear-gradient(180deg, rgba(17,24,39,.9), rgba(17,24,39,.85));
            border: 1px solid var(--line);
            border-radius: 14px;
            box-shadow: var(--shadow);
        }
        .panel-heading {
            padding: 16px 18px;
            border-bottom: 1px solid var(--line);
            display: flex; align-items:center; gap:10px;
            background: linear-gradient(180deg, rgba(31,41,55,.7), rgba(31,41,55,.4));
            border-top-left-radius: 14px; border-top-right-radius: 14px;
        }
        .panel-body { padding: 18px; }
        .sidebar .btn { width: 100%; padding: 10px 14px; border-radius: 10px; }
        .btn-brand { background: var(--brand); border-color: var(--brand); color: #001b1a; font-weight: 600; }
        .btn-brand:hover { background: var(--brand-2); border-color: var(--brand-2); color:#001b1a; }
        .btn-ghost { background: transparent; border: 1px solid var(--line); color: #e5e7eb; }
        .btn-ghost:hover { background: #0f172a; border-color: #384151; }
        .btn-danger-soft { background: rgba(239,68,68,.12); border: 1px solid rgba(239,68,68,.35); color: #fecaca; }
        .btn-danger-soft:hover { background: rgba(239,68,68,.22); border-color: rgba(239,68,68,.55); }
        .search-wrap {
            background: var(--panel-2);
            border: 1px solid var(--line);
            border-radius: 12px;
            display: flex; align-items: center; gap: 8px;
            padding: 8px 12px;
        }
        .search-wrap input[type="text"]{ background: transparent !important; border: 0 !important; color: #e5e7eb; }
        .hint { color: var(--muted); font-size: .92rem; }
        select.form-select, .form-select {
            height: 480px;
            background: var(--card);
            color: #e5e7eb;
            border: 1px solid var(--line);
            border-radius: 12px;
            font-size: 0.98rem;
        }
        .form-select option { padding: 10px; }
        .error-message { color: #fca5a5; font-weight: 600; }
        .sp-16 { height:16px; } .sp-24 { height:24px; }
        @media (max-width: 991.98px) { .stack-md { flex-direction: column; } }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header class="app-header sticky-top">
            <div class="container shell d-flex align-items-center justify-content-between py-3">
                <div class="d-flex align-items-center gap-3">
                    <i class="bi bi-box-seam" style="font-size:1.35rem;color:var(--brand)"></i>
                    <asp:Label ID="lblStockList" runat="server" Text="Inventory — Stock List" CssClass="h5 m-0"></asp:Label>
                </div>
                <div class="d-flex align-items-center gap-2">
                    <asp:Button ID="btnLogout" runat="server" Text="Return to Main Menu" CssClass="btn btn-ghost" OnClick="btnLogout_Click" />
                </div>
            </div>
        </header>

        <!-- Main Shell -->
        <div class="container shell my-4">
            <div class="row g-4 stack-md">
                <!-- Sidebar -->
                <div class="col-lg-4">
                    <div class="panel sidebar">
                        <div class="panel-heading">
                            <i class="bi bi-sliders"></i>
                            <span class="fw-semibold">Actions &amp; Filter</span>
                        </div>
                        <div class="panel-body">
                            <div class="search-wrap mb-3">
                                <i class="bi bi-search"></i>
                                <asp:TextBox ID="txtFilterStock" runat="server" CssClass="form-control" placeholder="Search by supplier name or keyword"></asp:TextBox>
                            </div>

                            <div class="d-flex gap-2 flex-wrap">
                                <asp:Button ID="btnFind" runat="server" Text="Find" CssClass="btn btn-ghost" OnClick="btnFind_Click" />
                                <asp:Button ID="btnClearFilter" runat="server" Text="Clear" CssClass="btn btn-ghost" OnClick="btnClearFilter_Click" />
                            </div>

                            <div class="sp-24"></div>
                            <div class="d-grid gap-2">
                                <asp:Button ID="btnAdd" runat="server" Text="Add New Stock" CssClass="btn btn-brand" OnClick="btnAdd_Click" />
                                <asp:Button ID="btnEdit" runat="server" Text="Edit Selected" CssClass="btn btn-ghost" OnClick="btnEdit_Click" />
                                <asp:Button ID="btnDelete" runat="server" Text="Delete Selected" CssClass="btn btn-danger-soft" OnClick="btnDelete_Click" />
                            </div>

                            <div class="sp-16"></div>
                            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-message"></asp:Label>
                        </div>
                    </div>
                </div>

                <!-- Main: Stock List -->
                <div class="col-lg-8">
                    <div class="panel h-100">
                        <div class="panel-heading">
                            <i class="bi bi-collection"></i>
                            <span class="fw-semibold">Inventory</span>
                            <span class="ms-auto text-secondary small">Select an item to Edit/Delete</span>
                        </div>
                        <div class="panel-body">
                            <asp:ListBox ID="lstStockList" runat="server" CssClass="form-select w-100" Size="14"></asp:ListBox>
                        </div>
                    </div>
                </div>
            </div>

            <div class="text-center mt-4 small text-secondary">
                &copy; 2025 Stock Management System — All rights reserved.
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
