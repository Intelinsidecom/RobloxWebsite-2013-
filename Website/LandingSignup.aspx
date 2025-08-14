<%@ Page Title="" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="LandingSignup.aspx.cs" Inherits="Roblox.Website.LandingSignup" %>
<%@ Register Src="~/UserControls/SignupForm.ascx" TagName="SignupForm" TagPrefix="rbx"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphRoblox" runat="server">
    
            <div id="Experimental" style="margin: 0px;">
                <div style="position:relative">
                    <div class="VideoContainer" >
                        <h2 style="margin:5px 0;">JOIN MILLIONS OF PLAYERS FOR FREE!</h2> 
                        <br />
                        <h2 class="light VideoSubtitle" >See the video and learn more about ROBLOX</h2> 
                        
                                <div class="flex-video widescreen">
                                    <iframe allowfullscreen="true"
                                    src="//www.youtube.com/embed/LHdA7Yc-8Rg?fs=1&rel=0&controls=0&showinfo=0"
                                    frameborder="0"
                                    id="rbx-video-player"
                                    width="380px"
                                    height="250px"></iframe>
                                </div>
                            
                    </div> 
                    <div class="SignupWrapper divider-left">
                        <h1>Sign Up To Play!</h1> 
                            <rbx:SignupForm runat="server" />
                    </div>
                </div>
            </div>            
            
</asp:Content>