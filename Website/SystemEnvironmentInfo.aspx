<%@ Page Title="ROBLOX System Environment Information" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="SystemEnvironmentInfo.aspx.cs" Inherits="Roblox.Website.SystemEnvironmentInfo" %>
<%@ Import Namespace="Roblox.Configuration" %>
<asp:Content ID="Default" ContentPlaceHolderID="cphRoblox" runat="server">
    <h1>System Environment Information (<%=RobloxEnvironment.Abbreviation + RobloxEnvironment.Id%>)</h1>
    <div><asp:Label ID="nameLabel" class="settingLabel form-label" runat="server">Name:</asp:Label><span><%=RobloxEnvironment.Name%></span></div>
    <div><asp:Label ID="machineIdLabel" class="settingLabel form-label" runat="server">Machine ID:</asp:Label><span><%=System.Environment.MachineName%></span></div>
    <div><asp:Label ID="domainLabel" class="settingLabel form-label" runat="server">Domain:</asp:Label><span><%=RobloxEnvironment.Domain%></span></div>
    <div><asp:Label ID="websiteUrlLabel" class="settingLabel form-label" runat="server">WebsiteUrl:</asp:Label><a href="<%=RobloxEnvironment.WebsiteUrl%>"><%=RobloxEnvironment.WebsiteUrl%></a></div>
    <div><asp:Label ID="testLabel" class="settingLabel form-label" runat="server">ApplicationURL:</asp:Label><span><%=Roblox.WebsiteSettings.Properties.Settings.Default.ApplicationURL%></span></div>
</asp:Content>