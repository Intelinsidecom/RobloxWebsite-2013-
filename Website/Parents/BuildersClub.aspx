<%@ Page Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="BuildersClub.aspx.cs" Inherits="Roblox.Website.Parents.BuildersClub" %>

<asp:Content ID="ParentsBuildersClub" ContentPlaceHolderID="cphRoblox" runat="server">
    <div id="ParentsContainer" class="text">
        <h1>About Builders Club</h1>
        <div>
            <div class="QuestionsColumnLeft">
                <div id="BCLinks">
                    <div class="BCLinksSection">
                        <div class="header">Overview</div>
                        <div>
                            <ul class="list">
                                <li class="sectionLink"><asp:Literal runat="server" Text="<%$ Resources: WhatIsBuildersClub %>" /></li>
                            </ul>
                        </div>
                    </div>
                    <div class="BCLinksSection">
                        <div class="header"><asp:Literal runat="server" Text="<%$ Resources: GettingBuildersClub %>" /></div>
                        <div style="display:none">
                            <ul class="list">
                                <li><a class="sectionLink" data-section="PaymentMethods"><asp:Literal runat="server" Text="<%$ Resources: PaymentMethods%>" /></a></li>
                                <li><a class="sectionLink" data-section="TransactionSecurity"><asp:Literal runat="server" Text="<%$ Resources: TransactionSecurity%>" /></a></li>
                                <li><a class="sectionLink" data-section="AcceptedCurrencies"><asp:Literal runat="server" Text="<%$ Resources: AcceptedCurrencies%>" /></a></li>
                                <li><a class="sectionLink" data-section="FamilyPlans"><asp:Literal runat="server" Text="<%$ Resources: FamilyPlans%>" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="BCLinksSection">
                        <div class="header"><asp:Literal runat="server" Text="<%$ Resources: OnceYouHaveBuildersClub %>" /></div>
                        <div style="display:none">
                            <ul class="list">
                                <li><a class="sectionLink" data-section="MembershipTimelines"><asp:Literal runat="server" Text="<%$ Resources: MembershipTimelines%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipRenewals"><asp:Literal runat="server" Text="<%$ Resources: MembershipRenewals%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipExpiration"><asp:Literal runat="server" Text="<%$ Resources: MembershipExpiration%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipExtensions"><asp:Literal runat="server" Text="<%$ Resources: MembershipExtensions%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipTransfers"><asp:Literal runat="server" Text="<%$ Resources: MembershipTransfers%>" /></a></li>
                                <li><a class="sectionLink" data-section="TOSViolations"><asp:Literal runat="server" Text="<%$ Resources: TOSViolations%>" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="BCLinksSection">
                        <div class="header"><asp:Literal runat="server" Text="<%$ Resources: BuildersClubConversions %>" /></div>
                        <div style="display:none">
                            <ul class="list">
                                <li><a class="sectionLink" data-section="MembershipConversion"><asp:Literal runat="server" Text="<%$ Resources: MembershipConversion%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipUpgrades"><asp:Literal runat="server" Text="<%$ Resources: MembershipUpgrades%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipDowngrades"><asp:Literal runat="server" Text="<%$ Resources: MembershipDowngrades%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipLifetime"><asp:Literal runat="server" Text="<%$ Resources: MembershipLifetime%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipRecurring"><asp:Literal runat="server" Text="<%$ Resources: MembershipRecurring%>" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="BCLinksSection">
                        <div class="header"><asp:Literal runat="server" Text="<%$ Resources: OtherMembershipChanges %>" /></div>
                        <div style="display:none">
                            <ul class="list">
                                <li><a class="sectionLink" data-section="MembershipChanges"><asp:Literal runat="server" Text="<%$ Resources: MembershipChanges%>" /></a></li>
                                <li><a class="sectionLink" data-section="MembershipCancellation"><asp:Literal runat="server" Text="<%$ Resources: MembershipCancellation%>" /></a></li>
                                <li><a class="sectionLink" data-section="RefundPolicy"><asp:Literal runat="server" Text="<%$ Resources: RefundPolicy %>" /></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="QuestionsColumnRight">
                <div>
                    <div id="AboutBuildersClub">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: AboutBuildersClub %>" /></h2>
                        <p>Builders Club is a premium service that enhances the ROBLOX experience.</p>
                        <p>
                            Builders Club memberships give users the ability to create and manage multiple structures and environments. Builders Club members also gain the ability to earn ROBLOX currency &#151; called "ROBUX" &#151; which can be used to purchase premium items in the ROBLOX catalog. These items enable much greater (i.e. much cooler!) customization of users' avatars and their interactive creations.</p>
                        <p>
                            In addition, Builders Club members gain the ability to promote their creations in the ROBLOX catalog and sell them to other members using the virtual ROBLOX economy.</p>
                        <p>
                            Finally, unlike free account holders, Builders Club members will no longer be exposed to, or distracted by, on screen advertisements.</p>
                        <p>
                            For parents who are interested in learning more about subscription options or in purchasing a Builders Club membership for their child, click on the membership button on the home page or <a id="BCSignUpHyperLink" href="/Upgrades/BuildersClubMemberships.aspx">start the sign-up process</a> now.</p>
                    </div>

                    <div id="PaymentMethods" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: PaymentMethods %>" /></h2>
                        <p>
                            ROBLOX accepts payment via all major credit cards for Monthly, 6 and 12 Month memberships. Monthly memberships are automatically recurring. We also accept PayPal for 6 and 12 Month memberships.
                        </p>
                    </div>
                    <div id="TransactionSecurity" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: TransactionSecurity %>" /></h2>
                        <p>
                            All transactions on ROBLOX use secure commercial-grade encryption. Furthermore, information relating to your payment (such as your credit card number) never resides on our servers. All of our online transactions are processed by PayPal, a trusted name in internet commerce.
                        </p>
                    </div>
                    <div id="AcceptedCurrencies" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: AcceptedCurrencies %>" /></h2>
                        <p>All prices are in US dollars. However, most online payment methods will convert currencies at the current bank rate. Ask your credit card company or banking institution about currency conversion fees or other fees.
                        </p>
                    </div>
                    <div id="FamilyPlans" style="display: none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: FamilyPlans %>" /></h2>
                        <p>We do not offer family plans.</p>
                    </div>

                    <div id="MembershipTimelines" style="display: none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipTimelines %>" /></h2>
                        <p>
                            Memberships will be activated as soon as payment is received. How quickly this occurs depends upon the method of payment.
                        </p>
                        <blockquote>
                            <strong>Credit Card:</strong>Your membership will be activated instantly.<br/>
                            <strong>PayPal:</strong> If your PayPal account charges directly to a credit card, your membership will usually be activated within one day. If your PayPal account charges to a bank account (eCheck), up to 10 days may be required to receive payment.<br/>
                        </blockquote>
                    </div>
                    <div id="MembershipRenewals" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipRenewals %>" /></h2>
                        <p>
                            Only monthly subscriptions paid via credit card will autorenew, in order to ensure continuous, uninterrupted service. All other subscriptions need to be manually renewed from the Builders Club page.
                        </p>
                    </div>
                    <div id="MembershipExpiration" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipExpiration %>" /></h2>
                        <p>
                            You will not lose your account, but you will lose your Builders Club membership status and all of its benefits, including your daily ROBUX stipend and the Builders Club badge. You will keep all of your data, including all shirts, pants, and other assets that you have made. You will also keep your current ROBUX and Tickets balance. Memberships can be re-subscribed at any time.
                        </p>
                    </div>
                    <div id="MembershipExtensions" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipExtensions %>" /></h2>
                        <p>
                            Yes. Simply go to the Builders Club page and buy an extension to your account. This will extend your current Builders Club by the duration purchased. A 6-month extension, for example, will add 6 months to your current expiration date. By definition, extensions extend an account type (regular, Turbo, or Outrageous) with the same priveleges.
                        </p>
                    </div>
                    <div id="MembershipTransfers" style="display:none" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipTransfers %>" /></h2>
                        <p>Builders Club memberships are non-transferable.</p>
                    </div>
                    <div id="TOSViolations" style="display:none" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: TOSViolations %>" /></h2>
                        <p>
                            The ROBLOX Team is committed to keeping the ROBLOX community safe for users of all ages. Builders Club members who violate our terms of service may have their accounts suspended for a period of time or deleted at our discretion. There will be no refunds on suspended or deleted accounts.
                        </p>
                        <p>
                            Parents are encouraged to help their children understand that our standards for behavior online are similar to those that might be upheld at an elementary school playground.
                        </p>
                    </div>

                    <div id="MembershipConversion" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipConversion %>" /></h2>
                        <p>
                            When upgrading or downgrading memberships, ROBLOX immediately replaces the existing membership benefits with the purchased benefits. ROBLOX also converts any remaining days on the current membership into an equivalent number of days of the new membership type, and adds those days to the amount purchased. When upgrading, regular Builders Club days are divided by 2 to convert to Turbo Builders Club days. When downgrading, Turbo Builders Club days are multiplied by 2 to convert to regular Builders Club days.
                        </p>
                        <p>
                            Example: A user has 20 days left on a 6-month regular Builders Club membership. He upgrades to a 12-month Turbo Builders Club membership. Three things happen: (1) he immediately gets the Turbo Builders Club benefits; (2) his credit card is immediately charged; and, (3) his 20 days of regular Builders Club are converted to 10 days of Turbo Builders Club and added to the 12-month Turbo membership period, for a total of 12 months and 10 days of Turbo Builders Club.
                        </p>
                        <p>
                            Likewise, 3 regular Builders Club days convert to 1 Outrageous Builders Club day. 3 Turbo Builders Club days convert to 2 Outrageous Builders Club days.
                        </p>
                    </div>
                    <div id="MembershipUpgrades" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipUpgrades %>" /></h2>
                        <p>Yes. Go to the Builders Club page and buy a Turbo Builders Club upgrade. An upgrade from Builders Club to Turbo Builders Club will instantly grant you Turbo Builders Club membership. The days left on your current membership will be converted into an equivalent number of Turbo Builders Club days (see
                            <a class="sectionLink" data-section="MembershipConversion">Membership Conversions</a> for more). A similar procedure applies to upgrade to Outrageous Builders Club.
                        </p>
                    </div>
                    <div id="MembershipDowngrades" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipDowngrades %>" /></h2>
                        <p>
                            Yes. Go to the Builders Club page and buy a Builders Club downgrade. A downgrade from Turbo Builders Club to Builders Club will instantly replace your Turbo Builders Club benefits with regular Builders Club benefits. The days left on your current membership will be converted into an equivalent number of regular Builders Club days (see <a class="sectionLink" data-section="MembershipConversion">Membership Conversions</a> for more). A similar procedure applies to downgrade from Outrageous Builders Club.
                        </p>
                    </div>
                    <div id="MembershipLifetime" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipLifetime %>" /></h2>
                        <p> Lifetime Builders Club members can upgrade to lifetime Turbo Builders Club membersips by going to the Builders Club page and buying the appropriate upgrade. Lifetime Turbo Builders Club members cannot downgrade to regular Builders Club. Either one can be upgraded to Outrageous Builders Club. No other changes can be made to lifetime memberships.
                        </p>
                    </div>
                    <div id="MembershipRecurring" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipRecurring %>" /></h2>
                        <p>
                            Yes. You can change from a monthly recurring membership to any other membership at any time. When doing so, your current recurring charges will be cancelled and you will be charged for the new membership. You can also change from a fixed-month to recurring membership; for these changes, your monthly charges will begin after the converted days from the current membership are used up (see <a class="sectionLink" data-section="MembershipConversion">
                    Membership Conversions </a> for conversion details). In all cases, like all account changes, the terms of the new membership apply immediately.
                        </p>
                        <p>
                            Example: A user has 20 days left on a 6-month regular Builders Club membership. He upgrades to a monthly recurring Turbo Builders Club membership. Three things happen: (1) he immediately gets the Turbo Builders Club benefits; (2) his credit card is immediately charged; and, (3) his 20 days of regular Builders Club are converted to 10 days of Turbo Builders Club, moving the first recurring charge to 40 days away (10 converted days + 1st month).
                        </p>
                    </div>

                    <div id="MembershipChanges" style="display:none" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipChanges %>" /></h2>
                        <p>Yes. All extensions, upgrades, and downgrades require a purchase.</p>
                    </div>
                    <div id="MembershipCancellation" style="display:none" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: MembershipCancellation %>" /></h2>
                        <p>
                            Cancellations only apply to recurring Builders Club subscriptions that were paid via credit card. Canceling is easy &#151; simply click the Cancel button that appears in the Manage Account panel on the <a href="/Upgrades/BuildersClubMemberships.aspx">Builders Club</a> page and confirm the cancellation. If you cancel a recurring subscription, you will continue to receive Builders Club privileges for the remainder of the currently paid month. Certain promotional offers require that you wait for 10 days after signup before cancelling your membership.
                        </p>
                    </div>
                    <div id="RefundPolicy" style="display:none">
                        <h2><asp:Literal runat="server" Text="<%$ Resources: RefundPolicy %>" /></h2>
                        <p>Memberships are non-refundable.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>