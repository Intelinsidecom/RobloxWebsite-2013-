<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlertsAndOptionsAnonymous.ascx.cs" Inherits="Roblox.Website.UserControls.Navigation.AlertsAndOptionsAnonymous" %>
  <div id="SiteWideHeaderLogin">
    <div id="HeaderLoginButton" class="iFrameLoginSignUp">
		<asp:HyperLink id="HeaderSignUp" NavigateUrl="/Login/NewAge.aspx" Text="<%$ Resources: Header.SignUp %>" ClientIDMode="Static" runat="server" />
		<asp:Label ID="HeaderOr" Text="<%$ Resources: Header.Or %>" ClientIDMode="Static" runat="server"/>
        <span id="loginSpan">
			<a id="headerLogin" ></a>
        </span>
		<div id="iFrameLogin" style="display:none" runat="server" clientidmode="Static" >
			<iframe class="loginFrame" src="/Login/iFrameLogin.aspx?loginRedirect=True&parentUrl=<%=HttpUtility.UrlEncode(HttpContext.Current.Request.Url.AbsoluteUri)%>" scrolling="no" frameborder="0"></iframe>
		</div>
	</div>
</div>