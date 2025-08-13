<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserStatisticsPane.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.UserStatisticsPane" %>
<% if (UserProfile != null) { %>
<style>
.statsLabel { font-weight:bold; width:200px; text-align:right; padding-right:10px;}
.statsValue { font-weight:normal; width:200px; text-align:left;}
.statsTable { width:400px; }
</style>
<h2 class="title"><span><%=Resources.GetString("Heading.Statistics") %></span></h2>

<div class="divider-bottom" style="padding-bottom: 20px">
<table class="statsTable">
    <tr>
        <td class="statsLabel">
        <acronym title="The number of this user's friends.">Friends</acronym>:
        </td>
        <td class="statsValue">
        <asp:Label ID="lFriendsStatistics" Text="0" runat="server" />
        </td>
    </tr>
    <asp:Panel ID="pInvitations" Visible="false" runat="server">
	
    <tr>
        <td class="statsLabel"><acronym title="The number of friends this user has recruited to join ROBLOX.">Friends Invited</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lFriendsInvitedStatistics" CssClass="notranslate" Text="0" runat="server" /></td>
    </tr>
    
</asp:Panel>
    <tr>
        <td class="statsLabel"><acronym title="The number of posts this user has made to the ROBLOX forum.">Forum Posts</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lForumPostsStatistics" CssClass="notranslate" Text="0" runat="server" /></td>
    </tr>
    <%--tr>
        <td class="statsLabel"><acronym title="The number of times this user's profile has been viewed.">Profile Views</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lProfileViewsStatistics" Text="1,361,783,203" runat="server" /></td>
    </tr--%>
    <tr>
        <td class="statsLabel"><acronym title="The number of times this user's place has been visited.">Place Visits</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lPlaceVisitsStatistics"  CssClass="notranslate" Text="0" runat="server" /></td>
    </tr>
    <tr>
        <td class="statsLabel"><acronym title="The number of times this user's character has destroyed another user's character in-game.">Knockouts</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lKillsStatistics"  CssClass="notranslate" Text="0" runat="server" /></td>
    </tr>
    <asp:Panel ID="pDeaths" Visible="false" runat="server">
	
    <tr>
        <td class="statsLabel"><acronym title="The number of times this user's character has been destroyed in-game.">Wipeouts</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lDeathsStatistics" CssClass="notranslate" Text="0" runat="server" /></td>
    </tr>
    
</asp:Panel>
     <tr>
        <td class="statsLabel"><acronym title="The all-time highest voting accuracy this user has achieved when voting in contests.">Highest Ever Voting Accuracy</acronym>:</td>
        <td class="statsValue"><asp:Label ID="lHighestEverVotingAccuracyStatistics" Text="0" runat="server" />%</td>
    </tr>
     <asp:Panel ID="pConsecutiveDaysInBC" Visible="False" runat="server">
	
    <tr>
        <td class="statsLabel"><acronym title="The number of consecutive days this user has been in Builders Club and their corresponding loyalty multiplier.">Consecutive Days In BC</acronym>:</td>
        <td class="statsValue">909 (<a href='http://community.roblox.com/?p=4157'>3x</a>)</td>
    </tr>
    
</asp:Panel>
</table>    
</div>
<% } %>