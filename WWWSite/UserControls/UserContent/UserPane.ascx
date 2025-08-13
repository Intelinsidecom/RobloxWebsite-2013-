<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserPane.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.UserPane" %>
<%@ Import Namespace="Roblox.Website.ViewModels.Users.Shared" %>
<%@ Import Namespace="Roblox.Web.Code.Util" %>
<%@ Register Assembly="Roblox.Controls" Namespace="Roblox.Controls" TagPrefix="rbx" %>
<%@ Register Src="~/UserControls/UserContent/PublicUser.ascx" TagName="PublicUser" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Abuse/ReportAbuseButton.ascx" TagName="ReportAbuseButton" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Alerts.ascx" TagName="Alerts" TagPrefix="rbx"%>

<%if (UserProfile != null) {%>
<h2 class="title">
    <asp:Label ID="lUserRobloxURL" runat="server" /></h2>
<div class="divider-bottom" style="position: relative;z-index:3;padding-bottom: 20px">
    <div style="width: 100%">
        <div ID="onlineStatusRow" runat="server">
            <div style="text-align: center;">
                <% if (UserProfile.UserPrecenceType < PresenceType.InGame) {%>
                <asp:Label ID="lUserOnlineStatus" runat="server" />
                <% } else {%>
                <asp:HyperLink ID="UserOnlineStatusHyperLink" style="clear: none" runat="server" />
                <% } %>
            </div>
        </div>
        <div>
            <div>
                <center class="UserPaneContainer">
                    <div style="margin-bottom: 10px;">
                        <asp:Panel ID="pnlViewPublic" Visible="false" style="font-size: 13px;" runat="server">
                            <asp:HyperLink NavigateUrl="~/User.aspx?ID={0}&ForcePublicView=true" ID="lnkPublicView" runat="server" />
                        </asp:Panel>
                    </div>
                    <rbx:Image ID="AvatarImage" Enabled="False" Width="352" Height="352" runat="server" />
                    <!--a id="ctl00_cphRoblox_rbxUserPane_AvatarImage" disabled="disabled" class=" notranslate" title="LonelyJewel" class=" notranslate" onclick="return false" style="display:inline-block;height:352px;width:352px;"><img src="/Images/Accounts/boy.png" height="352" width="352" border="0" onerror="return Roblox.Controls.Image.OnError(this)" alt="LonelyJewel" class=" notranslate" /><img src="/images/icons/overlay_obcOnly.png" align="left" style="position:relative;top:-19px;" /></a-->
                    <br />
                    <% if (UserProfile.CanSeePoints) { %>
                    <div class="PointsContainer">
                        <% if (UserProfile.UserPoints > 0) { %>
                        <img class="points-image" src="http://images.rbxcdn.com/d73731e112f8a06ce3978d7755b2ab8d.png" alt="User Points"/><span class="points-text"><%=Resources.GetString("LabelUserPoints")%>: <span class="roblox-se-player-points " title="<%=UserProfile.UserPoints.ToString("N0") %>"><%=Abbreviate.GetAbbreviatedValue(UserProfile.UserPoints) %></span></span>
                        <% } %>
                        <% if (UserProfile.ClanPoints > 0) { %>
                        <img class="points-image" src="http://images.rbxcdn.com/bc098f092137c381dd5b519280e2dc35.png" alt="<%=Resources.GetString("LabelClanPoints")%>"/><span class="points-text"><%=Resources.GetString("LabelClanPoints")%>: <span class="roblox-se-clan-points tooltip-bottom" title="<%=UserProfile.ClanPoints.ToString("N0") %>"><%=Abbreviate.GetAbbreviatedValue(UserProfile.ClanPoints) %></span></span>
                        <% } %>
                    </div>
                    <% } %>
                    <% if (UserProfile.CanSeePrimaryGroup) { %>
                    <div ID="PrimaryGroupContainer" style="margin-top:10px;font-size:10px">
                        <div>
                            <b><%=Resources.GetString("LabelPrimaryGroup")%>:</b>
                            <br />
                            <rbx:Image ID="PrimaryGroupAssetImage" NavigateUrl="/groups/group.aspx?gid={0}" Width="42" Height="42" runat="server" />
                            <br />
                            <asp:HyperLink ID="HyperLink1" NavigateUrl="groups/group.aspx?gid={0}" runat="server" />
                        </div>
                    </div>
                    <% } %>
                    <% if (!UserProfile.MayEdit) { %><rbx:PublicUser ID="rbxPublicUser" runat="server" /><% } %>

                    <div class="ProfileAlertPanel" style='<% if (!UserProfile.MayEdit) { %>display: none;<% } %> margin: 15px auto 0px auto; width: 205px;'>
                        <rbx:Alerts ID="Alerts1" runat="server" />
                        <br />
                    </div>
                    <div style="margin-right: 20px">
                        <rbx:ReportAbuseButton ID="AbuseReportButton" runat="server" />
                    </div>
                    <asp:Label ID="PreviousUserNames" Visible="false" style="text-align:center;" runat="server" />
                </center>
            </div>
        </div>
    </div>
</div>
<% } %>