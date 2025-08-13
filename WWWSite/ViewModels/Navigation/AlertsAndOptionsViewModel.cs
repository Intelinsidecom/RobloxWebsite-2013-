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

        public string RobuxBalanceMessage { get; }
        public string TicketsBalanceMessage { get; }
        public string FriendsMessage { get; }
        public string MessagesMessage { get; }


        public AlertsAndOptionsViewModel(IUser user)
        {

            UserName = user.Name;
            RobuxBalance = 0;
            TicketsBalance = 0;
            Friends = 0;
            Messages = 0;
            IsAge13OrOver = user.AgeBracket == Platform.Membership.AgeBracket.Age13OrOver;

        }
    }
}