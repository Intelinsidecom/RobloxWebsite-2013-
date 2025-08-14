<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuRedesign.ascx.cs" Inherits="Roblox.Website.UserControls.Navigation.MenuRedesign" %>


<% if (Roblox.WebsiteSettings.Properties.Layout.Default.UseMVCNavBar) {%>
<%-- MVC Navigation Behavior --%>
<%@ Import Namespace="Roblox.Website" %>
<%@ Import Namespace="Roblox.Website.ViewModels.Navigation" %>
<% RazorBridge.RenderPartial("~/Views/Navigation/Navigation.cshtml", new NavigationViewModel()); %>
<% } else { %>
<%-- WebForms MenuRedesign Behavior --%>
<%@ Register Src="~/UserControls/Navigation/AlertsAndOptionsAnonymous.ascx" TagName="AlertsAndOptionsAnonymous" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Navigation/AlertsAndOptionsAuthenticated.ascx" TagName="AlertsAndOptionsAuthenticated" TagPrefix="rbx"%>
<%-- <%$Resources:Class,ResourceID%> --%>
<style type="text/css">
    div.mySubmenuFixed {
        top: 36px;
        background-color: #191919;
        height: 25px;
        *top: 0px;
    }
</style>
<div id="Banner" class="BannerRedesign" >
    <div id="NavigationRedesignBannerContainer" class="BannerCenterContainer" >
        <asp:HyperLink NavigateUrl="/Default.aspx" CssClass="btn-logo" data-se="nav-logo" runat="server" />
        <div id="navigation-menu" class="NavigationRedesign">
            <ul id="MenuUL" runat="server">
                <li><asp:HyperLink NavigateUrl="/Home" Text="<%$ Resources: Nav.MyRoblox %>" ToolTip="<%$ Resources: Nav.MyRoblox %>" ref="nav-myroblox" data-se="nav-myhome" runat="server"/></li>
                <li><asp:HyperLink NavigateUrl="/Games" Text="<%$ Resources: Nav.Games %>" ToolTip="<%$ Resources: Nav.Games %>" ref="nav-games" data-se="nav-games" runat="server"/></li>
                <li><asp:HyperLink NavigateUrl="/Catalog" Text="<%$ Resources: Nav.Catalog %>" ToolTip="<%$ Resources: Nav.Catalog %>" ref="nav-catalog" data-se="nav-catalog" runat="server"/></li>
                <li><asp:HyperLink NavigateUrl="/Build/Default.aspx" Text="<%$ Resources: Nav.Build %>" ToolTip="<%$ Resources: Nav.Build %>" ref="nav-build" data-se="nav-build" runat="server"/></li>
                <li><asp:HyperLink NavigateUrl="/Upgrades/BuildersClubMemberships.aspx" Text="<%$ Resources: Nav.BuildersClub %>" ToolTip="<%$ Resources: Nav.BuildersClub %>" ref="nav-buildersclub" data-se="nav-upgrade" runat="server"/></li>
                <li><asp:HyperLink NavigateUrl="/Forum/Default.aspx" Text="<%$ Resources: Nav.Forum %>" ToolTip="<%$ Resources: Nav.Forum %>" ref="nav-forum" data-se="nav-forum" runat="server"/></li>
                <li class="moreLink" drop-down-nav-button="moreLink">
                    <div class="LinkContainer">
                        <asp:HyperLink ID="hlMore" Text="<%$ Resources: Nav.More %>" ToolTip="<%$ Resources: Nav.More %>" ref="nav-more" data-se="nav-more" ClientIDMode="Static" runat="server"/>
                        <a id="moreMenuToggle"></a>
                    </div>
                    <div class="dropdownnavcontainer" style="display:none;" drop-down-nav-container="moreLink">
                        <div class="dropdownmainnav" style="z-index:1023">
                            <a class="dropdownoption" data-se="nav-more-browse" href="/Browse.aspx" title="<asp:Literal runat='server' Text='<%$ Resources: Nav.Browse%>' />" ref="nav-people"><span><asp:Literal runat="server" Text="<%$ Resources: Nav.Browse%>" /></span></a>
                            <a class="dropdownoption" data-se="nav-more-contests" href="/Contests/" title="<asp:Literal runat='server' Text='<%$ Resources: Nav.Contests%>' />" ref="nav-contests"><span><asp:Literal runat="server" Text="<%$ Resources: Nav.Contests%>" /></span></a>
                            <a class="dropdownoption" data-se="nav-more-blog" href="http://blog.roblox.com" title="<asp:Literal runat='server' Text='<%$ Resources: Nav.News%>' />" ref="nav-news"><span><asp:Literal runat="server" Text="<%$ Resources: Nav.News%>" /></span></a></>
                            <a class="dropdownoption" data-se="nav-more-help" href="/Help/Builderman.aspx" title="<asp:Literal runat='server' Text='<%$ Resources: Nav.Help%>' />" ref="nav-help"><span><asp:Literal runat="server" Text="<%$ Resources: Nav.Help%>" /></span></a>
                        </div>  
                    </div>
                </li>
            </ul>
        </div>
        <%-- If we have an authenticated user --%>
        <asp:LoginView ID="BannerAlertsAndOptionsLoginView" runat="server">
            <AnonymousTemplate>
                <rbx:AlertsAndOptionsAnonymous ID="BannerAlertsAndOptions_Anonymous" runat="server" />
            </AnonymousTemplate>
            <LoggedInTemplate>
                 <rbx:AlertsAndOptionsAuthenticated ID="BannerAlertsAndOptions_Authenticated" runat="server" />
            </LoggedInTemplate>
        </asp:LoginView>
    </div>
</div>
<% } %>