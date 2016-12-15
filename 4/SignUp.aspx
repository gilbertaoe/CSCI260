<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="SignUp.aspx.vb" Inherits="WebApplication1.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <asp:Label runat="server" Text="Username: "></asp:Label><asp:TextBox runat="server" ID="userName"></asp:TextBox>
        <asp:Label runat="server" Text="Password: "></asp:Label><asp:TextBox runat="server" ID="password"></asp:TextBox>
        <asp:Button runat="server" OnClick="Unnamed_Click" />
    </div>
</asp:Content>
