<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserBadgesPane.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.UserBadgesPane" %>

<% if (UserProfile != null) { %>
<h2 class="title">
<span><%=Resources.GetString("HeadingRobloxBadges")%></span>
</h2>

<div class="divider-bottom" style="padding-bottom: 20px">
    <div style="display: inline-block; position: relative; left: -8px;">
        <asp:DataList ID="dlBadges" runat="server"> <%-- DataSourceID="RobloxBadgesDataSource" --%>
            <ItemTemplate>
		        <td valign="top">
			        <div class="Badge" class="notranslate">
				        <div class="BadgeImage"><asp:HyperLink ID="hlHeader" NavigateUrl='<%#Eval("ID", "~/Badges.aspx#Badge{0}") %>' runat="server"><asp:Image ID="iBadge" ImageUrl='<%#Eval("ImageUrl") %>' ToolTip='<%#Eval("Description") %>' Width="75" Height="75" runat="server" /></asp:HyperLink></div>
				        <div class="BadgeLabel"><asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("ID", "~/Badges.aspx#Badge{0}") %>' Text='<%#Eval("Name") %>' runat="server" /></div>
			        </div>
		        </td>
            </ItemTemplate>
        </asp:DataList>
        <%--asp:ObjectDataSource runat="server" ID="RobloxBadgesDataSource" /--%>
        <!--table id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges" cellspacing="0" align="Left" border="0" style="border-collapse:collapse;">
	<tr>
		<td valign="top">
			    <div class="Badge" class="notranslate">
				    <div class="BadgeImage"><a id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl00_hlHeader" href="Badges.aspx#Badge2"><img id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl00_iBadge" src="http://images.rbxcdn.com/5eb20917cf530583e2641c0e1f7ba95e.png" alt="This badge is given to players who have embraced the Roblox community and have made at least 20 friends. People who have this badge are good people to know and can probably help you out if you are having trouble." style="height:75px;width:75px;border-width:0px;" /></a></div>
				    <div class="BadgeLabel"><a id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl00_HyperLink1" href="Badges.aspx#Badge2">Friendship</a></div>
			    </div>
		    </td><td valign="top">
			    <div class="Badge" class="notranslate">
				    <div class="BadgeImage"><a id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl01_hlHeader" href="Badges.aspx#Badge3"><img id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl01_iBadge" src="http://images.rbxcdn.com/8d77254fc1e6d904fd3ded29dfca28cb.png" alt="This badge is given to any player who has proven his or her combat abilities by accumulating 10 victories in battle. Players who have this badge are not complete newbies and probably know how to handle their weapons." style="height:75px;width:75px;border-width:0px;" /></a></div>
				    <div class="BadgeLabel"><a id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl01_HyperLink1" href="Badges.aspx#Badge3">Combat Initiation</a></div>
			    </div>
		    </td><td valign="top">
			    <div class="Badge" class="notranslate">
				    <div class="BadgeImage"><a id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl02_hlHeader" href="Badges.aspx#Badge4"><img id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl02_iBadge" src="http://images.rbxcdn.com/0a010c31a8b482731114810590553be3.png" alt="This badge is given to the warriors of Robloxia, who have time and time again overwhelmed their foes in battle. To earn this badge, you must rack up 100 knockouts. Anyone with this badge knows what to do in a fight!" style="height:75px;width:75px;border-width:0px;" /></a></div>
				    <div class="BadgeLabel"><a id="ctl00_cphRoblox_rbxUserBadgesPane_dlBadges_ctl02_HyperLink1" href="Badges.aspx#Badge4">Warrior</a></div>
			    </div>
		    </td><td></td><td></td>
	</tr>
</table-->
	    
    </div>
</div>
<% } %>