<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iFrameLogin.aspx.cs" Inherits="Roblox.Website.Login.iFrameLogin" %>
<%@ Import Namespace="Roblox.Web.StaticContent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title>
	ROBLOX Login
</title>

    <link rel="stylesheet" href="/CSS/YUIReset.css" />
    <link rel='stylesheet' href='/CSS/M/main.css' />

    <script type='text/javascript' src='//ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.2.min.js'></script>
    <script type='text/javascript'>
        window.jQuery || document.write("<script type='text/javascript' src='/js/jquery/jquery-1.7.2.min.js'><\/script>")
    </script>
    <script type='text/javascript' src='//ajax.aspnetcdn.com/ajax/4.0/1/MicrosoftAjax.js'></script>
    <script type='text/javascript'>
        window.Sys || document.write("<script type='text/javascript' src='/js/Microsoft/MicrosoftAjax.js'><\/script>")
    </script>

    <%: RobloxScripts.RenderBundle("iframelogin") %>

    <style>
        html 
        {
            background-color: #E1E1E1;
        }
    </style>
</head>

<body style="background: #E1E1E1;" data-parent-url="<%# ParentURL%>" data-captchaon="<%# CaptchaOn.ToString().ToLower()%>" data-clientipaddress="<%# ClientIPAddress%>" data-redirecttohttp="true">
 <div id="NotLoggedInPanel">
        <form name="FacebookLoginForm" method="post" action="/Login/iFrameLogin.aspx?loginRedirect=True&amp;parentUrl=<%=ParentURL%>" id="FacebookLoginForm" runat="server">
            <asp:ScriptManager runat="server" ID="ScriptManager">
                <Services>
                    <asp:ServiceReference  Path="~/Services/Secure/LoginService.asmx" />
                </Services>                
            </asp:ScriptManager>

            <div id="LoginForm">
                <div class="newLogin" id="newLoginContainer">
                    <div class="UserNameDiv">
                        <label class="form-label" for="UserName"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Label.Username %>" /></label>
                        <br />
                        <input name="UserName" type="text" id="UserName" class="text-box text-box-medium LoginFormInput" style="width: 144px;" />
                    </div>

                    <div class="PasswordDiv">
                        <label class="form-label" for="Password"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Label.Password %>" /></label>
                        <br />
                        <input name="Password" type="password" id="Password" class="text-box text-box-medium LoginFormInput" style="width:152px;" />
                    </div>
                    
                    <div style="clear:both"></div>
                    
                    <div id="iFrameCaptchaControl"></div>

                    <div id="ErrorMessage" style="color:Red"></div>

                    <div class="LoginFormFieldSet">
                        <span id="NotAMemberLink" class="footnote" style="position: absolute;top: 50%;margin-top: -8px;">
						    <asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Label.NonAMemberQuestion %>" />
						    <a href="NewAge.aspx" target="_top"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Action.SignUpCapitalizedExcited %>" /></a>
					    </span>

                        <span id="ForgotPasswordLink" class="footnote" style="display: none;position: absolute;top: 50%;margin-top: -8px;">
					        <a href="ResetPasswordRequest.aspx" target="_top"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Action.ForgotPasswordQuestion %>" /></a>
                        </span>

                        <a class="btn-small btn-neutral" id="LoginButton" tabindex="4" style="float:right; margin-top:8px;"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Action.Login %>" /></a>

                        <span id="LoggingInStatus" style="display: none; position: absolute; right: 8px;margin-top: -11px;top: 50%;">
						    <img src="<%=StaticContent.GetUrl("/Images/ProgressIndicator2.gif") %>" style="margin-right: 5px;width: 20px;height: 20px;" alt="" />
						    <span style="top: -5px;position: absolute;position: relative;"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Label.LoggingInSpinnerText %>" /></span>
                        </span>
                    </div>
                    <%--div id="SocialNetworkSignIn">
                        <div id="fb-root"></div>

                        <div id="facebookSignIn">
                            <a class="facebook-login" href="/Facebook/SignIn?returnTo=<%=ParentURL%>" target="_top" ref="form-facebook">
                                <span class="left"></span>
                                <span class="middle"><asp:Literal runat="server" Text="<%$ Resources:Authentication.Login, Action.LoginWithFacebook %>" /></span>
                                <span class="right"></span>
                            </a>
                        </div>
                    </--%>
                </div>
            </div>
        </form>
  </div>
    <script type="text/javascript">
        $(function () {
            Roblox.iFrameLogin.Resources = {
                //<sl:translate>
                invalidCaptchaEntry: 'Invalid Captcha entry'
                //</sl:translate>
            };
            Roblox.iFrameLogin.init();
        });
    </script>
</body>

</html>