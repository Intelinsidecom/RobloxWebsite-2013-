<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Alerts.ascx.cs" Inherits="Roblox.Website.UserControls.Alerts" %>
<asp:Panel ID="AlertSpacePanel" runat="server">
    <div class="SmallHeaderAlertSpaceLeft">
        <div class="AlertSpace">
            <div class="MessageAlert">
                <asp:HyperLink ID="MessageAlertCaptionHyperLink" CssClass="MessageAlertCaption tooltip-bottom" ToolTip="Inbox" NavigateUrl="/my/messages" runat="server" />
            </div>
            <div class="FriendsAlert">
                <asp:HyperLink ID="FriendsAlertCaptionHyperLink" CssClass="FriendsAlertCaption tooltip-bottom" ToolTip="Friend Requests" NavigateUrl="~/Friends.aspx" runat="server" />
            </div>
            <div class="RobuxAlert">
                <asp:HyperLink ID="RobuxAlertCaptionHyperLink" CssClass="RobuxAlertCaption tooltip-bottom" ToolTip="ROBUX" NavigateUrl="~/My/Money.aspx?tab=MyTransactions" runat="server" />
            </div>
            <div class="TicketsAlert">
                <asp:HyperLink ID="TicketsAlertCaptionHyperLink" CssClass="TicketsAlertCaption tooltip-bottom" ToolTip="Tickets" NavigateUrl="~/My/Money.aspx?tab=MyTransactions" runat="server" />
            </div>
        </div>
    </div>
</asp:Panel>