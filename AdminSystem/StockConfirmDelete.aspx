<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="StockConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete — Stock</title>

    <!-- Bootstrap 5 + Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />

    <style>
        :root{
            --ink:#0f172a; --panel:#111827; --panel-2:#1f2937; --line:#2d3748;
            --muted:#9ca3af; --brand:#14b8a6; --brand-2:#0ea5a4; --danger:#ef4444;
            --card:#0b1220; --shadow:0 10px 30px rgba(0,0,0,.35);
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
            border:1px solid var(--line); border-radius:16px; box-shadow: var(--shadow);
        }
        .panel-heading{
            padding:16px 18px; border-bottom:1px solid var(--line);
            display:flex; align-items:center; gap:10px;
            background: linear-gradient(180deg, rgba(31,41,55,.7), rgba(31,41,55,.4));
            border-top-left-radius:16px; border-top-right-radius:16px;
        }
        .panel-body{ padding:24px; }
        .confirm-icon{
            width:64px; height:64px; border-radius:50%;
            display:grid; place-items:center; margin:0 auto 12px auto;
            background: rgba(239,68,68,.12); border:1px solid rgba(239,68,68,.35);
            color:#fecaca; font-size:28px;
        }
        .btn-brand{ background:var(--brand); border-color:var(--brand); color:#001b1a; font-weight:600; }
        .btn-brand:hover{ background:var(--brand-2); border-color:var(--brand-2); color:#001b1a; }
        .btn-ghost{ background:transparent; border:1px solid var(--line); color:#e5e7eb; }
        .btn-ghost:hover{ background:#0f172a; border-color:#384151; }
        .btn-danger-soft{ background: rgba(239,68,68,.12); border:1px solid rgba(239,68,68,.35); color:#fecaca; }
        .btn-danger-soft:hover{ background: rgba(239,68,68,.22); border-color: rgba(239,68,68,.55); }
        .muted{ color:var(--muted); }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Header -->
        <header class="app-header sticky-top">
            <div class="container shell d-flex align-items-center justify-content-between py-3">
                <div class="d-flex align-items-center gap-3">
                    <i class="bi bi-box-seam" style="font-size:1.35rem;color:var(--brand)"></i>
                    <span class="h5 m-0">Confirm Delete — Stock</span>
                </div>
                <a href="StockList.aspx" class="btn btn-ghost"><i class="bi bi-arrow-left"></i> Back to List</a>
            </div>
        </header>

        <!-- Centered Card -->
        <div class="container shell my-5">
            <div class="row justify-content-center">
                <div class="col-lg-8 col-xl-7">
                    <div class="panel">
                        <div class="panel-heading">
                            <i class="bi bi-exclamation-triangle"></i>
                            <span class="fw-semibold">Please Confirm</span>
                        </div>
                        <div class="panel-body text-center">
                            <div class="confirm-icon"><i class="bi bi-trash3"></i></div>

                            <h5 class="mb-2">Delete this stock item?</h5>
                            <p class="muted mb-4">
                                <asp:Label ID="Label1" runat="server" 
                                           Text="Are you sure you want to delete this stock item? This action cannot be undone.">
                                </asp:Label>
                            </p>

                            <div class="d-flex justify-content-center gap-2 flex-wrap">
                                <asp:Button ID="btnYes" runat="server" Text="Yes, Delete" CssClass="btn btn-danger-soft px-4" OnClick="btnYes_Click" />
                                <asp:Button ID="btnNo" runat="server" Text="No, Cancel" CssClass="btn btn-brand px-4" OnClick="btnNo_Click" />
                            </div>
                        </div>
                    </div>

                    <div class="text-center mt-3 small text-secondary">
                        &copy; 2025 Stock Management System — All rights reserved.
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
