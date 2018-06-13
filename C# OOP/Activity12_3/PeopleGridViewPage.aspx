<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PeopleGridViewPage.aspx.cs" Inherits="PeopleGridViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvPeople" runat="server" ModelType="Person" ItemType="Person" SelectMethod="GetPeople" UpdateMethod="UpdatePeople" AutoGenerateColumns="false" AutoGenerateEditButton="true">
                <Columns>
                    <asp:BoundField DataField="PersonID" HeaderText="Person ID" ReadOnly="true" />
                    <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                    <asp:BoundField DataField="PreferredName" HeaderText="Preferred Name" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
