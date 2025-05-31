<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderStatistics.aspx.cs" Inherits="OrderStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 755px;
        }
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 800px; width: 1360px">
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
            <asp:GridView ID="GridViewStGroupedByOrderDate" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="top: 152px; left: 52px; position: absolute; height: 152px; width: 232px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:GridView ID="GridViewStGroupByStatus" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="top: 157px; left: 479px; position: absolute; height: 152px; width: 232px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:Label ID="lblStHeader" runat="server" style="top: 40px; left: 52px; position: absolute; height: 44px; width: 275px; font-size: xx-large; text-align: left" Text="Statistics Page"></asp:Label>
            <asp:Label ID="lblStOrderByDate" runat="server" style="top: 119px; left: 41px; position: absolute; height: 22px; width: 268px" Text="Order List - Grouped by Date"></asp:Label>
            <asp:Button ID="btnPreviousPage" runat="server" OnClick="btnPreviousPage_Click" style="top: 408px; left: 320px; position: absolute; height: 40px; width: 138px" Text="PreviousPage" />
            <asp:Label ID="lblStbyStatus" runat="server" style="top: 117px; left: 472px; position: absolute; height: 22px; width: 280px" Text="Order List - Grouped by Status"></asp:Label>
        </div>
    </form>
</body>
</html>
