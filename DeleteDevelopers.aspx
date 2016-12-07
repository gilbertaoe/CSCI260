<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="DeleteDevelopers.aspx.vb" Inherits="WebApplication1.DeleteDevelopers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>Warning! This will delete all games under this developer!!!</p>

    <asp:DropDownList ID="DropDownList1" runat="server">    
    </asp:DropDownList>

    <asp:Button ID="btnSubmit" runat="server" Text="Delete Developer" onclick="Delete_Click" />
</asp:Content>
