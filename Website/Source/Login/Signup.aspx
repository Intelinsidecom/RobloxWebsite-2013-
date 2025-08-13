<%@ Page Title="" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Roblox.Website.Login.Signup" %>
<%@ Register Src="~/UserControls/SignupForm.ascx" TagName="SignupForm" TagPrefix="rbx"%>

<asp:Content ID="Body" ContentPlaceHolderID="cphRoblox" runat="server">
<div class="SignupWrapper">
    <div class="title">
        <h1>Sign up to build & make friends</h1>
    </div>

<div class="SignupBox divider-right">
    <rbx:SignupForm runat="server" />
</div>
<div class="UpperRightBox divider-bottom">
    <span style="margin-top: 5px;float: left;">Already registered?</span> 
    <a href="/Login/" class="btn-small btn-negative" style="margin-left:5px;">Login<span class="btn-text">Login</span></a>

</div>
<div class="LowerRightBox">
    
    <span>Are you on Facebook? </span>
	
<div id="SplashPageConnect" class="fbSplashPageConnect">
	<a class="facebook-login"  href="/facebook/signin?returnTo=%2Fhome" target="_top" ref="form-facebook">
		<span class="left"></span>
		<span class="middle">Login with Facebook<span>Login with Facebook</span></span>
		<span class="right"></span>
	</a>
</div>
    <div class="Termsandconditions">
    By clicking Sign Up, you agree to our <asp:HyperLink ID="HyperLinkToS" NavigateUrl="/info/terms-of-service" Text="Terms of Service" runat="server" />, <asp:HyperLink ID="HyperLinkEULA" NavigateUrl="~/Info/EULA.htm" Text="Licensing Agreement" runat="server" />, and <asp:HyperLink ID="HyperLinkPrivacy" NavigateUrl="~/Info/Privacy.aspx?layout=null" Text="Privacy Policy" runat="server" />. We will not share your information with 3rd parties. 
    </div>
    
    <div style="padding-top:3px;">
        <div id="a15b1695-1a5a-49a9-94f0-9cd25ae6c3b2">
    <a href="//privacy.truste.com/privacy-seal/Roblox-Corporation/validation?rid=2428aa2a-f278-4b6d-9095-98c4a2954215" title="TRUSTe Children privacy certification" target="_blank">
        <img style="border: none" src="/Images/TRUSTe/seal.png" alt="TRUSTe Children privacy certification"/>
    </a>
</div>
    </div>
</div>

</div>
</asp:Content>