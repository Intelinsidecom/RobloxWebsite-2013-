<%@ Page Title="Builders Club" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="BuildersClubMemberships.aspx.cs" Inherits="Roblox.Website.Upgrades.BuildersClubMemberships" %>

<asp:Content ID="BuildersClubMembership" ContentPlaceHolderID="cphRoblox" runat="server">
        <div id="BuildersClubContainer">
            <div id="LeftColumn" class="StandardBox">
                <asp:Panel ID="MembershipPanelStyle2" runat="server">
	
                    <div id="MembershipOptions" style="margin-bottom: 18px; position: relative; float: left">
                        <asp:ImageButton ID="ImageButton1" ImageUrl="../images/Buttons/questionmark-25x25.png" OnClientClick="window.open(&#39;/Parents/BuildersClub.aspx&#39;);" Style="width:25px;border-width:0px;position: absolute;
                            right: 18px; top: 13px" runat="server"/>
                        

                        <input type="hidden" id="HasBCMembership" value="False" />

                        <div id="BCRow" style="float: left; margin-bottom: 10px">
                            <div style="height: 35px;">
                                <h1 id="BuildersClubTitle" style="width: 480px; margin: 0;">
                                    <asp:Literal runat="server" Text="<%$ Resources: BuildersClub%>" /></h1>
                            </div>
                            <div id="OneMonth" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="BCMonthlyImageLinkButton" runat="server"><div ID="BCMonthlyImageLink" class="upgrades_enabled bcmonthly" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="SixMonths" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="BC6MonthsImageLinkButton" runat="server"><div ID="BC6MonthsImageLink" class="upgrades_enabled bc6" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="TwelveMonths" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="BC12MonthsImageLinkButton" runat="server"><div ID="BC12MonthsImageLink" class="upgrades_enabled bc12" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="Lifetime" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="BCLifetimeImageLinkButton" runat="server"><div ID="BCLifetimeImageLink" class="upgrades_enabled bclife" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                        </div>
                        <div id="TBCRow" style="float: left; margin-bottom: 10px">
                            <div style="clear: both; height: 35px;">
                                <h1 id="TurboBuildersClubTitle" style="margin: 0;">
                                    <asp:Label Class="TurboSpan" Text="<%$ Resources: Turbo%>" runat="server"></asp:Label> <asp:Literal runat="server" Text="<%$ Resources: BuildersClub%>" /></h1>
                            </div>
                            <div id="TurboMonthly" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="TBCMonthlyImageLinkButton" runat="server"><div ID="TBCMonthlyImageLink" class="upgrades_enabled tbcmonthly" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="TurboSixMonths" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="TBC6MonthsImageLinkButton" runat="server"><div ID="TBC6MonthsImageLink" class="upgrades_enabled tbc6" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="TurboTwelveMonths" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="TBC12MonthsImageLinkButton" runat="server"><div ID="TBC12MonthsImageLink" class="upgrades_enabled tbc12" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="TurboLifetime" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="TBCLifetimeImageLinkButton" runat="server"><div ID="TBCLifetimeImageLink" class="upgrades_enabled tbclife" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                        </div>
                        <div id="OBCRow" style="float: left; margin-bottom: 10px">
                            <div style="clear: both; height: 35px;">
                                <h1 id="OutrageousBuildersClubTitle" style="margin: 0;">
                                    <asp:Literal runat="server" Text="<%$ Resources: Outrageous%>" /> <asp:Literal runat="server" Text="<%$ Resources: BuildersClub%>" />
                                </h1>
                            </div>
                            <div id="OutrageousMonthly" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="OBCMonthlyImageLinkButton" runat="server"><div ID="OBCMonthlyImageLink" class="upgrades_enabled obcmonthly" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="OutrageousSixMonths" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="OBC6MonthsImageLinkButton" runat="server"><div ID="OBC6MonthsImageLink" class="upgrades_enabled obc6" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="OutrageousTwelveMonths" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="OBC12MonthsImageLinkButton" runat="server"><div ID="OBC12MonthsImageLink" class="upgrades_enabled obc12" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                            <div id="OutrageousLifetime" class="MembershipButton">
                                <div>
                                    <asp:LinkButton ID="OBCLifetimeImageLinkButton" runat="server"><div ID="OBCLifetimeImageLink" class="upgrades_enabled obclife" runat="server">
                                        </div></asp:LinkButton>
                                </div>
                                <div class="BCButtonLabel">
                                    
                                </div>
                            </div>
                        </div>

                    </div>
                
