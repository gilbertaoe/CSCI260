<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WipeTable.aspx.vb" Inherits="WebApplication1.WipeGames" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                <%WebApplication1.wipe.wipe()%>;
    <p>Your database has been wiped!</p>
</asp:Content>
