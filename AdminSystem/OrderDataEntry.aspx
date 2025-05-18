<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 345px">
    <form id="form1" runat="server">
        <p>
            This is Order Managment</p>
        <asp:Label ID="lblOrderID" runat="server" height="19px" style="z-index: 1; left: 29px; top: 83px; position: absolute" Text="OrderID" width="83px"></asp:Label>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" height="22px" OnTextChanged="txtOrderID_TextChanged" style="z-index: 1; left: 122px; top: 81px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 121px; top: 125px; position: absolute; height: 22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblCustomerID" runat="server" height="19px" style="z-index: 1; left: 29px; top: 128px; position: absolute" Text="CustomerID" width="83px"></asp:Label>
        </p>
        <asp:TextBox ID="txtProductID" runat="server" height="22px" style="z-index: 1; left: 121px; top: 169px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 121px; top: 205px; position: absolute; width: 124px; height: 22px"></asp:TextBox>
        <asp:TextBox ID="txtOrderStatus" runat="server" height="22px" style="z-index: 1; left: 121px; top: 289px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTotalPrice" runat="server" height="22px" style="z-index: 1; left: 121px; top: 248px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 29px; top: 171px; position: absolute; width: 83px" Text="ProductID"></asp:Label>
            <asp:Label ID="lblTotalPrice" runat="server" height="19px" style="z-index: 1; left: 29px; top: 251px; position: absolute" Text="TotalPrice" width="83px"></asp:Label>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" height="19px" style="z-index: 1; left: 29px; top: 209px; position: absolute" Text="OrderDate" width="83px"></asp:Label>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" height="19px" style="z-index: 1; left: 29px; top: 291px; position: absolute" Text="OrderStatus" width="83px"></asp:Label>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkIsCancelled" runat="server" style="z-index: 1; left: 123px; top: 329px; position: absolute" Text="Cancelled" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 373px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 29px; top: 412px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 191px; top: 412px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
