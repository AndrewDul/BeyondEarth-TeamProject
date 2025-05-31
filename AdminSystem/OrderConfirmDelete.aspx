<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(135deg, #0d0d0d, #2b2b2b);
            font-family: 'Segoe UI', sans-serif;
            color: white;
            padding: 40px;
        }

        .card-custom {
            background-color: #1e1e1e;
            border-radius: 20px;
            padding: 30px 40px;
            box-shadow: 0 12px 24px rgba(0,0,0,0.5);
            max-width: 500px;
            margin: 100px auto;
            text-align: center;
        }

        h2 {
            margin-bottom: 30px;
            color: #f2f2f2;
        }

        .btn-custom {
            background-color: #1e1e1e;
            border: none;
            color: white;
            padding: 12px 24px;
            border-radius: 12px;
            transition: all 0.3s ease;
            box-shadow: 5px 5px 10px #141414, -5px -5px 10px #2e2e2e;
            min-width: 100px;
        }

        .btn-custom:hover {
            box-shadow: inset 5px 5px 10px #141414, inset -5px -5px 10px #2e2e2e;
            transform: scale(1.05);
            color: white;
        }

        .btn-section {
            display: flex;
            justify-content: center;
            gap: 30px;
            margin-top: 30px;
        }

        .confirmation-label {
            font-size: 1.2em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card-custom">
            <h2>Confirm Deletion</h2>
            <asp:Label ID="Label1" runat="server" CssClass="confirmation-label" Text="Are you sure you want to delete this record?"></asp:Label>

            <div class="btn-section">
                <asp:Button ID="btnYes" runat="server" CssClass="btn-custom" Text="Yes" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" CssClass="btn-custom" Text="No" OnClick="btnNo_Click" />
            </div>
        </div>
    </form>
</body>
</html>
