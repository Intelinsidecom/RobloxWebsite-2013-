using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Resources;
using Roblox.Website.ViewModels.Users;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class HeaderPane : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;

            if (!UserProfile.MayEdit)
            {
                ReportAbuse.Visible = true;
                ReportAbuse.OffendingID = UserProfile.ProfileUserId;
            }
            else
            {
                updateStatusLink.Visible = true;
                txtStatusMessage.MaxLength = UserProfile.EditStatusMaxLength;
                txtStatusMessage.Text = "TODO: Add Statuses";
            }
            nameRegion.Text = UserProfile.ProfileDisplayName;
            statusRegion.Text = "\"TODO: Add Statuses\"";

            DataBind();
        }
    }
}