<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            This is the ConfirmDelete Data Entry Page</p>
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Customer Id"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 115px; top: 96px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblFirstNameId" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="First Name ID"></asp:Label>
            <asp:TextBox ID="txtFirstNameId" runat="server" style="z-index: 1; left: 115px; top: 129px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtLastNameId" runat="server" style="z-index: 1; left: 116px; top: 171px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblLastNameId" runat="server" style="z-index: 1; left: 12px; top: 165px; position: absolute" Text="Last Name ID"></asp:Label>
    </form>
</body>
</html>
