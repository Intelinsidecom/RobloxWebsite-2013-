using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.Login
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
                Response.Redirect("~/", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}