<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Management</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(135deg, #0d0d0d, #2b2b2b);
            font-family: 'Segoe UI', sans-serif;
            color: white;
            padding: 40px;
        }

        h2 {
            text-align: center;
            margin-bottom: 30px;
            color: #f2f2f2;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-label {
            display: block;
            margin-bottom: 5px;
            font-weight: 500;
        }

        .form-control {
            background-color: #1e1e1e;
            border: none;
            color: white;
            padding: 10px;
            border-radius: 10px;
            width: 100%;
            transition: all 0.3s ease;
            box-shadow: inset 0 0 0 transparent;
        }

        .form-control:focus {
            outline: none;
            box-shadow: 0 0 8px rgba(255, 255, 255, 0.3);
        }

        .btn-custom {
            background-color: #1e1e1e;
            border: none;
            color: white;
            padding: 12px 24px;
            border-radius: 12px;
            transition: all 0.3s ease;
            box-shadow: 5px 5px 10px #141414, -5px -5px 10px #2e2e2e;
        }

        .btn-custom:hover {
            box-shadow: inset 5px 5px 10px #141414, inset -5px -5px 10px #2e2e2e;
            transform: scale(1.02);
        }

        .row-flex {
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .btn-section {
            margin-top: 30px;
            display: flex;
            gap: 20px;
        }

        .checkbox {
            margin-top: 10px;
        }

        #lblError {
            color: #ff7070;
            margin-top: 10px;
        }

        .container-custom {
            max-width: 600px;
            margin: auto;
        }

        .card-custom {
            background-color: #2c2c2e;
            border-radius: 20px;
            padding: 30px;
            box-shadow: 0 12px 24px rgba(0,0,0,0.5);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-custom">
            <div class="card-custom">
                <h2>Order Management</h2>

               <div class="form-group">
    <label class="form-label">Order ID</label>
    <div class="row-flex">
        <asp:TextBox ID="txtOrderID" runat="server" CssClass="form-control" Width="60%" placeholder="Order ID"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" CssClass="btn-custom" Text="Find" OnClick="btnFind_Click" />
    </div>
</div>

                <div class="form-group">
                    <label class="form-label">Customer ID</label>
                    <asp:TextBox ID="txtCustomerID" runat="server" CssClass="form-control" placeholder="Customer ID"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="form-label">Product ID</label>
                    <asp:TextBox ID="txtProductID" runat="server" CssClass="form-control" placeholder="Product ID"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="form-label">Order Date</label>
                    <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-control" placeholder="yyyy-mm-dd"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="form-label">Total Price</label>
                    <asp:TextBox ID="txtTotalPrice" runat="server" CssClass="form-control" placeholder="Total Price (£)"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="form-label">Order Status</label>
                    <asp:TextBox ID="txtOrderStatus" runat="server" CssClass="form-control" placeholder="Order Status"></asp:TextBox>
                </div>

                <div class="checkbox">
                    <asp:CheckBox ID="chkIsCancelled" runat="server" Text="Cancelled" ForeColor="White" />
                </div>

                <asp:Label ID="lblError" runat="server"></asp:Label>

                <div class="btn-section">
                    <asp:Button ID="btnOK" runat="server" CssClass="btn-custom" Text="OK" OnClick="btnOK_Click" />
                    <asp:Button ID="btnCancel" runat="server" CssClass="btn-custom" Text="Cancel" OnClick="btnCancel_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
