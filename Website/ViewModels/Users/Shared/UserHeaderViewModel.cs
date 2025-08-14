using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Web.Code.Util;

namespace Roblox.Website.ViewModels.Users.Shared
{
    public class UserAlertsViewModel
    {
        public long ID;
        public string Name;
        public int Robux;
        public int Tickets;
        public int Friends;
        public int Messages;
        public string FriendsAlertCaption;
        public string MessagesAlertCaption;
        public string FriendsToolTip;
        public string MessagesToolTip;
        public string RobuxAlertCaption;
        public string TicketsAlertCaption;
        public string RobuxToolTip;
        public string TicketsToolTip;

        public UserAlertsViewModel(long ID, string Name, int Robux, int Tickets, int Friends, int Messages)
        {
            this.ID = ID;
            this.Name = Name;
            this.Robux = Robux;
            this.Tickets = Tickets;
            this.Friends = Friends;
            this.Messages = Messages;
            this.FriendsAlertCaption = Abbreviate.GetTruncValue(Friends);
            this.MessagesAlertCaption = Abbreviate.GetTruncValue(Messages);
            this.FriendsToolTip = Friends > 0 ? Friends.ToString("N0") : "";
            this.MessagesToolTip = Messages > 0 ? Messages.ToString("N0") : "";
            this.RobuxAlertCaption = Abbreviate.GetTruncValue(Robux);
            this.TicketsAlertCaption = Abbreviate.GetTruncValue(Tickets);
            this.RobuxToolTip = Robux > 0 ? Robux.ToString("N0") : "";
            this.TicketsToolTip = Tickets > 0 ? Tickets.ToString("N0") : "";
        }
    }
}