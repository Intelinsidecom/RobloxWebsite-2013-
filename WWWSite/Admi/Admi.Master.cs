using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.Admi
{
    public partial class Admi : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "ROBLOX | Administration";
        }

        protected void AdminDashboardTreeView_TreeNodeDataBound(object sender, TreeNodeEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Node.NavigateUrl) && e.Node.NavigateUrl == HttpContext.Current.Request.Url.AbsolutePath/* || e.Node.NavigateUrl.Substring(1) == HttpContext.Current.Request.Url.AbsolutePath*/)
                e.Node.Text = "<B>" + e.Node.Text + "</B>";
        }
    }
}