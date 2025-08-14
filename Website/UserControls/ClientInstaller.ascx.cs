using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels;

namespace Roblox.Website.UserControls
{
    public partial class ClientInstaller : System.Web.UI.UserControl
    {
        public ClientInstallerViewModel ClientInstallerModel;

        protected void Page_Load(object sender, EventArgs e)
        {
            ClientInstallerModel = new ClientInstallerViewModel(Request.UserAgent)
            {
                VisitGameResources = new RobloxResourceSet("Common.VisitGame"),
                ControlsResources = new RobloxResourceSet("CommonUI.Controls")
            };
        }
    }
}