using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Resources;
using Roblox.Website.ViewModels.Users;
using Roblox.Web.StaticContent;
using Roblox.Web.Code;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class PublicUser : System.Web.UI.UserControl
    {
        public ProfileViewModel UserProfile;
        public RobloxResourceSet Resources;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserProfile == null)
                return;
            Resources = UserProfile.ProfileLangResources;

            RobloxCSS.PageCSS.Add("~/CSS/Pages/Profile/Profile.css");
        }
    }
}