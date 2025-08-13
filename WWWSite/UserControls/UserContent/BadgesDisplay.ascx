<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BadgesDisplay.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.BadgesDisplay" %>


<% if (UserProfile != null) { %>
<h2 class="title"><span><%=Resources.GetString("HeadingPlayerBadge") %></span></h2>
<div class="badge-container">
	    
    <asp:UpdatePanel ID="BadgesUpdatePanel" class="BadgesUpdatePanel" runat="server">
	    <ContentTemplate>
            <div id="roblox-badge-loading" class="BadgesLoading_Container badge-loading-indicator">
                <img src="/images/ProgressIndicator4.gif" alt="Loading..." />
            </div>
            <div class="BadgesListView_Container badge-list-view-container">
                <asp:ListView ID="BadgeListView" runat="server">
                    <ItemTemplate>
                        <div class="TileBadges">
                                <%--rbx:AssetImage ID="BadgeThumbnail" AssetID='<%#Eval("BadgeID") %>' runat="server" /--%>
                        
                    
                            <div class="AssetDetails" style="display:none;" id="badgeInfo<%#Eval("BadgeAssetAwardID") %>">
                                <div class="AssetName"><asp:HyperLink ID="AssetNameHyperLink" ToolTip="click to view" NavigateUrl="/Welcome-to-Spleef-item?id=76285821" Text='<%#Eval("BadgeName") %>' runat="server" />
                                <div class="AssetCreator"><span class="Label">Creator:</span> <span class="Detail"><asp:HyperLink ID="AssetCreatorHyperLink" NavigateUrl='<%#Eval("CreatorID", "~/User.aspx?ID={0}") %>' Text='<%#Eval("CreatorName") %>' runat="server" /></span></div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
                <asp:ObjectDataSource runat="server" ID="BadgeAssetAwardDataSource" />
            </div>
            <div class="BadgesPager_Container badge-pager-container">
                <asp:DataPager ID="BadgeDataPagerFooter"
                    PagedControlID="BadgeListView"
                    runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField
                            ButtonType="Button"
                            ShowNextPageButton="False"
                            ButtonCssClass="pager previous"
                            RenderNonBreakingSpacesBetweenControls="True"/>
                        <asp:TemplatePagerField>
                            <PagerTemplate>
                                 <span style="display: inline-block; padding: 5px; vertical-align: top">
                                Page
                                <asp:Label runat="server" ID="CurrentPageLabel" 
                                  Text="<%# Container.TotalRowCount>0 ? (Container.StartRowIndex / Container.PageSize) + 1 : 0 %>" />
                                of
                                <asp:Label runat="server" ID="TotalPagesLabel" 
                                  Text="<%# Math.Ceiling ((double)Container.TotalRowCount / Container.PageSize) %>" />
                                </span>
                            </PagerTemplate>
                        </asp:TemplatePagerField>
                        <asp:NextPreviousPagerField
                            ButtonType="Button"
                            ShowPreviousPageButton="False"
                            ButtonCssClass="pager next"
                            RenderNonBreakingSpacesBetweenControls="True"/>
                    </Fields>
                </asp:DataPager>
                <!--span id="ctl00_cphRoblox_rbxBadgesDisplay_BadgeDataPagerFooter"><input type="submit" name="ctl00$cphRoblox$rbxBadgesDisplay$BadgeDataPagerFooter$ctl00$ctl00" value="" disabled="disabled" class="pager previous" />&nbsp;
                        <span style="display: inline-block; padding: 5px; vertical-align: top">
                        Page
                        <span id="ctl00_cphRoblox_rbxBadgesDisplay_BadgeDataPagerFooter_ctl01_CurrentPageLabel">1</span>
                        of
                        <span id="ctl00_cphRoblox_rbxBadgesDisplay_BadgeDataPagerFooter_ctl01_TotalPagesLabel">2</span>
                        </span>
                        <input type="submit" name="ctl00$cphRoblox$rbxBadgesDisplay$BadgeDataPagerFooter$ctl02$ctl00" value="" class="pager next" />&nbsp;</span-->
            </div>
        </ContentTemplate>
</asp:UpdatePanel>
	<div style="clear:both;"></div>
</div>

<script type="text/javascript">
    $('#' + '<%=BadgesUpdatePanel.ClientID %>').bind('click', function (e) {
        var target = $(e.target);
        if (target.parentsUntil('.BadgesUpdatePanel', '.BadgesPager_Container').length > 0 && target[0].tagName == 'INPUT') {
            //put up loading sign
            $('.BadgesListView_Container').css("visibility", "hidden");
            $('#roblox-badge-loading').css("display", "block");
        }
    });

</script>
<% } %>