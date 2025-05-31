<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 675px;
            width: 1439px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Height="335px" Width="1010px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Height="40px" OnClick="btnAdd_Click" Text="Add" Width="62px" style="top: 396px; left: 17px; position: absolute; height: 44px; width: 70px" />
        <asp:Label ID="lblError" runat="server" style="top: 633px; left: 33px; position: absolute; height: 29px; width: 131px; right: 960px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="top: 393px; left: 225px; position: absolute; height: 44px; width: 70px" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="top: 394px; left: 114px; position: absolute; height: 44px; width: 70px" Text="Edit" />
        <asp:Label ID="lblStatus" runat="server" style="top: 491px; left: 33px; position: absolute; height: 22px; width: 129px" Text="Enter a Status"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"  style="top: 483px; left: 162px; position: absolute; height: 25px; width: 168px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="top: 548px; left: 50px; position: absolute; height: 40px; width: 110px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" style="top: 547px; left: 216px; position: absolute; height: 40px; width: 110px" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        <asp:Button ID="btnToStPage" runat="server" OnClick="btnToStPage_Click" style="top: 546px; left: 410px; position: absolute; height: 40px; width: 161px" Text="Statistics Page" />
        <asp:Button ID="btnReturn" runat="server" ClientIDMode="Static" OnClick="btnReturn_Click" style="top: 473px; left: 411px; position: absolute; height: 40px; width: 160px" Text="Return to Main Menu" />
    </form>
</body>
</html>