</asp:Panel>
                <br />
                <br />
                <div style="height: 15px; clear: both">
                    &nbsp;</div>
                <!-- Spacer -->

                <table id="upgrades-membership-options" style="padding-top: 10px;">
                    <thead>
                        <tr>
                            <th scope="col">
                            </th>
                            <th scope="col" class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Benefits%>" />
                            </th>
                            <th scope="col" class="leftBorder">
                                <p style="line-height: 20px">
                                    <asp:Literal runat="server" Text="<%$ Resources: Free Account%>" /></p>
                            </th>
                            <th scope="col" class="leftBorder BCColumn">
                                <div>
                                    <p style="line-height: 20px">
                                        Builders Club</p>
                                </div>
                            </th>
                            <th scope="col" class="leftBorder">
                                <div>
                                    <p style="line-height: 20px">
                                        Turbo Builders Club</p>
                                </div>
                            </th>
                            <th scope="col" class="leftBorder">
                                <div>
                                    <p style="line-height: 20px">
                                        Outrageous Builders Club</p>
                                </div>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class="odd">
                            <td>
                                <div class="icons maps_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Active Places%>" />
                            </td>
                            <td class="leftBorder">
                                1
                            </td>
                            <td class="leftBorder BCColumn">
                                10
                            </td>
                            <td class="leftBorder">
                                25
                            </td>
                            <td class="leftBorder">
                                100
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="icons money_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Daily ROBUX%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: None%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                15 R$
                            </td>
                            <td class="leftBorder">
                                35 R$
                            </td>
                            <td class="leftBorder">
                                60 R$
                            </td>
                        </tr>
                        
                        <tr class="odd">
                            <td>
                                <div class="icons paid-games-icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Paid Access Revenue%>" />
                            </td>
                            <td class="leftBorder">
                                10%
                            </td>
                            <td class="leftBorder BCColumn">
                                70%
                            </td>
                            <td class="leftBorder">
                                70%
                            </td>
                            <td class="leftBorder">
                                70%
                            </td>
                        </tr>
                        
                        <tr >
                            <td>
                                <div class="icons shirt_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Sell Stuff%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        <tr class='odd'>
                            <td>
                                <div class="icons ads_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: See Ads%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                        </tr>
                        <tr >
                            <td>
                                <div class="icons bc_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Virtual Hat%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: None%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <div class="icons bc_icon">
                                </div>
                            </td>
                            <td class="leftBorder">
                                <div class="icons tbc_icon">
                                </div>
                            </td>
                            <td class="leftBorder">
                                <div class="icons obc_icon">
                                </div>
                            </td>
                        </tr>
                        <tr class='odd'>
                            <td>
                                <div class="icons gear_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Bonus Gear Item%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        <tr >
                            <td>
                                <div class="icons money_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Signing Bonus%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: None%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                100 R$ for initial purchase
                            </td>
                            <td class="leftBorder">
                                100 R$ for initial purchase
                            </td>
                            <td class="leftBorder">
                                100 R$ for initial purchase
                            </td>
                        </tr>
                        <tr class='odd'>
                            <td>
                                <div class="icons groups_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Create Groups%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (10)
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (20)
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (100)
                            </td>
                        </tr>
                        <tr >
                            <td>
                                <div class="icons groups_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Join Groups%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (5)
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (10)
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (20)
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" /> (100)
                            </td>
                        </tr>
                        <tr class='odd'>
                            <td>
                                <div class="icons badges_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Create Badges%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        <tr >
                            <td>
                                <div class="icons beta_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: BC Beta Features%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        
                        <tr class='odd'>
                            <td>
                                <div class="icons personalserver_icon">
                                </div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Personal Servers%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        
                        <tr >
                            <td>
                                <div class="tradesystem_icon"></div>
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Trade System%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        
                        <tr class='odd'>
                            <td>
                                <img src="/Images/Icons/MegaPlace.png" />
                            </td>
                            <td class="LeftText">
                                <asp:Literal runat="server" Text="<%$ Resources: Mega Places%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: No%>" />
                            </td>
                            <td class="leftBorder BCColumn">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                            <td class="leftBorder">
                                <asp:Literal runat="server" Text="<%$ Resources: Yes%>" />
                            </td>
                        </tr>
                        
                    </tbody>
                </table>
                <div id="WindowsOnlyWarning">
                    <p>
                         <asp:Literal runat="server" Text="<%$ Resources: WindowsOnlyWarning1%>" />
                        <asp:HyperLink ID="FAQHyperLink" NavigateUrl="../Parents/BuildersClub.aspx" Text="Builders Club FAQs" runat="server"/>.</p>
                    <p>
                        <asp:Literal runat="server" Text="<%$ Resources: WindowsOnlyWarning2%>" /></p>
                    <p>
                       <asp:Literal runat="server" Text="<%$ Resources: WindowsOnlyWarning3%>" /> <a href="/info/terms-of-service"><asp:Literal runat="server" Text="<%$ Resources: Terms & Conditions %>" /></a> <asp:Literal runat="server" Text="<%$ Resources: WindowsOnlyWarning4%>" />
                     </p>
                </div>
            </div>
            <div id="RightColumn">
                <div id="RightColumnWrapper">
    <div class="cell cellDivider">
        <asp:Literal runat="server" Text="<%$ Resources: For billing and payment questions%>" />: <a target="_blank" href="mailto:info@roblox.com">info@roblox.com</a>
    </div>
    <div class="">

