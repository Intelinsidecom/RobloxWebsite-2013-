<%@ Page Title="Site Offline" Language="C#" MasterPageFile="~/Simple.Master" AutoEventWireup="true" CodeBehind="FulfillConstraint.aspx.cs" Inherits="Roblox.Website.Login.FulfillConstraint" %>
<asp:Content ID="RobloxContent" ContentPlaceHolderID="cphRoblox" runat="server">
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        <%--http://c0.roblox.com/robloxteamsitedownimage1--%>
        <asp:Image ImageUrl="~/Images/ErrorPages/Maintenance.png" ID="imgRobloxTeam" ToolTip="Offline" runat="server" /></p>
    <h3 style="text-align: center">
        The site is currently offline for maintenance and upgrades. Please check back soon!
    </h3>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <p>
        <asp:TextBox type="password" ID="Textbox1" runat="server"/>
        <asp:Button Text="R" ID="Button1" OnClick="Button_OnClick" runat="server"/>
        <asp:Button Text="O" ID="Button2" OnClick="Button_OnClick" runat="server"/>
        <asp:Button Text="B" ID="Button3" OnClick="Button_OnClick" runat="server"/>
        <asp:Button Text="L" ID="Button4" OnClick="Button_OnClick" runat="server"/>
        <asp:Button Text="O" ID="Button5" OnClick="Button_OnClick" runat="server"/>
        <asp:Button Text="X" ID="Button6" OnClick="Button_OnClick" runat="server"/>

</asp:Content>