<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlertsAndOptionsAuthenticated.ascx.cs" Inherits="Roblox.Website.UserControls.Navigation.AlertsAndOptionsAuthenticated" %>
<div id="SiteWideHeaderLogin">
  <div id="AlertSpace">
          <div class="AlertItem" style="max-width: 50px;text-align:center;" id="logoutonclick">
            <a id="lsLoginStatus" data-se="nav-logout" class="logoutButton">Logout</a>
          </div>
          <div class="HeaderDivider"></div>
          <a data-se="nav-Tickets" href="/My/Money.aspx?tab=MyTransactions">
            <div id="TicketsWrapper" class="TicketsAlert AlertItem tooltip-bottom" original-title="Tickets <%=UserAlerts.TicketsToolTip%>">
              <div class="icons tickets_icon"></div>
              <div id="TicketsAlertCaption" class="AlertCaption"><%=UserAlerts.TicketsAlertCaption%></div>
            </div>
          </a>
          <a data-se="nav-robux" href="/My/Money.aspx?tab=MyTransactions">
            <div id="RobuxWrapper" class="RobuxAlert AlertItem tooltip-bottom" original-title="Robux <%=UserAlerts.RobuxToolTip%>">
              <div class="icons robux_icon"></div>
              <div id="RobuxAlertCaption" class="AlertCaption"><%=UserAlerts.RobuxAlertCaption%></div>
            </div>
          </a>
          <div class="HeaderDivider"></div>
          <a data-se="nav-friends" href="/My/EditFriends.aspx#FriendRequestsTab">
            <span id="FriendsTextWrapper" class="FriendsAlert AlertItem tooltip-bottom" original-title="<%=UserAlerts.FriendsToolTip%> <asp:Literal runat='server' Text='<%$ Resources: FriendRequests%>'/>">
              <% if (UserAlerts.Friends > 0)
                  {%>
              <div id="FriendsBubble" class="AlertTextWrapper" runat="server">
                <div class="AlertBox Left"></div>
                <div class="AlertBox Right" style="background-position:right; padding-right:3px;">
                  <div class="AlertText"><%=UserAlerts.FriendsAlertCaption%></div>
                </div>
              </div>
                <% } %>
              <div class="icons friends_icon" style="float:none;"></div>
            </span>
          </a>
          <a data-se="nav-messages" href="/My/Messages.aspx">
            <span id="MessagesTextWrapper" class="MessageAlert AlertItem tooltip-bottom" original-title="<%=UserAlerts.MessagesToolTip%> <asp:Literal runat='server' Text='<%$ Resources: Messages%>'/>">
              <div class="icons message_icon" style="float:none;"></div>
              <% if (UserAlerts.Messages > 0)
                  {%>
              <div id="MessageBubble" class="AlertTextWrapper" runat="server">
                <div class="AlertBox Left"></div>
                <div class="AlertBox Right" style="background-position:right; padding-right:3px;">
                  <div class="AlertText"><%=UserAlerts.MessagesAlertCaption%></div>
                </div>
              </div>
                <% } %>
            </span>
          </a>
    <a data-se="nav-login" href="/User.aspx">
        <div id="AuthenticatedUserNameWrapper">
            <div id="AuthenticatedUserName">
                
                <!--span class="login-span notranslate"-->
                <span class="notranslate">
                    <img ID="over13icon" src="/Images/Icons/over13.png" alt="" class="tooltip-bottom" style="vertical-align:middle;padding-right:5px;padding-left:0px;" original-title="<%$ Resources: Over13 %>" ClientIDMode="Static" runat="server" /> 
                    <%=UserAlerts.Name%>
                </span>
            </div>
        </div> 

    </a>

    <script type="text/javascript">
        ; $(function () {
            // this is currently broken for some reason, so instead I've set the class of the over13icon
            $('#over13icon').tipsy({ gravity: 'n' });

            $("#lsLoginStatus").click(
                function () {
                    var form = $(this).closest('form');
                    if (form.length == 0) {
                        form = $("<form></form>").appendTo("body");
                    }
                    form.attr('action', '/authentication/logout');
                    form.attr('method', 'post');
                    form.submit();
                }
            );
        });

    </script> 
  </div>
</div>