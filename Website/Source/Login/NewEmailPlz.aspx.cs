using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.Login
{
    public partial class NewEmailPlz : System.Web.UI.Page
    {
        public string ReturnUrl { get; set; }
        public string Age { get; set; }
        public byte Gender { get; set; }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            // Immediately redirect
            if (!Request.IsAuthenticated)
                Response.Redirect("~/Default.aspx", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}