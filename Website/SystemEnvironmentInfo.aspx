<%@ Page Title="ROBLOX System Environment Information" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="SystemEnvironmentInfo.aspx.cs" Inherits="Roblox.Website.SystemEnvironmentInfo" %>
<asp:Content ID="Default" ContentPlaceHolderID="cphRoblox" runat="server">
    <h1>System Environment Information (<asp:Label runat="server" ID="lblEnvAbbrevId" />)</h1>
    <div><asp:Label ID="nameLabel" CssClass="settingLabel form-label" runat="server">Name:</asp:Label><span><asp:Label runat="server" ID="lblEnvName" /></span></div>
    <div><asp:Label ID="machineIdLabel" CssClass="settingLabel form-label" runat="server">Machine ID:</asp:Label><span><asp:Label runat="server" ID="lblMachine" /></span></div>
    <div><asp:Label ID="domainLabel" CssClass="settingLabel form-label" runat="server">Domain:</asp:Label><span><asp:Label runat="server" ID="lblDomain" /></span></div>
    <div><asp:Label ID="websiteUrlLabel" CssClass="settingLabel form-label" runat="server">WebsiteUrl:</asp:Label><a runat="server" id="lnkWebsite" /></div>
    <div><asp:Label ID="testLabel" CssClass="settingLabel form-label" runat="server">ApplicationURL:</asp:Label><span><asp:Label runat="server" ID="lblAppUrl" /></span></div>
    <div style="margin-top:1rem"><asp:Label ID="lblStatus" runat="server" /></div>
</asp:Content>