<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisitButtons.ascx.cs" Inherits="Roblox.Website.UserControls.VisitButtons" %>
<%@ Register Src="~/UserControls/VisitButtonOverhead.ascx" TagName="VisitButtonOverhead" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Modals/InsufficientCurrencyOrBC/BCOnlyModal.ascx" TagName="BCOnlyModal" TagPrefix="rbx"%>
        <div class="<%# FancyButtonsClassName %>" runat="server">
            <div ID="MultiplayerVisitButton" class="VisitButton VisitButtonPlay" placeid="<%# Place.ID %>" runat="server">
                <a  class="btn-medium btn-primary">Play</a>
            </div>  
            <div ID="BuildButton" class="VisitButton VisitButtonBuild" placeid="<%# Place.ID %>" Visible="<%# CanBuild %>" runat="server">
                <a  title="Open in Build Mode" class="btn-medium btn-primary tooltip">Build</a>
            </div>
            <div ID="EditButton" class="VisitButton VisitButtonEdit" placeid="<%# Place.ID %>" Visible="<%# CanEdit %>" runat="server">
                <a  title="Open in Studio Mode" class="btn-medium btn-primary tooltip">Edit</a>
            </div>
        </div>
    <rbx:VisitButtonOverhead runat="server" />
    <rbx:BCOnlyModal runat="server" />
<script type="text/javascript">
    $(function () {
        Roblox.Client.Resources = {
            //<sl:translate>
            here: "here",
            youNeedTheLatest: "You need Our Plugin for this.  Get the latest version from ",
            plugInInstallationFailed: "Plugin installation failed!",
            errorUpdating: "Error updating: "
            //</sl:translate>
        };
    });
</script>