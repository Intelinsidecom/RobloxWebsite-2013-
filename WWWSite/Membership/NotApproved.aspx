<%@ Page Title="Disabled Account" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="NotApproved.aspx.cs" Inherits="Roblox.Website.NotApproved" %>
<asp:Content ID="Content" ContentPlaceHolderID="cphRoblox" runat="server">
    <div style="border: solid 1px #000; margin: 0 auto; padding: 30px; max-width: 500px;">
        <h2 style="text-align: center;"><%# TitleText %></h2>
        <p>Our content monitors have determined that your behavior at ROBLOX has been in violation of our Terms of Service.
        <% if (!IsDeleted) { %>We will terminate your account if you do not abide by the rules.<% } %>
        </p><p>Reviewed: <span style="font-weight: bold"><%# Punishment.Created.ToString() %></span></p>
        <asp:Panel ID="ModeratorNotePanel" runat="server">
            <p>Moderator Note: <span style="font-weight: bold"><asp:Label ID="Label4" mode="Encode" Text="<%# Punishment.ModeratorMessage %>" runat="server" /></span></p>
        </asp:Panel>
        <p>
            <asp:Repeater ID="BadUtterancesRepeater" runat="server">
                <ItemTemplate>
                    </p><div style="background-color: #fff; border: solid 1px #000; margin-bottom: 5px; padding: 10px; width: 478px">
                        <div style="margin-bottom: 5px;"><strong>Reason:</strong> Inappropriate</div>
                        <div>
                            <strong>Offensive Item:</strong>
                            <blockquote>
                                
                            </blockquote>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        <p></p>
        <asp:Panel ID="PanelRemind" Visible="False" runat="server">
            <p>Please abide by the <a href="https://www.roblox.com/support">ROBLOX Community Guidelines</a> so that ROBLOX can be fun for users of all ages.</p>
        </asp:Panel>
        <asp:Panel ID="PanelMembershipCancellation" BackColor="Black" ForeColor="White" Visible="False" runat="server">
            <p style="padding: 6px">
                You currently have a ROBLOX membership that is set to renew on 1/30/2011.
                If you would like to cancel this membership during the duration of your moderation action, please call us at 1-888-858-BLOX (2569).
            </p>
        </asp:Panel>
        <asp:Panel ID="PanelDeleted" Visible="False" runat="server">
            <p>Your account has been terminated.</p>
        </asp:Panel>
        <asp:Panel ID="PanelBanned" Visible="False" runat="server">
            <p>Your account has been disabled for <%# PunishmentDurationString.ToLower() %>. You may re-activate it after <%# Punishment.Expiration.ToString() %> (PST).</p>
        </asp:Panel>
        
        <% if (!Punishment.IsActive) { %>
            <p>You may re-activate your account by agreeing to our <a href="https://www.roblox.com/tos">Terms of Service</a>.</p>
            <p style="text-align: center;">
                <asp:CheckBox ID="AgreeCheckBox" ClientIDMode="Static" Text="I Agree" class="translate" Checked="False" onclick="EnableButton()" runat="server" />
            </p>
            <p style="text-align: center;">
                <asp:Button ID="ButtonAgree" Text="Reactivate My Account" Enabled="False" OnClick="ButtonAgree_Click" class="translate" runat="server" />
            </p>
        <% } %>
        <% else if (IsBanished) { %>
            <p>If you wish to appeal, please contact us via the <a href="https://www.roblox.com/support">Support Form</a>.</p>
        <% } %>
        <p style="text-align: center;">
            <asp:Button ID="LogoutButton" Text="Logout" OnClick="LogoutButton_Click" class="translate" runat="server" />
        </p>

        <script type="text/javascript">
            function EnableButton() {
                if (document.getElementById('AgreeCheckBox').checked) {
                    document.getElementById('<%#ButtonAgree.ClientID %>').disabled = false;
                }
                else {
                    document.getElementById('<%#ButtonAgree.ClientID %>').disabled = true;
                }
            }
        </script>
    </div>
</asp:Content>
<%-- Get rid of IFrame UserAd. Causes redirect loop on page. --%>
<asp:Content ID="BannerAdContent" ContentPlaceHolderID="cphBannerAd" runat="server" />