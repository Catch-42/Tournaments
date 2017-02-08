<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tournaments._Default" %>

<%@ Register Src="~/ViewControls/PlayersUserControl.ascx" TagPrefix="uc" TagName="players" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="well content-container-even">
        <uc:players runat="server" />
    </div>
    <div class="well content-container-even">
        <uc:players runat="server" />
    </div>
    <div class="well content-container-even">
        <uc:players runat="server" />
    </div>
</asp:Content>
