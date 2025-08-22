<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="StockViewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Stock Details</title>

    <!-- Bootstrap 5 + Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />

    <style>
        :root{
            --ink:#0f172a; --panel:#111827; --panel-2:#1f2937; --line:#2d3748;
            --muted:#9ca3af; --brand:#14b8a6; --brand-2:#0ea5a4;
        }
        body{
            height:100vh; display:flex; align-items:center; justify-content:center;
            background: radial-gradient(1000px 600px at 10% -10%, #0b2447 0%, #000 40%) fixed,
                        radial-gradient(800px 400px at 110% 10%, #051937 0%, #000 50%) fixed,
                        #000; color:#e5e7eb;
        }
        .panel{
            background: linear-gradient(180deg, rgba(17,24,39,.94), rgba(17,24,39,.88));
            border:1px solid var(--line);
            border-radius:16px;
            padding:30px;
            width:100%; max-width:600px;
            box-shadow:0 10px 30px rgba(0,0,0,.5);
        }
        .panel h3{ font-weight:600; color:#fff; }
        .form-control-plaintext{
            background:#0b1220;
            border:1px solid var(--line);
            border-radius:12px;
            padding:16px;
            color:#e5e7eb;
            white-space:pre-line; /* preserve line breaks */
        }
        .btn-brand{ background:var(--brand); border-color:var(--brand); color:#001b1a; font-weight:600; }
        .btn-brand:hover{ background:var(--brand-2); border-color:var(--brand-2); color:#001b1a; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel text-center">
            <i class="bi bi-info-circle" style="font-size:2rem;color:var(--brand)"></i>
            <h3 class="mb-4">Stock Details</h3>

            <!-- Dynamic details -->
            <asp:Label ID="lblDetails" runat="server" Text="" CssClass="form-control-plaintext"></asp:Label>

            <!-- OK Button -->
            <div class="text-center mt-4">
                <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-brand px-4" OnClick="btnOK_Click" />
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
