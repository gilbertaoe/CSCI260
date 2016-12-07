<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="InsertGame.aspx.vb" Inherits="WebApplication1.InsertGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <input type="text"  name="gameName" value="">

    <asp:DropDownList ID="DevolpersDropdown" runat="server"></asp:DropDownList>

    <asp:DropDownList ID="FeaturesDropdown" runat="server"></asp:DropDownList>

    <asp:Button ID="Button1" runat="server" Text="Insert Developer" onclick="Insert_Click" />
</asp:Content>