<div class="GenericModal modalPopup unifiedModal smallModal" style="display:none;">
        <div class="Title"></div>
        <div class="GenericModalBody">
            <div>
                <div class="ImageContainer">
                    <img class="GenericModalImage" alt="<%$ Resources: generic image%>" runat="server" />
                </div>
                <div class="Message"></div>
            </div>
            <div class="clear"></div>
            <div id="GenericModalButtonContainer" class="GenericModalButtonContainer">
                <a class="ImageButton btn-neutral btn-large roblox-ok">OK<span class="btn-text">OK</span></a>
            </div>  
        </div>
    </div>    </div>
    <div class="cell cellDivider">
        <h3><asp:Literal runat="server" Text="<%$ Resources: Buy ROBUX%>" /></h3>
        <p><asp:Literal runat="server" Text="<%$ Resources: RobuxUsage%>" /></p>
        <p>
            <a  href="/upgrades/robux.aspx" class="btn-medium btn-primary"><asp:Literal runat="server" Text="<%$ Resources: Buy ROBUX%>" /></a>
        </p>
        <h3><asp:Literal runat="server" Text="<%$ Resources: Buy ROBUX with%>" /></h3><br /><br />
        <a href="/micropay"><img src="/Images/buildersClubPage_bokuLogo.png" alt="boku" /></a><br /><br />
        <a href="/rixtypin"><img src="/Images/PaymentMethods/Rixty.png" alt="rixty" /></a><br /><br />
        <a href="http://itunes.apple.com/us/app/roblox-mobile/id431946152?mt=8"><img src="/Images/PaymentMethods/img-itunes_logo.png" alt="itunes" /></a>
    </div>
    <div class="cell cellDivider">
        <h3><asp:Literal runat="server" Text="<%$ Resources: Gift Cards%>" /></h3><br />
        <a href="/upgrades/giftcards.aspx" class="giftCardImage"><img src="/Images/Upgrades/giftCardImage.png" alt="giftcard" /></a>
        <div>
                <div class="giftCardButton">
                    <a  href="/upgrades/giftcards.aspx" class="btn-small btn-primary"><asp:Literal runat="server" Text="<%$ Resources: Buy Card%>" /></a>
                </div>
                <div><a href="/gamecard" class="redeemLink"><asp:Literal runat="server" Text="<%$ Resources: Redeem card%>" /></a></div>
            <div style="clear: both"></div>
        </div>
    </div>
    <div class="cell cellDivider">
        <h3><asp:Literal runat="server" Text="<%$ Resources: Game Cards%>" /></h3>
        <a href="/gamecards"><img alt="ROBLOX Gamecards" src="/Images/Gamecards/redcliff_knight_sm.png" /></a>
        <div class="gameCardControls">
            <div class="gameCardButton">
                <a  href="/gamecards" class="btn-small btn-primary"><asp:Literal runat="server" Text="<%$ Resources: Where to Buy%>" /></a>
            </div>
            <div><a href="/gamecard" class="redeemLink"><asp:Literal runat="server" Text="<%$ Resources: Redeem Card%>" /></a></div>
            <div style="clear: both"></div>
        </div>
    </div>
    <div class="cell">
        <h3><asp:Literal runat="server" Text="<%$ Resources: ManipulationQuestion%>" /></h3>
        <p><asp:Literal runat="server" Text="<%$ Resources: ManipulationDesc%>" /></p>
        <a  href="/my/share/pleaseupgrademe.aspx" class="btn-small btn-primary"><asp:Literal runat="server" Text="<%$ Resources: Manipulation%>" /></a>
        <p><asp:Literal runat="server" Text="<%$ Resources: ManipulationWarning%>" /></p>
        <h3><asp:Literal runat="server" Text="<%$ Resources: Parents%>" /></h3>
        <p><asp:Literal runat="server" Text="<%$ Resources: BCInfo1%>" /><a href="/parents/buildersclub.aspx"><asp:Literal runat="server" Text="<%$ Resources: BCInfo2%>" />.</a></p>
        <h3><asp:Literal runat="server" Text="<%$ Resources: Other Accounts%>" /></h3>
        <p><asp:Literal runat="server" Text="<%$ Resources: MembershipCancelDisclaimer%>" /></p>
    </div>
</div>
            </div>
        </div>
    

