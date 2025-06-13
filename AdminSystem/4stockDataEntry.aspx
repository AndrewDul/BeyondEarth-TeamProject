<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4stockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 500px;
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 68px; position: absolute; bottom: 588px" Text="StockName" width="106px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 11px; top: 106px; position: absolute; bottom: 551px" Text="StockCode" width="106px"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 151px; top: 64px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStockSellingPrice" runat="server" style="z-index: 1; left: 151px; top: 160px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStockStatus" runat="server" style="z-index: 1; left: 151px; top: 275px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStockExpiryDate" runat="server" style="z-index: 1; left: 151px; top: 330px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtQuantityInStock" runat="server" style="z-index: 1; left: 151px; top: 220px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStockCode" runat="server" style="z-index: 1; left: 151px; top: 111px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 18px; top: 329px; position: absolute; width: 106px; height: 19px" Text="StockExpiryDate"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 25px; top: 25px; position: absolute; bottom: 618px" Text="StockId" width="106px"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 105px; top: 393px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 16px; top: 162px; position: absolute" Text="StockSellingPrice"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 15px; top: 216px; position: absolute" Text="QuantityInStock" width="106px"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 22px; top: 273px; position: absolute" Text="StockStatus" width="106px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 171px; top: 363px; position: absolute" Text="Active" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 118px; top: 437px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; top: 440px; position: absolute; left: 30px" Text="OK" />
        <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 151px; top: 24px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
