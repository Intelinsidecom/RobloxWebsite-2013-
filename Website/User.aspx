<%@ Page Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Roblox.Website.UserPage" %>
<%@ Register Src="~/UserControls/UserContent/HeaderPane.ascx" TagName="HeaderPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/UserPane.ascx" TagName="UserPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/UserBadgesPane.ascx" TagName="UserBadgesPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/BadgesDisplay.ascx" TagName="BadgesDisplay" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/UserGroupsPane.ascx" TagName="UserGroupsPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/UserStatisticsPane.ascx" TagName="UserStatisticsPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/SetsPane.ascx" TagName="SetsPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/UserContent/UserPlacesPane.ascx" TagName="UserPlacesPane" TagPrefix="rbx"%>

<asp:Content ID="rbxContent" ContentPlaceHolderID="cphRoblox" runat="server">
    <style type="text/css">
        #Body {
            padding: 10px;
        }
    </style>
    <div>
        <rbx:HeaderPane ID="rbxHeaderPane" runat="server" />
        <div ID="OBCmember" Visible="False" class="blank-box" style="margin-top: 10px; width: 951px; float: left; padding: 8px" runat="server">
            <div style="float: left; margin-right: 10px;">
                <img src="/Images/obcbadge32x32.png" border="0" alt="OBC" title="OBC member" />
            </div>
            <div style="float: left; line-height: 30px;">
                You are viewing the profile of an <a href="Upgrades/BuildersClubMemberships.aspx">Outrageous Builders Club</a> member.
            </div>
        </div>
        <div style="clear: both; margin: 0; padding: 0;"></div>
        <div class="divider-right" style="width: 484px; float: left">
            <rbx:UserPane ID="rbxUserPane" runat="server" />
            <rbx:UserBadgesPane ID="rbxUserBadgesPane" runat="server" />
            <div id="BadgesDisplayPane" style="clear: both;"> 
                <rbx:BadgesDisplay ID="rbxBadgesDisplay" runat="server" />
            </div>
            <div id="UserGroupsPane" style="clear:both;">
                <h2 class="title">
                    <span><%=UserProfile.ProfileLangResources.GetString("Heading.Groups") %></span></h2>
                <rbx:UserGroupsPane ID="rbxUserGroupsPane" runat="server" />
            </div>
            <rbx:UserStatisticsPane ID="rbxUserStatisticsPane" runat="server" />
            <rbx:SetsPane ID="rbxSetsPane" runat="server" />

        </div>
        <div class="divider-left" style="width: 484px; float: left; position: relative; left: -1px">
            <div class="divider-bottom" style="padding-bottom: 20px; padding-left: 20px">
                <h2 class="title" style="float: left">
                    <span><%=UserProfile.ProfileLangResources.GetString("HeadingShowcase") %></span>
                </h2>
                
                <div id="UserPlacesPane">
                    <rbx:UserPlacesPane ID="rbxUserPlacesPane" runat="server" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>