using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Admi.UserAdmin;

namespace Roblox.Website.UserControls.Admi.UserAdmin
{
    public partial class BillingInfoPane : System.Web.UI.UserControl
    {
        public BillingInfoViewModel Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            BillingInfoFormView.DataSource = new[] { Model };
            BillingInfoFormView.DataBind();
        }
    }
}