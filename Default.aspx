<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <asp:Button ID="Button2" runat="server" Text="Insert Developer" onclick="MoveInsertD_Click" />
        <asp:Button ID="Button3" runat="server" Text="Delete Developer" onclick="MoveDeleteD_Click" />
        <asp:Button ID="Button4" runat="server" Text="Modify Developer" onclick="MoveModifyD_Click" />
        <br /><br />
        <asp:GridView id="Developers" runat="server" Width="400px">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
        </asp:GridView>
    </div>
    <br /><br />
    <div align="center">
        <asp:Button ID="Button5" runat="server" Text="Insert Feature" onclick="MoveInsertF_Click" />
        <asp:Button ID="Button6" runat="server" Text="Delete Feature" onclick="MoveDeleteF_Click" />
        <asp:Button ID="Button7" runat="server" Text="Modify Feature" onclick="MoveModifyF_Click" />
        <br /><br />
        <asp:GridView id="Features" runat="server" Width="400px">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
        </asp:GridView>
    </div>
    <br /><br />
    <div align="center">
        <asp:Button ID="Button8" runat="server" Text="Insert Game" onclick="MoveInsertG_Click" />
        <asp:Button ID="Button9" runat="server" Text="Delete Game" onclick="MoveDeleteG_Click" />
        <asp:Button ID="Button10" runat="server" Text="Modify Game" onclick="MoveModifyG_Click" />
        <br /><br />
        <asp:GridView id="Games" runat="server" Width="400px">
            <HeaderStyle CssClass="GridHead" />
            <RowStyle CssClass="GridRow" />
        </asp:GridView>
    </div>
    <br /><br />
    <div align="center">
        <asp:Button ID="btnSubmit" runat="server" Text="Wipe" onclick="MoveWipe_Click" />
    </div>
</asp:Content>

