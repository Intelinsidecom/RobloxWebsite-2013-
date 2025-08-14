using System;
using System.Resources;
using Roblox.Website.ViewModels.Users;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class SetsPane : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;
        public RobloxResourceSet Resources;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;
            Resources = UserProfile.ProfileLangResources;
        }
    }
}