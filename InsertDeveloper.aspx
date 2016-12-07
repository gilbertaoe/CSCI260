<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="InsertDeveloper.aspx.vb" Inherits="WebApplication1.InsertDeveloper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <input type="text"  name="developerName" value="">

    <asp:Button ID="Button1" runat="server" Text="Insert Developer" onclick="Insert_Click" />
</asp:Content>
