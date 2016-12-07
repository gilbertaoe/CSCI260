<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="InsertFeature.aspx.vb" Inherits="WebApplication1.InsertFeature" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <input type="text"  name="featureName" value="">

    <asp:Button ID="Button1" runat="server" Text="Insert Feature" onclick="Insert_Click" />
</asp:Content>
