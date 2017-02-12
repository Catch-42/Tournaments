<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="Tournaments.Players" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id"></asp:BoundField>
                    <asp:BoundField HeaderText="First name" DataField="FirstName"></asp:BoundField>
                    <asp:BoundField HeaderText="Last Name" DataField="LastName"></asp:BoundField>
                </Columns>
            </asp:GridView>
    </form>
</body>
</html>
