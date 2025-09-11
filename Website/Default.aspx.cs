using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            // Immediately redirect
            if (Request.IsAuthenticated)
                Response.Redirect("~/My/Home.aspx", true);

            // Unauthenticated: serve the signup page content but keep the root URL
            // This mirrors the old behavior where '/' shows signup without changing the address bar.
            Server.Transfer("~/Login/Signup.aspx", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}