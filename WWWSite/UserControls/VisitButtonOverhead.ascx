<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisitButtonOverhead.ascx.cs" Inherits="Roblox.Website.UserControls.VisitButtonOverhead" %>
<%@ Register Src="~/UserControls/Modals/InsufficientCurrencyOrBC/BCOnlyModal.ascx" TagName="BCOnlyModal" TagPrefix="rbx"%>
    <script type="text/javascript">
        var play_placeId = <%=PlaceID%>;
        function redirectPlaceLauncherToLogin() {
            location.href = "/login/default.aspx?ReturnUrl=" + encodeURIComponent("<%=Context.Request.Url.AbsolutePath %>");
        }
        function redirectPlaceLauncherToRegister() {
            location.href = "/login/NewAge.aspx?ReturnUrl=" + encodeURIComponent("<%=Context.Request.Url.AbsolutePath %>");
        }
        function fireEventAction(action) {
            RobloxEventManager.triggerEvent('rbx_evt_popup_action', { action: action });
        }
    </script>
    <rbx:BCOnlyModal runat="server" />