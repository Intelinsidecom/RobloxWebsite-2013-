<%@ Page Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="NewAge.aspx.cs" Inherits="Roblox.Website.Login.NewAge" %>
<%@ Register Src="~/UserControls/SelectGenderPane.ascx" TagName="SelectGenderPane" TagPrefix="rbx"%>

<asp:Content ID="LoginNewAge" ContentPlaceHolderID="cphRoblox" runat="server">
    <div style="float: left; width: 620px; margin-top: 10px;">
		<div class="StandardBoxHeader" style="width: 620px;"><span><asp:Literal runat="server" Text="<%$ Resources: CreateFreeRobloxAccount %>" /></span></div>
		<div class="StandardBox" style="width: 620px;">
			<h3><asp:Literal runat="server" Text="<%$ Resources: EnterBirthday %>" /></h3><br/>
			<center>
				<asp:DropDownList ID="lstMonths" ClientIDMode="Static" Font-Size="18px" runat="server" /> &nbsp;&nbsp;
				<asp:DropDownList ID="lstDays" ClientIDMode="Static" Font-Size="18px" runat="server" /> &nbsp;&nbsp;
				<asp:DropDownList ID="lstYears" ClientIDMode="Static" Font-Size="18px" runat="server" />
				<div id="lblError" style="display: none"><b><asp:Literal runat="server" Text="<%$ Resources: BirthdayChooseValidDate %>" /></b></div>
				<br /><br />
				<i><asp:Literal runat="server" Text="<%$ Resources: BirthdayDoesntGetShared %>" /></i>
			</center>
			<div style="text-align:center">
				<rbx:SelectGenderPane ID="SelectGenderPane" runat="server" />
				<div id="genderError" style="color:Red;font-weight:bold;margin-bottom:10px;display:none"><asp:Literal runat="server" Text="<%$ Resources: GenderPleaseSelect %>" /></div>
				<a id="btnSignup2" class="MediumButton" onclick="CheckDateAndGender()"><asp:Literal runat="server" Text="<%$ Resources: ContinueButtonText %>" /></a>
				<asp:Button ID="btnHidden" Style="display: none" runat="server" />
			</div>
			<br/>
		</div>
	</div>
	<div id="Sidebars" style="margin-top: 10px;">
		<div class="StandardBoxHeader" style="width: 230px;"><span><asp:Literal runat="server" Text="<%$ Resources: SidebarHeader %>" /></span></div>
		<div class="StandardBox" style="width:230px;">
			<p>If you just need to login, go to the <asp:HyperLink ID="HyperLinkLogin" NavigateUrl="~/Login" Text="Login" runat="server" /> page.</p>
			<p>If you have already registered but you still need to download the game installer, go directly to <asp:HyperLink ID="HyperLinkDownload" NavigateUrl="~/install/" Text="download" runat="server" />.</p>
		</div>
		<div class="StandardBoxHeader" style="width: 230px;"><span><asp:Literal runat="server" Text="<%$ Resources: SidebarParentsHeader %>" /></span></div>
		<div class="StandardBox" style="width:230px;">
			<p><asp:Literal runat="server" Text="<%$ Resources: SidebarParentsP1 %>" /></p>
			<p><asp:Literal runat="server" Text="<%$ Resources: SidebarParentsP2 %>" /></p>
			<p><asp:Literal runat="server" Text="<%$ Resources: SidebarParentsP3 %>" /></p>
			<p><asp:HyperLink ID="ParentsInfo" NavigateUrl="/Parents.aspx" Text="<%$ Resources: SidebarParentsMoreInfoLink %>" runat="server" /></p>
			<p><asp:HyperLink ID="hlTruste" NavigateUrl="http://www.truste.org/ivalidate.php?url=www.roblox.com&amp;sealid=105" Style="display:inline-block;width:140px;" ImageUrl="~/images/truste_seal_kids.gif" runat="server" /></p>
			<p>
				<a target="_blank" href="https://www.bbb.org/online/consumer/cks.aspx?id=109111915116750"><asp:Image ToolTip="Click to verify BBB accreditation and to see a BBB report." border="0" ImageUrl="~/images/bbbsealh1US.gif" runat="server" /></a>
			</p>
		</div>
	</div><br clear="all" />

	<script type="text/javascript">
		function CheckDateAndGender() {
			$('#lblError').attr('style', 'display: none');
			var year = parseInt($('#lstYears option:selected').val());
			var month = parseInt($('#lstMonths option:selected').val());
			var day = parseInt($('#lstDays option:selected').val());
			var isValid = true;
			if (year <= 0 || month <= 0 || day <= 0 || day > new Date(year, month, 0).getDate()) {
				$('#lblError').attr('style', 'color: Red;');
				isValid = false;
			}
			if ($('#MaleBtn:checked').length == 0 && $('#FemaleBtn:checked').length == 0) {
				$('#genderError').show();
				isValid = false;
			}
			else {
				$('#genderError').hide();
			}
			if (isValid) {
                $('#<%#btnHidden.ClientID %>').click();
			}
		}
    </script>
</asp:Content>