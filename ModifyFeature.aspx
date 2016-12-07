<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ModifyFeature.aspx.vb" Inherits="WebApplication1.ModifyFeature" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <input type="text"  name="stuff" value=""/>

    <asp:DropDownList ID="DropDownList1" runat="server">    
    </asp:DropDownList>

    <asp:Button ID="btnSubmit" runat="server" Text="Modify Developer" onclick="Modify_Click" />
</asp:Content>
