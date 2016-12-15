<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Cart.aspx.vb" Inherits="WebApplication1.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="right">
        <asp:Button runat="server" ID="hub" OnClick="CustomerHub" /><asp:Button runat="server" ID="account" OnClick="toAccount" Text="Your Account" /><asp:Button runat="server" Text="Cart" ID="cart" OnClick="toCart" /><asp:Button runat="server" Text="Sign Out" ID="signOut" OnClick="signCustomerOut" />
    </div>
    <br /><br /><br />
    <div align="center">
         <asp:GridView runat="server" ID="grid" AutoGenerateColumns="true">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
            <Columns>
                <asp:TemplateField HeaderText = "Title" ItemStyle-Width="50">
                    <ItemTemplate>
                        <asp:RadioButton ID="RowSelector" runat="server" onclick="checkRadioBtn(this);" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label runat="server" ID="tot"/>
        <br /><br />
        <asp:Button runat="server" Text="Delete Selected From Cart" OnClick="deleteFromCart" />
        <asp:Button runat="server" Text="Purchase Games" OnClick="purchaseGame" />
    </div>
    <script type="text/javascript">
        function checkRadioBtn(id)
        {
            var gv = document.getElementById('<%=grid.ClientID %>');

            for (var i = 1; i < gv.rows.length; i++)
            {
                var radioBtn = gv.rows[i].cells[0].getElementsByTagName("input");

                // Check if the id not same
                if (radioBtn[0].id != id.id)
                {
                    radioBtn[0].checked = false;
                }
            }
        }
    </script>
</asp:Content>
