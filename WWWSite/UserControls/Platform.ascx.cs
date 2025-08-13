using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls
{
    public partial class Platform : System.Web.UI.UserControl
    {
        public IAsset Place { get; set; }
        public User AuthenticatedUser { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            AuthenticatedUser = User.GetCurrent();
        }
    }
}