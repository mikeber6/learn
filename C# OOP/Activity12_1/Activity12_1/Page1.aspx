<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Activity12_1.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 200px">
            <asp:Label ID="lblMessage" runat="server" Text="Hello Stranger..." style="z-index: 1; left: 329px; top: 65px; position: absolute"></asp:Label>
            <asp:Label ID="lblName" runat="server" Text="Enter your name:" style="z-index: 1; left: 12px; top: 64px; position: absolute"></asp:Label>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" style="z-index: 1; left: 21px; top: 176px; position: absolute" />
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 158px; top: 63px; position: absolute"></asp:TextBox>
            <asp:RadioButtonList ID="rblFontColor" runat="server" style="z-index: 1; left: 18px; top: 110px; position: absolute; height: 27px; width: 82px; margin-top: 0px" OnSelectedIndexChanged="rblFontColor_SelectedIndexChanged">
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </form>
</body>
</html>
