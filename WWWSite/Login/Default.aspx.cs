using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.Providers;

namespace Roblox.Website.Login
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Redirect("/NewLogin", true);

            /*if (Request.IsAuthenticated)
            {
                Response.Redirect("~/Default.aspx");
                return;
            }*/
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}