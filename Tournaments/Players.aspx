<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="Tournaments.Players" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row well content-container-even">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id"></asp:BoundField>
                <asp:BoundField HeaderText="First name" DataField="FirstName"></asp:BoundField>
                <asp:BoundField HeaderText="Last Name" DataField="LastName"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
