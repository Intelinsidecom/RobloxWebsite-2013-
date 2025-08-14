using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.Admi
{
    public partial class ChangeTheme : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            // It went white for whatever reason in the video
            Response.End();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}