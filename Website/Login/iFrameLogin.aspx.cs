using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Roblox.Website.Login
{
    public partial class iFrameLogin : System.Web.UI.Page
    {
        // TODO: CaptchaOn should be set via a site-wide Roblox.Configuration setting
        public bool CaptchaOn;
        public string ClientIPAddress;
        public string ParentURL;

        protected void Page_Load(object sender, EventArgs e)
        {
            CaptchaOn = false;
            ClientIPAddress = "";
            ParentURL = HttpUtility.HtmlEncode(Request["parentUrl"]) ?? "";

            if (Request.IsAuthenticated)
                FormsAuthentication.RedirectToLoginPage();

            DataBind();
        }
    }
}