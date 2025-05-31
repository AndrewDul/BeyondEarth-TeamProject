<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="height: 512px">
            <asp:Label ID="lblHeaderMainMenu" runat="server" style="top: 43px; left: 119px; position: absolute; height: 45px; width: 695px; font-weight: 700; font-size: xx-large; font-family: 'Times New Roman', Times, serif" Text="BeyondEarth Management System – Main Menu"></asp:Label>
            <asp:Label ID="lblsubHeaderMainMenu" runat="server" style="top: 119px; left: 279px; position: absolute; height: 34px; width: 353px; font-size: large; font-family: 'Times New Roman', Times, serif" Text="Select a section to manage system components."></asp:Label>
            <asp:Button ID="btnOrderMgmt" runat="server" OnClick="btnOrderMgmt_Click" style="top: 247px; left: 68px; position: absolute; height: 44px; width: 160px; right: 736px" Text="Order Management" />
            <asp:Button ID="Button2" runat="server" style="top: 247px; left: 283px; position: absolute; height: 44px; width: 160px" Text="Button" />
            <asp:Button ID="Button3" runat="server" style="top: 247px; left: 499px; position: absolute; height: 44px; width: 160px; right: 305px" Text="Button" />
            <asp:Button ID="Button4" runat="server" style="top: 247px; left: 718px; position: absolute; height: 44px; width: 160px" Text="Button" />
        </div>
    </form>
</body>
</html>
