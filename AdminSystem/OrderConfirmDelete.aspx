<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 461px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="top: 160px; left: 84px; position: absolute; height: 44px; width: 70px" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="top: 160px; left: 213px; position: absolute; height: 44px; width: 70px" Text="No" />
            <asp:Label ID="Label1" runat="server" style="top: 100px; left: 38px; position: absolute; height: 22px; width: 383px" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
    </form>
</body>
</html>