<%--div id="BuyBCComparePanel" class="modalPopup blueAndWhite" style="width: 500px; min-height: 100px; display: none; *position:relative; *top:-150px;">
    <div id="simplemodal-close" class="simplemodal-close">
        <a ID="A2" class="ImageButton closeBtnCircle_35h" style="cursor: pointer; margin-left:486px; position:absolute; top:-15px;" runat="server"></a>
    </div>
    <div id="BCCompareModal" style="border:none;">


    <div ID="BCCompareModalUpdatePanel" class="BCCompareModalUpdatePanel" runat="server">
	

        <div id="BuyBCComparePanelTopInfo" style="width:390px;">
            <div id="ComparePanelImg" style="margin-bottom:15px;text-align: center;margin-top:-10px;">
                <span style="font-weight:bold;font-size:13px;">Product Selected</span>
                <br />
                <asp:Image ID="BuyBCComparePanelImage" ImageUrl="" Style="border-width:0px;margin-top:5px;" runat="server"/>
            </div>
            <span ID="BCCompareConversionInfo" runat="server"></span>
        </div>
                    
        <div style="border:1px solid #D3D3D3;">
        <br/>
            <asp:Table ID="verid" class="BuyBCComparePanelTable" CellSpacing="0" CellPadding="0" HorizontalAlign="Center" BorderWidth="0" Style="border-collapse:collapse;margin-left:auto;margin-right:auto;width:450px;" runat="server">
		<asp:TableRow Class="BCCompareHeaderRow">
			<asp:TableHeaderCell Class="titlecolumn"></asp:TableHeaderCell><th style="padding:10px 0px 5px 8px;width:130px;color:#666;text-align: left;">Your Current <br/> Membership</th><th class="BCCompareModalRow" style="padding:10px 0px 5px 8px;border-top:1px solid #000;text-align: left;">Your New <br/> Membership</th>
		</asp:TableRow><asp:TableRow Class="BBCCompareRow">
			<td class="titlecolumn">
                        Builders Club Type
                    </td><td id="ctl00_cphRoblox_BCCompareModal_currentBC" style="width:130px;color:#666;">None</td><td class="BCCompareModalRow"></td>
		</asp:TableRow><asp:TableRow Class="BBCCompareRow">
			<td class="titlecolumn">
                        Recurring
                    </td><td style="width:130px;color:#666;">No</td><td class="BCCompareModalRow">No<span class="subscriptionHelp" style="margin-left:3px;position:absolute;font-size:16px;color:Red;">*</span>
                    </td>
		</asp:TableRow><asp:TableRow Class="BBCCompareRow">
			<td style="border-bottom:none;">Expiration</td><td style="border-bottom:none;width:130px;color:#666;">xx/xx/xx</td><td class="BCCompareModalRow" style="border-bottom:1px solid #000;">xx/xx/xx</td>
		</asp:TableRow>
	</asp:Table>
                <div class="subscriptionHelp" style="margin-bottom:15px;margin-left:15px;"><span style="color:Red;">*</span> You will be automatically billed every month starting xx/xx/xx </div>
                
                <script type="text/javascript">
                    $(function () {
                        $('.subscriptionHelp').hide();
                    });
                </script>
                
        </div>
        <div id="BCCompareButtons" style="width:390px;margin-top:15px;height:50px">
            <a href="PaymentMethods.aspx?ap=0" id="ctl00_cphRoblox_BCCompareModal_PurchaseLink" class="MediumButton" style="margin-left:auto;margin-right:auto;cursor: pointer; text-decoration:none;">Purchase</a>
        </div>
        


            
</div>
    </div>
</--%> 

<script type="text/javascript">
    function BCCompareClick(preloaded) {
        if (preloaded == null) { preloaded = false; }
        if ($('#HasBCMembership').length > 0 && $('#HasBCMembership')[0].value == "False") { return; }
        var modalProperties = { overlayClose: true, escClose: true, opacity: 80, overlayCss: { backgroundColor: "#000" } };
        if (!preloaded) {
            $('.BCCompareModalUpdatePanel').html('<div style="background: url(/images/ProgressIndicator4.gif) center no-repeat;height:420px;width:100%;" >&nbsp;</div>');
        }
        $("#BuyBCComparePanel").modal(modalProperties);
    }
</script>

    
                <div style="clear:both"></div>
</asp:Content>

<asp:Content ID="BannerAdContent" ContentPlaceHolderID="cphBannerAd" runat="server">
    <%--asp:Panel ID="topAdPanel" runat="server">
        <img src="/Images/Ads/BuildersClubAd-728x90v4.jpg" alt="<%$ Resources: BuyBuildersClub%>" style="margin-bottom: 11px" runat="server">
    </--%>
    <div id="AdvertisingLeaderboard">
        <img src="<%=StaticContent.GetUrl("~/Images/Ads/BuildersClubAd-728x90v3.jpg")%>" alt="<asp:Literal Text="<%$ Resources: BuyBuildersClub%>" runat="server" />" style="margin-bottom: 11px" />
    </div>

</asp:Content>