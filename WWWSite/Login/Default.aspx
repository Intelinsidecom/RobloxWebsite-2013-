<%@ Page Title="" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Roblox.Website.Login.Default" %>
<asp:Content ID="Default" ContentPlaceHolderID="cphRoblox" runat="server">
    <asp:Login ID="aspLogin" MembershipProvider="RobloxMembershipProvider" runat="server"></asp:Login>
</asp:Content>