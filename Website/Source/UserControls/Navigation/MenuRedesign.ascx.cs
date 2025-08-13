using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.StaticContent;
using Roblox.Web.Code;

namespace Roblox.Website.UserControls.Navigation
{
    public partial class MenuRedesign : System.Web.Mvc.ViewUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RobloxCSS.PageCSS.Add("PartialViews/Navigation.css");
        }
    }
}