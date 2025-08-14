<%@ Page Title="" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="NewEmailPlz.aspx.cs" Inherits="Roblox.Website.Login.NewEmailPlz" %>
<%@ Register Src="~/UserControls/BonusRoundJavaScript.ascx" TagName="BonusRoundJavaScript" TagPrefix="rbx"%>
<asp:Content ID="Content" ContentPlaceHolderID="cphRoblox" runat="server">
    <asp:Panel CssClass="Registration" BackColor="Transparent" BorderStyle="None" runat="server">
        <asp:Panel ID="AccountRegistrationPanel" runat="server">
            <div class="StandardBoxHeader">
                <span>Create a Free ROBLOX Account</span>
            </div>
            <div class="StandardBox">
            <h3>
                Bonus Round</h3>
            <div id="EnterEmail">
                <asp:Panel ID="EmailOver12" runat="server">
                    <div id="Div1">
                        An email address is NOT required to finish account registration. However, if you
                        lose your password, you will be unable to recover it unless you supply a valid email
                        address. If you do supply an email address, we will send you an email to confirm
                        its validity. If you click on the link in that email, we will award you with a special
                        hat for your character.
                    </div>
	            </asp:Panel>
                
                
                <fieldset title="Your Email">
                    <legend>
                        Your Email</legend>
                    <div class="Suggestion" style="color: Red">
                        If you do not supply a valid email address and you lose your password, we <b>cannot</b>
                        help you recover your account.
                    </div>
                    <div class="Validators">
                        <div><asp:RegularExpressionValidator ID="EmailRegularExpressionValidator"
                            ErrorMessage="Please enter a valid email address."
                            ForeColor="Red" Display="Dynamic"
                            ValidationExpression="<%# Roblox.EmailAddresses.Properties.Settings.Default.ValidEmailAddressRegex %>"
                            ControlToValidate="EmailTextBox"
                            runat="server" /></div>
                        <div><asp:RequiredFieldValidator ID="EmailRequiredFieldValidator"
                            Text="Email is required."
                            ForeColor="Red" Display="Dynamic"
                            Enabled="False"
                            ControlToValidate="EmailTextBox"
                            runat="server" /></div>
                        <div><asp:CustomValidator ID="EmailAvailableCustomValidator"
                            Text="This email address is not available for use."
                            ForeColor="Red" Display="Dynamic"
                            ControlToValidate="EmailTextBox"
                            runat="server" /></div>
                    </div>
                    <div class="EmailRow">
                        <asp:Label ID="EmailLabel" AssociatedControlID="EmailTextBox" Text="Your Email" CssClass="Label" runat="server" />&nbsp;<asp:TextBox ID="EmailTextBox" TabIndex="7" CssClass="TextBox" runat="server" />
                    </div>
                    
                </fieldset>
                <asp:Panel ID="FriendReferrals" runat="server">
                    <rbx:BonusRoundJavaScript ID="rbxBonusRoundJavaScript" runat="server" />
                    <fieldset title="Referral Code">
                        <legend>Did your friend send you?</legend>
                        <div class="Suggestion" style="color: #A9A9A9;">
                            Entering a referral code is optional. If you have been given one by a friend, please
                            enter it here. If it's already filled out, we've successfully tracked your referrer!
                        </div>
                        <div class="EmailRow">
                            <asp:Label ID="referralcodelabel" CssClass="Label" Text="Optional Friend Code" runat="server" />
                            <asp:TextBox ID="referral_code" CssClass="TextBox" TabIndex="8" onkeyup="initiate_waiting()" MaxLength="20" runat="server" />
                            <span id="code_checker" style="height: 16px; width: 16px; vertical-align: middle;">
                            </span>
                        </div>
                    </fieldset>
	            </asp:Panel>
                
                <asp:Panel ID="pnlNewsletterOptin" runat="server">
                 <fieldset title="ROBLOX Newsletter">
                        <legend>ROBLOX Newsletter</legend>
                        
                            <asp:CheckBox ID="chkNewsletter" runat="server" /> Sign up for email news and updates from ROBLOX. You will not get spammed or emails from 3rd parties.
                        
                 </fieldset>
	            </asp:Panel>
                
            </div>
            <div class="Confirm">
                <asp:Button ID="ConfirmEmail"
                    Text="Ok, Done"
                    OnClientClick="javascript: return checkReferralState(false);" 
                    TabIndex="8" CssClass="MediumButton" Width="40%"
                    runat="server" />
            </div>
            </div>
        </asp:Panel>
    </asp:Panel>
    <div id="Sidebars">
        <div id="AlreadyRegistered" style="background-color:Transparent;border:none;padding:0;">
            <div class="StandardBoxHeader">
                <span>Privacy Policy</span></div>
            <div class="StandardBox">
            <p>
                ROBLOX will not disclose your email address to third parties. The main reason to
                give us an email address is so we can mail you your password if you forget or lose
                it.</p>
            <p>
                For more complete information please see our
                <asp:HyperLink ID="HyperLinkPrivacy" NavigateUrl="~/Info/Privacy.aspx" Text="Privacy Policy" runat="server" />
                page.</p>
            <p>
                <asp:HyperLink ID="hlTruste" NavigateUrl="https://www.truste.org/ivalidate.php?url=www.roblox.com&amp;sealid=105" ImageUrl="~/images/truste_seal_kids.gif" style="display:inline-block;width:140px;" runat="server" /></p>
                    <p><asp:HyperLink NavigateUrl="https://www.bbb.org/online/consumer/cks.aspx?id=109111915116750" ImageUrl="~/images/bbbsealh1US.gif" ToolTip="Click to verify BBB accreditation and to see a BBB report." runat="server" />
                        </p>
            </div>
        </div>
        <div id="TermsAndConditions" style="background-color:Transparent;border:none;padding:0;">
            <div class="StandardBoxHeader">
                <span>Age Verification</span></div>
            <div class="StandardBox">
            <p>
                In compliance with COPPA, your parent will recieve an email which will help them
                to recover your account if you forget your password.</p>
            </div>
        </div>

    </div>
    <br clear="all" />
    
    
</asp:Content>