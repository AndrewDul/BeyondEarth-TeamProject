<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Management</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Script/bootstrap.bundle.min.js"></script>
    <style>
        body {
            background: linear-gradient(135deg, #0d0d0d, #2b2b2b);
            color: white;
            font-family: 'Segoe UI', sans-serif;
            padding: 40px;
        }

        h2 {
            color: white;
            text-align: center;
            margin-bottom: 30px;
        }

        .btn-elegant {
            border-radius: 12px;
            background-color: #1e1e1e;
            color: white !important;
            border: none;
            padding: 12px 24px;
            transition: all 0.3s ease;
            box-shadow: 5px 5px 10px #141414, -5px -5px 10px #2e2e2e;
        }

        .btn-elegant:hover {
            box-shadow: inset 5px 5px 10px #141414, inset -5px -5px 10px #2e2e2e;
            transform: scale(1.02);
        }

        .card-custom {
            background-color: #2c2c2e;
            border-radius: 20px;
            padding: 30px;
            box-shadow: 0 12px 24px rgba(0,0,0,0.5);
        }

        .form-label {
            margin-bottom: 8px;
            font-weight: 500;
        }

        .form-control {
            background-color: #1e1e1e;
            border: none;
            color: white;
            padding: 10px;
            border-radius: 10px;
            transition: all 0.3s ease;
            box-shadow: inset 0 0 0 transparent;
        }

        .form-control:focus {
            outline: none;
            box-shadow: 0 0 8px rgba(255, 255, 255, 0.3);
        }

        #lstOrderList {
            background-color: #1e1e1e;
            color: white;
            border: none;
            border-radius: 10px;
            padding: 10px;
            width: 100%;
            height: 300px;
            transition: all 0.3s ease;
        }

        .btn-section {
            display: flex;
            flex-wrap: wrap;
            gap: 15px;
            margin-bottom: 20px;
        }

        .text-danger {
            margin-top: 10px;
            color: #ff7070;
        }
        .hide-scrollbar {
    overflow: auto;
    scrollbar-width: none;       /* Firefox */
    -ms-overflow-style: none;    /* IE 10+ */
}

.hide-scrollbar::-webkit-scrollbar {
    display: none;               /* Chrome, Safari, Edge */
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card card-custom">
                <h2>📦 Order Management</h2>

                <div class="mb-4">
                    <asp:ListBox ID="lstOrderList" runat="server" CssClass="form-control hide-scrollbar" Rows="10" />

                </div>

                <div class="btn-section">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-elegant" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-elegant" OnClick="btnEdit_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-elegant" OnClick="btnDelete_Click" />
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblStatus" runat="server" Text="Enter a Status:" CssClass="form-label text-white" />

                    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" />
                </div>

                <div class="btn-section">
                    <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="btn btn-elegant" OnClick="btnApplyFilter_Click" />
                    <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="btn btn-elegant" OnClick="btnClearFilter_Click" />
                    <asp:Button ID="btnToStPage" runat="server" Text="Statistics Page" CssClass="btn btn-elegant" OnClick="btnToStPage_Click" />
                    <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" CssClass="btn btn-elegant" OnClick="btnReturn_Click" />
                </div>

                <div class="text-danger">
                    <asp:Label ID="lblError" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
