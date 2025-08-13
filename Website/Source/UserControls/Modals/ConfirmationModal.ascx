<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConfirmationModal.ascx.cs" Inherits="Roblox.Website.UserControls.Modals.ConfirmationModal" %>
<div class="ConfirmationModal modalPopup unifiedModal smallModal" data-modal-handle="confirmation" style="display:none;">
    <a class="genericmodal-close ImageButton closeBtnCircle_20h"></a>
    <div class="Title"></div>
    <div class="GenericModalBody">
        <div class="TopBody">
            <div class="ImageContainer roblox-item-image" data-image-size="small" data-no-overlays data-no-click>
                <img class="GenericModalImage" alt="generic image" />
            </div>
            <div class="Message"></div>
        </div>
        <div class="ConfirmationModalButtonContainer GenericModalButtonContainer">
            <a href id="roblox-confirm-btn"><span></span></a>
            <a href id="roblox-decline-btn"><span></span></a>
        </div>
        <div class="ConfirmationModalFooter">
        
        </div>  
    </div>  
    <script type="text/javascript">
        Roblox = Roblox || {};
        Roblox.Resources = Roblox.Resources || {};

        //<sl:translate>
        Roblox.Resources.GenericConfirmation = {
            yes: "<%=LangResources["Action.Yes"]%>",
            No: "<%=LangResources["Action.No"]%>",
            Confirm: "<%=LangResources["Action.Confirm"]%>",
            Cancel: "<%=LangResources["Action.Cancel"]%>"
        };
        //</sl:translate>
    </script>
</div>