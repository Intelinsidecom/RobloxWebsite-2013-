using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls.Admi.Users
{
    public partial class CheatDetections : System.Web.UI.UserControl
    {
        public int UserID { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            rbxCheatDetectionsTable.DataBind();
        }
    }
}