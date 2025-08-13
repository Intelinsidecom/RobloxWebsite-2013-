<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenericModal.ascx.cs" Inherits="Roblox.Website.UserControls.Modals.GenericModal" %>
<div class="GenericModal modalPopup unifiedModal smallModal" style="display:none;">
    <div class="Title"></div>
    <div class="GenericModalBody">
        <div>
            <div class="ImageContainer roblox-item-image"  data-image-size="small" data-no-overlays data-no-click>
                <img class="GenericModalImage" alt="generic image" />
            </div>
            <div class="Message"></div>  
            <div style="clear:both"></div>
        </div>
        <div class="GenericModalButtonContainer">
            <a class="ImageButton btn-neutral btn-large roblox-ok" >OK<span class="btn-text">OK</span></a> 
        </div>  
    </div>
</div>