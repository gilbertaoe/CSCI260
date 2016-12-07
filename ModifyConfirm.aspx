<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ModifyConfirm.aspx.vb" Inherits="WebApplication1.ModifyConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>The data has been modified!</p>
    <div align="center">
        <asp:Button ID="btnSubmit" runat="server" Text="Go Back To Home Page" onclick="GoHome_Click" />
    </div>
</asp:Content>
