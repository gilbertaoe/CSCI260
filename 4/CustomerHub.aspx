<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CustomerHub.aspx.vb" Inherits="WebApplication1.CustomerHub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="right">
        <asp:Button runat="server" ID="account" OnClick="toAccount" Text="Your Account" /><asp:Button runat="server" Text="Cart" ID="cart" OnClick="toCart" /><asp:Button runat="server" Text="Sign Out" ID="signOut" OnClick="signCustomerOut" />
    </div>
    <br /><br /><br />
    <div align="center">
        <input id="search" name="search" type="text" /><asp:Button runat="server" Text="Seach" ID="searchButton" OnClick="startSearch" />
    </div>
</asp:Content>
