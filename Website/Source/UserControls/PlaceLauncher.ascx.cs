using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels;

namespace Roblox.Website.UserControls
{
    public partial class PlaceLauncher : System.Web.UI.UserControl
    {
        public PlaceLauncherViewModel PlaceLauncherModel;

        protected void Page_Load(object sender, EventArgs e)
        {
            PlaceLauncherModel = new PlaceLauncherViewModel()
            {
                VisitGameResources = new RobloxResourceSet("Common.VisitGame"),
                GuestModeResources = new RobloxResourceSet("Feature.GameLaunchGuestMode")
            };
        }
    }
}