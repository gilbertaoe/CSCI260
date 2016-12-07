<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="InvalidInput.aspx.vb" Inherits="WebApplication1.InvalidInput" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Your Input was invalid!</p>
    <div align="center">
        <asp:Button ID="btnSubmit" runat="server" Text="Go Back To Home Page" onclick="GoHome_Click" />
    </div>
</asp:Content>
