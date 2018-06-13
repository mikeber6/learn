<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PeopleListPage.aspx.cs" Inherits="PeopleListPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WideWorldImportersConnectionString %>" SelectCommand="SELECT [PersonID], [FullName], [PreferredName] FROM [Application].[People]"></asp:SqlDataSource>
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("FullName") %>' />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        
    </form>
</body>
</html>
