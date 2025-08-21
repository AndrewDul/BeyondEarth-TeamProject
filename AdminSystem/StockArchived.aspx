<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockArchive.aspx.cs" Inherits="StockArchive" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Archived Stock Items</title>
    <meta charset="utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(to right, #f3f2f7, #e7eff7);
            font-family: 'Segoe UI', sans-serif;
            min-height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            padding: 40px;
        }
        .archived-box {
            background-color: #fff;
            border-radius: 16px;
            padding: 40px;
            box-shadow: 0 10px 25px rgba(0, 0, 0, 0.08);
            width: 100%;
            max-width: 900px;
        }
        .archived-box h2 {
            font-size: 1.75rem;
            color: #444;
            text-align: center;
            margin-bottom: 30px;
        }
        .styled-listbox {
            height: 300px;
            width: 100%;
            font-size: 1rem;
            border-radius: 8px;
            padding: 10px;
        }
        .btn-group {
            display: flex;
            justify-content: space-between;
            margin-top: 25px;
        }
        .btn {
            border-radius: 10px;
            min-width: 140px;
            padding: 10px 20px;
        }
        .btn-danger {
            background-color: #d16b86;
            border-color: #d16b86;
        }
        .btn-danger:hover {
            background-color: #b75973;
        }
        .btn-secondary:hover {
            background-color: #a6a6a6;
        }
        .error-message {
            margin-top: 20px;
            color: #d9534f;
            font-weight: 500;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="archived-box">
            <h2><i class="bi bi-archive-fill me-2"></i>Archived Stock</h2>

            <asp:ListBox ID="lstStockArchived" runat="server" CssClass="form-select styled-listbox" SelectionMode="Multiple"></asp:ListBox>

            <div class="btn-group">
                <asp:Button ID="btnUnarchive" runat="server" OnClick="btnUnarchive_Click" CssClass="btn btn-success" Text="Unarchive" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" CssClass="btn btn-secondary" Text="Cancel" />
            </div>

            <asp:Label ID="lblErrorArchivedList" runat="server" CssClass="error-message" Text=""></asp:Label>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>--%>
