<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderStatistics.aspx.cs" Inherits="OrderStatistics" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Statistics</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(135deg, #0d0d0d, #2b2b2b);
            font-family: 'Segoe UI', sans-serif;
            color: white;
            padding: 40px;
        }

        h2 {
            color: #f2f2f2;
            margin-bottom: 30px;
        }

        .card-custom {
            background-color: #1e1e1e;
            border-radius: 20px;
            padding: 30px;
            box-shadow: 0 12px 24px rgba(0,0,0,0.5);
            max-width: 1200px;
            margin: auto;
        }

        .btn-custom {
            background-color: #1e1e1e;
            border: none;
            color: white;
            padding: 12px 24px;
            border-radius: 12px;
            transition: all 0.3s ease;
            box-shadow: 5px 5px 10px #141414, -5px -5px 10px #2e2e2e;
            margin-bottom: 30px;
        }

        .btn-custom:hover {
            box-shadow: inset 5px 5px 10px #141414, inset -5px -5px 10px #2e2e2e;
            transform: scale(1.02);
        }

        .grid-title {
            font-size: 1.2em;
            margin-bottom: 10px;
        }

        .grid-style {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 30px;
        }

        .grid-style th, .grid-style td {
            padding: 10px;
            border: 1px solid #444;
            text-align: center;
        }

        .grid-style th {
            background-color: #333;
            color: white;
        }

        .grid-style tr:nth-child(even) {
            background-color: #2a2a2a;
        }

        .grid-style tr:hover {
            background-color: #444;
        }

        .row-gap {
            row-gap: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card-custom">
            <h2>📊 Order Statistics</h2>

            <asp:Button ID="btnPreviousPage" runat="server" CssClass="btn-custom" Text="⬅ Return to List" OnClick="btnPreviousPage_Click" />

            <div class="row row-gap">
                <div class="col-lg-6 col-md-12">
                    <div class="grid-title">Order List - Grouped by Date</div>
                    <asp:GridView ID="GridViewStGroupedByOrderDate" runat="server" CssClass="grid-style" AutoGenerateColumns="true" />
                </div>

                <div class="col-lg-6 col-md-12">
                    <div class="grid-title">Order List - Grouped by Status</div>
                    <asp:GridView ID="GridViewStGroupByStatus" runat="server" CssClass="grid-style" AutoGenerateColumns="true" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
