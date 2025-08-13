<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Platform.ascx.cs" Inherits="Roblox.Website.UserControls.Platform" %>
<%@ Register Src="~/UserControls/PlaceAccessIndicator.ascx" TagName="PlaceAccessIndicator" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/VisitButtons.ascx" TagName="VisitButtons" TagPrefix="rbx"%>
<div class="Place">
    <div class="dropdown"
        style="float: right; margin-bottom: 10px; margin-top: 7px; margin-right: 6px; z-index: 1"
        Visible="<%# Place.HasAccess(AuthenticatedUser) %>" runat="server">
        <div class="button button gear"></div>
        <ul class="dropdown-list" data-align="right">
            <li>
                <a href="My/Item.aspx?ID=<%=Place.ID %>">Configure</a>
            </li>
            <li>
                <a href="My/NewUserAd.aspx?targetId=<%=Place.ID %>&targettype=Asset">Advertise</a>
            </li>
            <li>
                <a href="My/NewBadge.aspx?targetId=<%=Place.ID %>">Create Badge</a>
            </li>
            
                <li>
                    <a href="My/ContentBuilder.aspx?ContentType=34&PlaceID=<%=Place.ID %>">Create Game Pass</a>
                </li>
            
            <li>
                <a href="places/<%=Place.ID %>/stats">Developer Stats</a>
            </li>
        </ul>
    </div>
    <div class="PlayStatus">
        <rbx:PlaceAccessIndicator ID="rbxPlaceAccessIndicator" runat="server" />
    </div>
    <br>
    <div class="Statistics" style="color: #999; font-size: 14px; letter-spacing: normal">
        <asp:Label ID="lStatistics" Text="Visited 16,832,889 times (13,703 last week)" runat="server" />
    </div>
    <div class="Thumbnail" style="width:414px;overflow:hidden;position: relative;">
        <%--rbx:AssetImage ID="rbxPlaceThumbnail" AssetID="<%# PlaceID %>" Width="420" Height="230" /--%>
    </div>
    <asp:Panel ID="pDescription" runat="server">
        <div class="Description" style="overflow-y: auto; max-height: 160px; font-family: arial; color: #666; font-size: 12px;">
            <asp:Label ID="lDescription" Text='<%# Place.Description %>' runat="server" />
        </div>
	</asp:Panel>
    <div class="PlayOptions" style="display:block" >

        <div class="VisitButtonContainer"  data-item-id="<%=Place.ID %>">
            <rbx:VisitButtons ID="rbxVisitButtons" Place="<%# Place %>" runat="server" />
        </div>
    </div>
</div>
