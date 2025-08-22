<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ArchivedStock.aspx.cs" Inherits="ArchivedStock" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Archived Stock</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        :root{ --line:#2d3748; --brand:#14b8a6; }
        body{ background:#0b1220; color:#e5e7eb; min-height:100vh; }
        .shell{ max-width: 1100px; }
        .panel{ background:#111827; border:1px solid var(--line); border-radius:14px; padding:22px; }
        .form-select{ height:420px; background:#0f172a; color:#fff; border:1px solid var(--line); }
        .error-message{ color:#fca5a5; font-weight:600; }
        .btn-brand{ background:var(--brand); border-color:var(--brand); color:#001b1a; font-weight:600; }
        .btn-ghost{ background:transparent; border:1px solid var(--line); color:#e5e7eb; }
        .btn-ghost:hover{ background:#0f172a; }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="container shell my-4">
        <div class="d-flex align-items-center justify-content-between mb-3">
            <h3 class="m-0">Archived Stock</h3>
            <a href="StockList.aspx" class="btn btn-ghost">Back to List</a>
        </div>

        <div class="panel">
            <p class="text-secondary mb-2">Select one or more archived items to unarchive:</p>

            <asp:ListBox ID="lstStockArchived" runat="server"
                         CssClass="form-select mb-3" SelectionMode="Multiple"></asp:ListBox>

            <div class="d-flex gap-2">
                <asp:Button ID="btnUnarchive" runat="server" Text="Unarchive Selected" CssClass="btn btn-brand"
                            OnClick="btnUnarchive_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-ghost"
                            OnClick="btnCancel_Click" />
            </div>

            <div class="mt-3">
                <asp:Label ID="lblErrorArchivedList" runat="server" CssClass="error-message"></asp:Label>
            </div>
        </div>
    </div>
</form>
</body>
</html>--%>
