using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls
{
    public partial class Alerts : System.Web.UI.UserControl
    {
        public long UserID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserID != 0)
            {
                MessageAlertCaptionHyperLink.Text = "0"; // TotalNumberOfUnreadMessages
                FriendsAlertCaptionHyperLink.Text = "0"; // TotalNumberOfOpenInvitationsReceived
                RobuxAlertCaptionHyperLink.Text = "0";
                TicketsAlertCaptionHyperLink.Text = "0";
                //RobuxAlertCaptionHyperLink.Text = RobuxBalance.GetOrCreate(user.ID);
                //TicketsAlertCaptionHyperLink.Text = TicketsBalance.GetOrCreate(user.ID);
            }
        }
    }
}