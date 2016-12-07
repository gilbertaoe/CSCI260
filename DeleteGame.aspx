<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteGame.aspx.vb" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">    
    </asp:DropDownList>

    <asp:Button ID="btnSubmit" runat="server" Text="Delete Game" onclick="Delete_Click" />
</asp:Content>
