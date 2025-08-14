using System;
using Roblox.Website.ViewModels.Users;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class UserGroupsPane : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;

            lNoResults.Text = String.Format(lNoResults.Text, UserProfile.ProfileDisplayName);
        }
    }
}