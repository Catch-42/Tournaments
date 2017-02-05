<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teams.aspx.cs" Inherits="Tournaments.Teams" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id"></asp:BoundField>
                    <asp:BoundField HeaderText="Team name" DataField="Name"></asp:BoundField>
                    <asp:BoundField HeaderText="Rating" DataField="Rating"></asp:BoundField>

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
