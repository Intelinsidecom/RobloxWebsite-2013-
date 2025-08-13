using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Admi.UserAdmin;

namespace Roblox.Website.UserControls.Admi.UserAdmin
{
    public partial class GiveAndTakePane : System.Web.UI.UserControl
    {
        public GiveAndTakeViewModel Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}