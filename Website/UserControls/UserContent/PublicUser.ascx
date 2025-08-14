<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PublicUser.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.PublicUser" %>
<%if (UserProfile != null) {%>
<div class="UserBlurb" style="margin-top: 10px; overflow-y: auto; max-height: 450px; ">
    <%=UserProfile.ProfileDescription %>
</div>
<div id="ProfileButtons" style="margin:10px auto;">
    <% if (UserProfile.AreFriends) { %>
        <div id="FriendButton" class="GrayDropdown">
            <div class="Button"><%=Resources.GetString("ActionFriendOptions") %></div>
            <div class="Menu" style="width:130px">
                <% if (!UserProfile.IsVieweeTopFriend) { %>
                <asp:LinkButton CssClass="Item" Text="<%$ Resources:Feature.Profile, ActionMakeTopFriend %>" runat="server" />
                <% } else { %>
                <asp:LinkButton CssClass="Item" Text="<%$ Resources:Feature.Profile, ActionRemoveTopFriend %>" runat="server" />
                <% } %>
                <asp:LinkButton CssClass="Item" Text="<%$ Resources:Feature.Profile, Action.Unfriend %>" runat="server" />
                <!--a class="Item" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$cphRoblox$rbxUserPane$rbxPublicUser$ctl00&quot;, &quot;&quot;, true, &quot;&quot;, &quot;&quot;, false, true))">Make Best Friend</a>
                <a class="Item" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$cphRoblox$rbxUserPane$rbxPublicUser$ctl01&quot;, &quot;&quot;, true, &quot;&quot;, &quot;&quot;, false, true))">Remove Best Friend</a>
                <a class="Item" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$cphRoblox$rbxUserPane$rbxPublicUser$ctl02&quot;, &quot;&quot;, true, &quot;&quot;, &quot;&quot;, false, true))">Unfriend</a-->
            </div>
        </div>
    <% } else if (UserProfile.FriendRequestPending) { %><%-- TODO: The enabled buttons in this section do nothing. Should this be handled in the backend? --%>
            <a id="FriendButton" class="GrayButton Disabled"><%=Resources.GetString("ActionFriendRequestPending") %></a>
    <% } else if (UserProfile.IncomingFriendRequestPending) { %>
            <a id="FriendButton" friend-request-id="" class="GrayButton accept-request"><%=Resources.GetString("Action.Accept") %></a>
    <%} else if (true) { %>
            <a id="FriendButton" data-target-user-id="<%=UserProfile.ProfileUserId %>" target-url="/friends/sendfriendrequest" class="friend-request-button GrayButton <% if (!UserProfile.MaySendFriendInvitation) { %>Disabled<% } %>"><%=Resources.GetString("ActionSendFriendInvitation") %></a>
    <% } else { %>
            <a id="FriendButton" class="GrayButton <% if (UserProfile.MaySendFriendInvitation) { %>"  href="/My/FriendInvitation.aspx?RecipientID=<%=UserProfile.ProfileUserId %><% } else { %>Disabled<% } %>"><%=Resources.GetString("ActionSendFriendInvitation") %></a>
    <% } %>
    <% if (!UserProfile.MessagesDisabled) { %>
    <div class="SendMessageProfileBtnDiv">
        <a id="MessageButton" style="margin:0 5px" class="GrayButton <% if (UserProfile.CanMessage) { %>"  href="/My/NewMessage.aspx?RecipientID=<%=UserProfile.ProfileUserId %><% } else { %>Disabled<% } %>"><%=Resources.GetString("ActionSendMessage") %></a>
    </div>
	<% } %>
    <% if (UserProfile.IsMoreBtnVisible) { %>
        <div id="MoreButton" class="GrayDropdown">
            <div class="Button">More</div>
            <div class="Menu">
                <%  // More dropdown
                    if (UserProfile.CanBeFollowed)
                    {
                %>
                    <div class="Item" onclick="<%=UserProfile.GetFollowScript %>"><%=Resources.GetString("ActionJoinGame") %></div>
                <%
                    }
                    if (!UserProfile.IsChatDisabledByPrivacySetting)
                    {
                %>
                    <div class="Item" onclick="ChatBar.ShowFriends();ChatBar.ToggleChat('<%=UserProfile.ProfileUserId %>', '<%=UserProfile.ProfileUserName %>');"><%=Resources.GetString("ActionStartChatting") %></div>
                <%
                    }
                    if (UserProfile.CanTrade)
                    {
                %>
                    <div class="Item" onclick="window.open('/Trade/TradeWindow.aspx?TradePartnerID=<%=UserProfile.ProfileUserId %>', '_blank', 'scrollbars=0, resizeable=no, height=624, width=898');"><%=Resources.GetString("Action.TradeItems") %></div>
                <%
                    }
                    if (false)
                    {
                %>
                    <div class="Item" onclick="Party.InviteUser('<%=UserProfile.ProfileUserName %>');"><%=Resources.GetString("ActionInviteToParty") %></div>
                <%
                    }
                    if (UserProfile.IsBlockButtonVisible)
                    {
                %>
                    <div class="Item" id="BlockButton" data-already-blocked=<%=UserProfile.IsVieweeBlocked %> data-target-user-id="<%=UserProfile.ProfileUserId %>"><%=Resources.GetString("Action.BlockUser") %></div>
                <%
                    }
                %>
            </div>
        </div>
    <% } %>
    <div class="clear"></div>
    <div style="display:none" class="status-error"></div>
    <script type="text/javascript">
        function hideDropdowns() {
            $('.GrayDropdown .Button.Active').removeClass('Active').siblings('.Menu').hide();
        }
        function setProfileButtonsWidth() {
            $('#ProfileButtons').width($('#FriendButton').outerWidth() + $('#MessageButton').outerWidth() + $('#MoreButton').outerWidth() <% if (false) {%>+ $('#FollowButton').outerWidth() + 22<% } else { %>+ 10<% } %>);
        }

        setProfileButtonsWidth();
        $('.GrayDropdown .Button').click(function () {
            var show = !$(this).hasClass('Active');
            hideDropdowns();
            if (show) {
                $(this).addClass('Active').siblings('.Menu').show();
            }

            return false;
        });
        $(document).click(function () {
            hideDropdowns();
        });
        $('#MoreButton [original-title]').tipsy();
        var friendRequestButton = $(".friend-request-button");

        friendRequestButton.click(function () {
            if (!friendRequestButton.is(".disabled")) {
                var data = {
                    targetUserID: friendRequestButton.data("target-user-id")
                };
                var url = friendRequestButton.data("target-url");
                var isAcceptRequest = friendRequestButton.is(".accept-request");
                if (isAcceptRequest) {
                    data.invitationID = friendRequestButton.data("friend-request-id");
                }
                $.post(url, data, function (response) {
                    if (isAcceptRequest && response.success) {
                        var friendsUrl = friendRequestButton.data("friends-url");
                        window.location = friendsUrl;
                        return false;
                    }
                    friendRequestButton.addClass("disabled");
                    if (response.success) {
                        friendRequestButton.text("<%=Resources.GetString("ActionFriendRequestPending") %>");
                        setProfileButtonsWidth();
                    } else {
                        Roblox.GenericModal.open("Failure", null, response.message);
                    }
                });
            }
        });
        $(".follow-button").on("follow-update", function () {
            setProfileButtonsWidth();
        });
        var Roblox = Roblox || {};
        Roblox.FollowingButton = Roblox.FollowingButton || {};
        Roblox.FollowingButton.Resources = {};
        //<sl:translate>
        Roblox.FollowingButton.Resources.FollowText = "Follow";
        Roblox.FollowingButton.Resources.UnFollowText = "Stop Following";
        //</sl:translate>
    </script>
</div>
<% } %>