using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Users.Shared;

namespace Roblox.Website.UserControls.Navigation
{
    public partial class AlertsAndOptionsAuthenticated : System.Web.UI.UserControl
    {
        public UserAlertsViewModel UserAlerts;
        /*(
            ID: user.ID,
            Name: "Brent",
            Robux: 3572334,
            Tickets: 367289,
            Friends: 48, // TotalNumberOfOpenInvitationsReceived (return Invitation.GetTotalNumberOfOpenInvitationsReceived(ID))
            Messages: 10876 // TotalNumberOfUnreadMessages (return Message.GetTotalNumberOfUnreadMessages(ID))
        );*/
        protected void Page_Load(object sender, EventArgs e)
        {
            var userFactory = Global.MembershipDomainFactories.UserFactory;

            var user = userFactory.GetCurrentUser();
            //Roblox.User user = Roblox.User.GetCurrent();
            // Fetch from RobuxBalance and TicketsBalance
            UserAlerts = new UserAlertsViewModel(user.Id, user.Name, 0, 0, 0/*user.TotalNumberOfOpenInvitationsReceived*/, 0/*user.TotalNumberOfUnreadMessages*/);
        }
    }
}