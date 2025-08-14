using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Website.ViewModels.Navigation
{
    public class AlertsAndOptionsViewModel
    {
        public string UserName { get; }
        public int RobuxBalance { get; }
        public int TicketsBalance { get; }
        public int Friends { get; }
        public int Messages { get; }
        public bool IsAge13OrOver { get; }

        public RobloxResourceSet LangResourceSet { get; }
        public string RobuxBalanceMessage { get; }
        public string TicketsBalanceMessage { get; }
        public string FriendsMessage { get; }
        public string MessagesMessage { get; }


        public AlertsAndOptionsViewModel(IUser user)
        {
            LangResourceSet = new RobloxResourceSet("Common.AlertsAndOptionsResources");

            UserName = user.Name;
            RobuxBalance = 0;
            TicketsBalance = 0;
            Friends = 0;
            Messages = 0;
            IsAge13OrOver = user.AgeBracket == Platform.Membership.AgeBracket.Age13OrOver;

            FriendsMessage = Friends > 0 ? string.Format(LangResourceSet["Label.sFriendInvitationsMessage"], Friends.ToString("N0")) : LangResourceSet["Label.sFriendInvitations"];
            MessagesMessage = Messages > 0 ? string.Format(LangResourceSet["Label.sMessagesMessage"], Messages.ToString("N0")) : LangResourceSet["Label.sMessages"];
        }
    }
}