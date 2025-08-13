using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Platform.Membership;
using Roblox.Platform.Email;

namespace Roblox.Website.Admi
{
    public partial class Test : System.Web.UI.Page
    {
        private static MembershipDomainFactories _factories;

        public IUser IUser { get; private set; }

        static Test()
        {
            _factories = Global.MembershipDomainFactories;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}