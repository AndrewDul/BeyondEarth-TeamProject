<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataEntry.aspx.cs" Inherits="DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Staff Data Entry</h2>

            <asp:Label ID="lblFullName" runat="server" Text="Full Name:"></asp:Label><br />
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="lblDepartment" runat="server" Text="Department:"></asp:Label><br />
            <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="lblIsActive" runat="server" Text="Is Active:"></asp:Label>
            <asp:CheckBox ID="chkIsActive" runat="server" /><br /><br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label><br /><br />

            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        </div>
    </form>
</body>
</html>
