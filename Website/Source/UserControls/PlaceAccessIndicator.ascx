<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PlaceAccessIndicator.ascx.cs" Inherits="Roblox.Website.UserControls.PlaceAccessIndicator" %>
<span class="PlaceAccessIndicator">
	<span ID="FriendsOnlyLocked" style="display: none" runat="server">
        <a class="iLocked tooltip" title="Friends Only"></a><span class="invisible">&nbsp;Friends-only</span>
	</span>
    <span ID="FriendsOnlyUnlocked" style="display: none" runat="server">
        <a class="iUnlocked tooltip" title="Friends Only - You are friends"></a><span class="invisible">&nbsp;Friends-only: You are friends</span>
	</span>
	<span ID="ExpiredSelf" style="display: none" runat="server">
        <a class="iLocked tooltip" title="Locked"></a>
        <span class="invisible">&nbsp;Your Outrageous Builders Club, Turbo Builders Club, or Builders Club membership has expired, so you can
        only have one open place. Your places will not be deleted, and you can <asp:HyperLink ID="RBXLDownloadLink" Text="download the RBXL here." runat="server" /> To unlock all of your places,
        please <a href="/upgrades/BuildersClubMemberships.aspx">re-order Outrageous Builders Club, Turbo Builders Club, or Builders
            Club </a>.<br /></span>
    </span>
    <span ID="ExpiredOther" style="display: none" runat="server">
        <a class="iLocked tooltip" title="Locked"></a>
        <span class="invisible">This place is locked because the creator's <a href="/upgrades/BuildersClubMemberships.aspx">Builders
            Club / Turbo Builders Club / Outrageous Builders Club </a>has expired.
		</span>
	</span>	
</span>
	