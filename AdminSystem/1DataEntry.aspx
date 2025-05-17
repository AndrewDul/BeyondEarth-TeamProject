<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            This is Order Managment</p>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 39px; top: 86px; position: absolute" Text="OrderID"></asp:Label>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged" style="z-index: 1; left: 123px; top: 81px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 122px; top: 125px; position: absolute; height: 19px"></asp:TextBox>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 28px; top: 130px; position: absolute" Text="CustomerID"></asp:Label>
        </p>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 123px; top: 169px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtIsCancelled" runat="server" style="z-index: 1; left: 118px; top: 327px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 122px; top: 206px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; left: 119px; top: 288px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 121px; top: 248px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 31px; top: 169px; position: absolute; width: 83px" Text="ProductID"></asp:Label>
            <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 32px; top: 251px; position: absolute" Text="TotalPrice"></asp:Label>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 29px; top: 209px; position: absolute" Text="OrderDate"></asp:Label>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 27px; top: 291px; position: absolute" Text="OrderStatus"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblIsCancelled" runat="server" style="z-index: 1; left: 32px; position: absolute; top: 329px" Text="IsCancelled"></asp:Label>
    </form>
</body>
</html>
