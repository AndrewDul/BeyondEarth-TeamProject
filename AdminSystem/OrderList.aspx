<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 530px;
            width: 1439px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="335px" Width="650px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Height="40px" OnClick="btnAdd_Click" Text="Add" Width="62px" style="top: 394px; left: 10px; position: absolute; height: 44px; width: 70px" />
        <asp:Label ID="lblError" runat="server" style="top: 472px; left: 33px; position: absolute; height: 29px; width: 130px; right: 788px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="top: 393px; left: 225px; position: absolute; height: 44px; width: 70px" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="top: 394px; left: 114px; position: absolute; height: 44px; width: 70px" Text="Edit" />
    </form>
</body>
</html>
