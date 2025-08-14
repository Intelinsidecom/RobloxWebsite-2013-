<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemPurchaseAjax.ascx.cs" Inherits="Roblox.Website.UserControls.ItemPurchaseAjax" %>

<div id="ItemPurchaseAjaxData"
        data-authenticateduser-isnull="<%= Model.AuthenticatedUserIsNull %>"
        data-user-balance-robux="<%= Model.UserBalanceRobux %>""
        data-user-balance-tickets="<%= Model.UserBalanceTickets %>""
        data-user-bc="<%= Model.UserBC %>""
        data-continueshopping-url="<%= Model.ContinueShoppingUrl %>""
        data-imageurl="<%= Model.ImageUrl %>"
        data-alerturl="<%= Model.AlertUrl %>"
        data-builderscluburl="<%= Model.BuildersClubUrl %>""></div>

    <div id="ProcessingView" style="display:none">
        <div class="ProcessingModalBody">
            <p style="margin:0px"><img src='<%= StaticContent.GetUrl("~/Images/Spinners/waiting.gif") %>' alt="Processing..." /></p>
            <p style="margin:7px 0px">Processing Transaction</p>
        </div>
    </div>
    
    <script type="text/javascript">
        //<sl:translate>
        Roblox.ItemPurchase.strings = {
            insufficientFundsTitle : "Insufficient Funds",
            insufficientFundsText : "You need {0} more to purchase this item.",
            cancelText : "Cancel",
            okText : "OK",
            buyText : "Buy",
            buyTextLower : "buy",
            tradeCurrencyText : "Trade Currency",
            priceChangeTitle : "Item Price Has Changed",
            priceChangeText : "While you were shopping, the price of this item changed from {0} to {1}.",
            buyNowText : "Buy Now",
            buyAccessText: "Buy Access",
            buildersClubOnlyTitle : "{0} Only",
            buildersClubOnlyText : "You need {0} to buy this item!",
            buyItemTitle : "Buy Item",
            buyItemText : "Would you like to {0} {5}the {1} {2} from {3} for {4}?",
            balanceText : "Your balance after this transaction will be {0}",
            freeText : "Free",
            purchaseCompleteTitle : "Purchase Complete!",
            purchaseCompleteText : "You have successfully {0} {5}the {1} {2} from {3} for {4}.",
            continueShoppingText : "Return to Profile",
            customizeCharacterText : "Customize Character",
            orText : "or",
            rentText : "rent",
            accessText: "access to "
        }
    //</sl:translate>
    </script>
