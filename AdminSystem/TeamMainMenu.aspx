<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BeyondEarth Main Menu</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Script/bootstrap.bundle.min.js"></script>
    <style>
        body {
            background: linear-gradient(135deg, #0d0d0d, #2b2b2b);
            font-family: 'Segoe UI', sans-serif;
            color: white;
            padding: 40px;
            height: 100vh;
            margin: 0;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .main-card {
            background-color: #1e1e1e;
            border-radius: 24px;
            padding: 50px 40px;
            box-shadow: 0 12px 24px rgba(0,0,0,0.5);
            text-align: center;
            width: 100%;
            max-width: 720px;
            animation: fadeIn 1s ease-in-out;
        }

        .main-title {
            font-size: 2.2rem;
            font-weight: 700;
            color: #f0f0f0;
            margin-bottom: 10px;
        }

        .main-subtitle {
            font-size: 1.1rem;
            color: #bbbbbb;
            margin-bottom: 40px;
        }

        .btn-row {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            gap: 15px;
        }

        .menu-btn {
            border-radius: 16px;
            background-color: #2c2c2e;
            color: white;
            border: 1px solid #444;
            font-weight: 600;
            padding: 14px 24px;
            font-size: 1rem;
            box-shadow: 5px 5px 10px #141414, -5px -5px 10px #2e2e2e;
            transition: all 0.3s ease-in-out;
            min-width: 180px;
        }

        .menu-btn:hover {
            background-color: #1a1a1c;
            box-shadow: inset 5px 5px 10px #141414, inset -5px -5px 10px #2e2e2e;
            transform: scale(1.02);
        }

        @keyframes fadeIn {
            from { opacity: 0; transform: translateY(30px); }
            to { opacity: 1; transform: translateY(0); }
        }

        @media (max-width: 576px) {
            .btn-row {
                flex-direction: column;
                align-items: center;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-card">
            <div class="main-title">BeyondEarth Management System</div>
            <div class="main-subtitle">Select a section to manage system components</div>
            <div class="btn-row">
                <asp:Button ID="btnOrderMgmt" runat="server" CssClass="menu-btn" Text="Order Management" OnClick="btnOrderMgmt_Click" />
                <asp:Button ID="btnCustomerMgmt" runat="server" CssClass="menu-btn" Text="Customer Management" OnClick="btnCustomerMgmt_Click" />
                <asp:Button ID="btnStaffMgmt" runat="server" CssClass="menu-btn" Text="Staff Management" OnClick="btnStaffMgmt_Click" />
                <asp:Button ID="btnStockMgmt" runat="server" CssClass="menu-btn" Text="Stock Management" OnClick="btnStockMgmt_Click" />
            </div>
        </div>
    </form>
</body>
</html>
