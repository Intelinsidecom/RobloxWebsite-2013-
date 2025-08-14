<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SelectGenderPane.ascx.cs" Inherits="Roblox.Website.UserControls.SelectGenderPane" %>

<div style="text-align:left">Are you a boy or a girl?</div>
<div style="text-align:center;position:relative;height:250px">
	<div style="position:absolute;left:50%;margin-left:-175px">
		<label for="MaleBtn"><img src="/images/Accounts/boy.png" ID="BoyThumbnail" style="cursor:pointer" runat="server" /><br /></label>
		<asp:RadioButton ID="MaleBtn" GroupName="Gender" ClientIDMode="Static" runat="server"/><label for="MaleBtn">Boy</label>
	</div>
	<div style="position:absolute;left:50%;margin-left:25px">
		<label for="FemaleBtn"><img src="/images/Accounts/girl.png" ID="GirlThumbnail" style="cursor:pointer" runat="server" /><br /></label>
		<asp:RadioButton ID="FemaleBtn" GroupName="Gender" ClientIDMode="Static" runat="server"/><label for="FemaleBtn">Girl</label>
	</div>
</div>