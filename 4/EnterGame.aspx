<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="EnterGame.aspx.vb" Inherits="WebApplication1.EnterGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <b>Game Title: </b>
    <input type="text" name="gameTitle" value=""/>
    <b>Game Amount: </b>
    <input type="text" name="gameAmount" value=""/>

    <asp:Button ID="btnSubmit" runat="server" Text="Delete Game" onclick="Insert_Click" />
</asp:Content>
