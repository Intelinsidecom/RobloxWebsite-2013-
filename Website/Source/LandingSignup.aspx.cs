using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.StaticContent;

namespace Roblox.Website
{
    public partial class LandingSignup : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
                Response.Redirect("~/", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            RobloxCSS.PageCSS.Add("Pages/LandingSignUp.css");
            RobloxScripts.PageScripts.Add("SignupFormValidator.js");
            RobloxScripts.PageScripts.Add("FormValidator.js");
        }
    }
}