<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AdminGameDetails.aspx.vb" Inherits="WebApplication1.AdminGameDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <h5>Customers that have bought <%# Request("Details") %></h5>
        <asp:GridView runat="server" ID="Table">
                 <HeaderStyle CssClass="GridHead" />
                <RowStyle CssClass="GridRow" />
        </asp:GridView>
        <br />
        <asp:Button runat="server" Text="Go Back To Game Listing" OnClick="Unnamed_Click" />
    </div>
</asp:Content>
