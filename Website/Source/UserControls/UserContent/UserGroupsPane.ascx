<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserGroupsPane.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.UserGroupsPane" %>
<% if (UserProfile != null) { %>
<div class="divider-bottom" style="clear:both; padding-bottom: 20px;">
    <asp:Panel ID="pNoResults" runat="server">
		<p class="NoResults"><asp:Label ID="lNoResults" Text="{0} is not in any groups." runat="server" /></p>
    </asp:Panel>
    <asp:Panel runat="server">
	
    <asp:ListView ID="GroupListView" runat="server">
        <ItemTemplate>
            <div ID="GroupTemplateItem" style="float: left" runat="server">
                <div class="groupEmblemThumbnail" style="width:85px; overflow:hidden;margin:15px">
                    <div class="groupEmblemImage notranslate" style="width: 85px; height:87px; margin: 0px; padding-top: 0px; background-repeat:no-repeat; background-image:none ">
                        <%--rbx:AssetImage ID="AssetImage1" AssetID='<%#Eval("ID") %>' NavigateUrl='<%#Eval("ID", "~/Groups/group.aspx?gid={0}") %>' Width="75" Height="75" runat="server" /--%>
                        <!--a id="ctl00_cphRoblox_rbxUserGroupsPane_GroupListView_ctrl0_AssetImage1" title=" I ♥ Fried Chicken" href="/Groups/group.aspx?gid=481260" style="display:inline-block;height:75px;width:75px;cursor:pointer;"><img src="http://t3.rbxcdn.com/0df0c468506c7a440a389b5c66d00442" height="75" width="75" border="0" onerror="return Roblox.Controls.Image.OnError(this)" alt=" I ♥ Fried Chicken" /></a-->
                    </div>
                </div>
	        </div>
        </ItemTemplate>
    </asp:ListView>
    <%-- TODO: Set PageSize programatically --%>
    <asp:DataPager ID="GroupDataPagerFooter"
        PagedControlID="GroupListView"
        runat="server">
        <Fields>
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
        </Fields>
    </asp:DataPager>
            <!--span id="ctl00_cphRoblox_rbxUserGroupsPane_GroupDataPagerFooter" style="margin-left: 125px; display: inline-block"><a disabled="disabled" class="pager previous"></a>&nbsp;
                    <span style="display: inline-block; padding: 5px; vertical-align: top">
                    Page
                    <span id="ctl00_cphRoblox_rbxUserGroupsPane_GroupDataPagerFooter_ctl01_CurrentPageLabel">1</span>
                    of
                    <span id="ctl00_cphRoblox_rbxUserGroupsPane_GroupDataPagerFooter_ctl01_TotalPagesLabel">6</span>
                    </span>
                    <a class="pager next" href="javascript:__doPostBack(&#39;ctl00$cphRoblox$rbxUserGroupsPane$GroupDataPagerFooter$ctl02$ctl00&#39;,&#39;&#39;)"></a>&nbsp;</span-->
        
</asp:Panel>
    <div style="clear:both"></div>
</div>
<% } %>