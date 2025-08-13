using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.StaticContent;
using Roblox.Web.Code;

namespace Roblox.Website.UserControls.Modals
{
    public partial class ConfirmationModal : System.Web.Mvc.ViewUserControl
    {
        protected RobloxResourceSet LangResources = new RobloxResourceSet("CommonUI.Controls");

        protected void Page_Load(object sender, EventArgs e)
        {
            RobloxScripts.PageScripts.Add("GenericConfirmation.js");
        }
    }
}