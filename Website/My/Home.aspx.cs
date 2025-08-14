using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.My
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            // Immediately redirect
            // Should be redirecting with whole BaseUrl, but whatever...
            Response.Redirect("/home", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}