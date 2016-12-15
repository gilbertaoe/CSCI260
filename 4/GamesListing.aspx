<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GamesListing.aspx.vb" Inherits="WebApplication1.adminHub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <p>Click Button to view customers with game</p>
         <asp:GridView runat="server" ID="grid" AutoGenerateColumns="false">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
            <Columns>
                <asp:BoundField DataField="GID" HeaderText="GID" ItemStyle-Width="150" />
                <asp:TemplateField HeaderText = "Title" ItemStyle-Width="30">
                    <ItemTemplate>
                        <asp:HyperLink runat="server" Text='<%# Eval("Title") %>' NavigateUrl='<%# Eval("Title", "~/AdminGameDetails.aspx?Details={0}") %>' />
                         <!--NavigateUrl='<%'# Eval("GID", "~/Details.aspx?Id={0}") %>'-->
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Price" HeaderText="Price" ItemStyle-Width="150" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button runat="server" Text="Go Back to Admin Hub" OnClick="Unnamed_Click" />
    </div>
</asp:Content>
