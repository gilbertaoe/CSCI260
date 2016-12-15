<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CustomerListing.aspx.vb" Inherits="WebApplication1.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <asp:GridView runat="server" ID="Table" AutoGenerateColumns="false">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
            <Columns>
                <asp:BoundField DataField="CID" HeaderText="CID" ItemStyle-Width="150" />
                <asp:TemplateField HeaderText = "Customers" ItemStyle-Width="30">
                    <ItemTemplate>
                        <asp:HyperLink runat="server" Text='<%# Eval("Name") %>' NavigateUrl='<%# Eval("Name", "~/AdminCustomerDetails.aspx?Details={0}") %>' />
                         <!--NavigateUrl='<%'# Eval("GID", "~/Details.aspx?Id={0}") %>'-->
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Amount" HeaderText="Amount" ItemStyle-Width="150" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button runat="server" Text="Go Back to Admin Hub" OnClick="Unnamed_Click" />
    </div>
</asp:Content>
