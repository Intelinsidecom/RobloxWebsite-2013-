<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ModerationCard.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.Users.ModerationCard" %>
<%@ Register assembly="Roblox.Controls" namespace="Roblox.Controls" tagprefix="rbx" %>

<rbx:Panel ID="pnlModerationCard"
    BackColor="Khaki" ForeColor="White"
    BodyStyle-Height="200px"
    runat="server">
    <Header>
        <div style="margin-top: 5px; margin-bottom: 5px"><span><%# UserName %></span><span class="rightCaption"><%# MembershipText %></span></div>
    </Header>
    <Content>
        <rbx:Image ID="rbxAvatarImage" style="float: left" ImageUrl="~/Images/Accounts/boy.png" runat="server" />
        <table ID="tblModerationCard" class="ModerationCard">
            <tr><th>Moderation</th></tr>
            <tr><td><asp:Image ID="iOnlineStatus" ImageUrl="<%# OnlineStatusImageUrl %>" runat="server" />&nbsp;<%# LocationText %></td></tr>
            <tr><td><asp:HyperLink ID="hlVisitProfile" NavigateUrl='<%# $"~/User.aspx?ID={UserID}" %>' Text="Visit Profile" runat="server" /></td></tr>
            <tr><td><asp:HyperLink ID="hlVisitModerationProfile" NavigateUrl='<%# $"~/Admi/Users/Moderate.aspx?ID={UserID}" %>' Text="Visit Moderation Profile" runat="server" /></td></tr>
            <tr><td><asp:HyperLink ID="hlVisitAdminProfile" NavigateUrl='<%# $"~/Admi/Users/UserAdmin.aspx?ID={UserID}" %>' Text="Visit Admin Profile" runat="server" /></td></tr>
            <tr><td><b>Moderation Status: </b> <%# ModerationStatus %></td></tr>
            <tr><th>Information</th></tr>
            <tr><td><b>Robux: </b ><%# RobuxCount %></td></tr>
            <tr><td><b>Tickets: </b> <%# TicketsCount %></td></tr>
            <tr><td><b>Messages: </b> <%# MessageCount %></td></tr>
            <tr><td><b>Created: </b> <%# CreatedDate.ToShortDateString() %></td></tr>
            <tr><td><b>Age Bracket: </b> <%# AgeBracket %></td></tr>
        </table>
    </Content>
    <Footer>
        <span style="text-align: left">Moderation Card</span>
    </Footer>
</rbx:Panel>