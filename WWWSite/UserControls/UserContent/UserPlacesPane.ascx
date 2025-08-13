<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserPlacesPane.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.UserPlacesPane" %>
<%@ Register Src="~/UserControls/Platform.ascx" TagName="Platform" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/ItemPurchaseAjax.ascx" TagName="ItemPurchaseAjax" TagPrefix="rbx"%>
<asp:Panel ID="pnlUserPlaces" runat="server">
<div id="UserPlaces" style="overflow: hidden">

    <div id="accordion" class="accordion">
    <asp:ListView
        ID="ShowcasePlaces"
        ItemType="Roblox.IAsset"
        runat="server">
      <ItemTemplate>
        <div class="accord-section accord-section-open">
            <div class="accord-header notranslate">
                <div class="accord-arrow">&#x25b6;</div>
			    <%# Item.Name %>
            </div>
            <div class="accord-content notranslate">
			    <rbx:Platform ID="rbxPlatform" Place='<%# Item %>' runat="server" />
            </div>
        </div>
      </ItemTemplate>
    </asp:ListView>
    </div>

	<asp:Panel ID="ShowcaseFooter" CssClass="PanelFooter" style="margin-top:5px;margin-left:20px;padding:3px;" runat="server">
		<asp:DataPager ID="ShowcasePager"
            PagedControlID="ShowcasePlaces" PageSize="<%# Model.ShowcasePagerPageSize %>"
            Visible="<%# Model.DisplayShowcasePager %>"
            runat="server" >
            <Fields>
            <asp:TemplatePagerField>
                <PagerTemplate>
	                <asp:Panel ID="PanelPages" HorizontalAlign="Center" runat="server">
                        <asp:LinkButton ID="LinkButtonFirst" CssClass="pager previous" Enabled="<%# Container.StartRowIndex > 0 %>" CommandName="Previous" runat="server" />
                    <span class="PageNumbers" style="vertical-align: top; display: inline-block; padding: 5px; padding-top: 6px">Page <asp:Literal
                        Text="<%# Container.TotalRowCount>0 ? (Container.StartRowIndex / Container.PageSize) + 1 : 0 %>"
                        runat="server" /> of <asp:Literal
                        Text="<%# Math.Ceiling ((double)Container.TotalRowCount / Container.PageSize) %>"
                        runat="server" /></span>
                    <asp:LinkButton ID="LinkButtonNext" CssClass="pager next" Enabled="<%# (Container.StartRowIndex + Container.PageSize) < Container.TotalRowCount %>" CommandName="Next" runat="server" />
                    </asp:Panel>
                </PagerTemplate>
            </asp:TemplatePagerField>
            </Fields>
        </asp:DataPager>
	    <asp:HyperLink ID="ConfigureShowcaseHyperLink" NavigateUrl="~/develop?View=9" Text="Manage My Places" Visible="False" runat="server" />
	</asp:Panel>
 </div>
 </asp:Panel>
 
 <div class="ItemPurchaseAjaxContainer">
    <rbx:ItemPurchaseAjax ID="rbxItemPurchaseAjax" runat="server" />
</div>
 <script type="text/javascript">
     Roblox.require('Widgets.DropdownMenu', function (dropdown) {
         dropdown.InitializeDropdown();
     });
</script>
