<%@ Page Language="C#" AutoEventWireup="true" CodeFile="_1_DataEntry.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 66px">
    <form id="form1" runat="server">
        <p>
            This is the Data Entry Page</p>
        <p>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 118px; top: 93px; position: absolute" OnTextChanged="txtCustomerId_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 13px; top: 93px; position: absolute" Text="Customer ID" width="88px"></asp:Label>
        <asp:Label ID="lblFirstNameId" runat="server" height="19px" style="z-index: 1; left: 10px; top: 138px; position: absolute; right: 504px" Text="First Name " width="88px"></asp:Label>
        <asp:Label ID="lblLastNameId" runat="server" height="72px" style="z-index: 1; left: 10px; top: 168px; position: absolute" Text="Last Name " width="88px"></asp:Label>
        <asp:TextBox ID="txtFirstNameId" runat="server" height="22px" style="z-index: 1; left: 174px; top: 130px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblEmailAddressId" runat="server" height="72px" style="z-index: 1; left: 10px; top: 201px; position: absolute" Text="Email Address " width="88px"></asp:Label>
        <asp:TextBox ID="txtEmailAddressId" runat="server" height="22px" style="z-index: 1; left: 174px; top: 202px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtLastNameid" runat="server" height="22px" style="z-index: 1; left: 174px; position: absolute; top: 165px" width="128px"></asp:TextBox>
        <asp:Label ID="lblPostCodeId" runat="server" height="72px" style="z-index: 1; left: 12px; top: 249px; position: absolute" Text="Post Code" width="88px"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" height="22px" style="z-index: 1; left: 174px; top: 237px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 174px; top: 273px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDateAddedId" runat="server" height="22px" style="z-index: 1; left: 174px; top: 315px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 118px; top: 367px; position: absolute" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 383px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 82px; top: 429px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 28px; top: 428px; position: absolute" Text="OK" />
        <asp:Button ID="btnFind" runat="server" Height="51px" OnClick="Button1_Click1" style="float: right; margin-left: 34px;" Text="Find" Width="121px" />
        <p>
            <asp:Label ID="lblPhoneNumberId" runat="server" height="72px" style="z-index: 1; left: 8px; top: 285px; position: absolute; width: 95px" Text="Phone Number"></asp:Label>
        </p>
        <asp:Label ID="lblDateAddedId" runat="server" height="72px" style="z-index: 1; left: 7px; top: 326px; position: absolute" Text="Date Added" width="88px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
