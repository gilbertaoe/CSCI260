<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="searchResults.aspx.vb" Inherits="WebApplication1.searchResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="right">
        <asp:Button runat="server" ID="account" OnClick="toAccount" Text="Your Account" /><asp:Button runat="server" Text="Cart" ID="cart" OnClick="toCart" /><asp:Button runat="server" Text="Sign Out" ID="signOut" OnClick="signCustomerOut" />
    </div>
    <br /><br /><br />
    <div align="center">
         <asp:GridView runat="server" ID="grid" AutoGenerateColumns="false">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
            <Columns>
                <asp:TemplateField HeaderText = "Title" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkRow" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText = "Title" ItemStyle-Width="50">
                    <ItemTemplate>
                         <asp:LinkButton ID="Name" runat="server" Text='<%# Eval("Title") %>' OnClick="Name_Click" CommandArgument='<%# Eval("Title") %>' />
                         <!--NavigateUrl='<%'# Eval("GID", "~/Details.aspx?Id={0}") %>'-->
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br /><br />
        <asp:Button runat="server" Text="Add To Cart" OnClick="AddToCart" />
    </div>
</asp:Content>
