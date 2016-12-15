<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="right">
        <asp:Button runat="server" Text="Sign Up!" OnClick="Sign_Up"/>
    </div>
    <br /><br /><br />
    <div align="center">
        <tt>Username: </tt>
        <input id="username" name="username" type="Text" />
        <tt>Password: </tt>
        <input id="password" name="password" type="Text" />
        <br />
        <asp:RadioButtonList ID="selection" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Text="Admin" Value="Admin" />
            <asp:ListItem Text="Customer" Value="Customer" />
        </asp:RadioButtonList>
        <br />
        <asp:Button runat="server" Text="Sign In!" OnClick="Unnamed_Click" />
    </div>

</asp:Content>
