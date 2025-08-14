<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.Dashboard" %>
<asp:Panel ID="Panel1" runat="server">
	<div>
		<div><asp:HyperLink ID="hlMachineConfig" NavigateUrl="" Text="Configs" runat="server" /> | <asp:HyperLink ID="hlMachines" NavigateUrl="" Text="Machines" runat="server" />: <asp:Label ID="MachineHealthPercentage" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" />% of <asp:Label ID="EnabledMachineCount" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /></div>
		<div><asp:HyperLink ID="hlCores" NavigateUrl="" Text="Cores" runat="server" />: <asp:Label ID="CoreUtilizationPercentage" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" />% in use of <asp:Label ID="TotalCoresAllocated" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /></div>
		<div><asp:Label ID="TotalRunningJobCount" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /> running, <asp:Label ID="TotalWaitingJobCount" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /> waiting</div>
		<hr>
	</div>
	<div>
		<asp:Label ID="TotalPlayers" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /> <asp:HyperLink ID="hlPlayers" NavigateUrl="" Text="players" runat="server" /> in <asp:Label ID="TotalGames" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /> <asp:HyperLink ID="hlGames" NavigateUrl="~/Admi/Games/Default.aspx" Text="games" runat="server" /> (<asp:Label ID="PlayerRatio" ClientIDMode="Static" Text="?:?" Font-Bold="True" runat="server" />) <asp:Label ID="LegacyJobsWaiting" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" /> <asp:HyperLink ID="hlThumbRequests" NavigateUrl="~/Admi/Thumbs.aspx" Text="thumb requests" runat="server" />
		<hr>
	</div>
	<div>
		<asp:Label ID="AbuseReports" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" />&nbsp;<asp:HyperLink ID="hlAbuseReports" NavigateUrl="~/Admi/Moderation/Default.aspx" Text="abuse reports" runat="server" />,
		<asp:Label ID="UnmoderatedImages" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" />&nbsp;<asp:HyperLink ID="hlImages" NavigateUrl="~/Admi/Moderation/AssetReview.aspx" Text="images" runat="server" />,
		<asp:Label ID="UnmoderatedVideos" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" />&nbsp;<asp:HyperLink ID="hlVideos" NavigateUrl="" Text="videos" runat="server" />,
		<asp:Label ID="UnmoderatedPlayers" ClientIDMode="Static" Text="?" Font-Bold="True" runat="server" />&nbsp;<asp:HyperLink ID="hlUsers" NavigateUrl="~/Admi/Users/ModerateUser.aspx" Text="users" runat="server" />
	</div>
	<div>
		<asp:HyperLink ID="hlRoblox" NavigateUrl="~/" Text="Roblox" runat="server" />, <asp:HyperLink ID="hlFindUser" NavigateUrl="~/Admi/Users/Find.aspx" Text="FindUser" runat="server" />
		<hr />
	</div>
	<div>
		<asp:HyperLink ID="hlChangeTheme" NavigateUrl="~/Admi/ChangeTheme.aspx" Text="Change Theme" runat="server" />
	</div>
	<div>
		<asp:HyperLink ID="hlTheme_RBX1" NavigateUrl="" Text="RBX1" runat="server" /> <asp:HyperLink ID="hlTheme_RBX2" NavigateUrl="" Text="RBX2" runat="server" /> <asp:HyperLink ID="hlTheme_RBX3" NavigateUrl="" Text="RBX3" runat="server" /> <asp:HyperLink ID="hlTheme_OBC1" NavigateUrl="" Text="OBC1" runat="server" /> <asp:HyperLink ID="hlTheme_OBC2" NavigateUrl="" Text="OBC2" runat="server" />
	</div>
	<div>
	    <a class="highlight">Stop Chat</a>&nbsp;&nbsp;&nbsp; <a class="highlight">Pause Polling</a>
	</div>
</asp:Panel>