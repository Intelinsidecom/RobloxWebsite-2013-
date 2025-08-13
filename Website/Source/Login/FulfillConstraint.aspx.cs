using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.Maintenance;

namespace Roblox.Website.Login
{
    public partial class FulfillConstraint : System.Web.UI.Page
    {
        private string ReturnURL;

        protected void Page_PreInit(object sender, EventArgs e)
        {
            ReturnURL = !string.IsNullOrEmpty(Request["ReturnUrl"]) ? Request["ReturnUrl"] : "/";

            if (!CookieConstraintManager.IsRequesterConstrained())
            {
                Response.Redirect(ReturnURL, true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_OnClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var buttonText = button.Text.ToLower();
            var password = Textbox1.Text;

            // Attempt to lift constraint
            CookieConstraintManager.LiftConstraint(password, buttonText);
            Response.Redirect(ReturnURL, true);
        }
    }
}