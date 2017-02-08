<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerInput.aspx.cs" Inherits="Tournaments.PlayerInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
   
    </div>
        <p>
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="ButtonSendPlayer" runat="server" Text="Button" OnClick="ButtonSendPlayer_Click"/>
    </form>
</body>
</html>
