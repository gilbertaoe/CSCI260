<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="DeleteConfirm.aspx.vb" Inherits="WebApplication1.DeleteConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>The developer has been delete along with all it's games.</p>
    <div align="center">
        <asp:Button ID="btnSubmit" runat="server" Text="Go Back To Home Page" onclick="GoHome_Click" />
    </div>
</asp:Content>
