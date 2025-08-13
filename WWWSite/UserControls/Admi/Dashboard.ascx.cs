using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls.Admi
{
    public partial class Dashboard : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScriptManager cs = Page.ClientScript;
            ScriptManager sm = ScriptManager.GetCurrent(Page);
            sm.Scripts.Add(new ScriptReference("~/js/Dashboard.js"));
            //cs.RegisterClientScriptInclude("Dashboard.js", ResolveClientUrl("~/js/Dashboard.js"));
            sm.Services.Add(new ServiceReference("~/Reporting/Dashboard.asmx"));
            cs.RegisterStartupScript(this.GetType(), "DashboardScript",
                "rbx_dashboard_control = $get('" + Panel1.ClientID + "'); " +
                "window.setTimeout('RBX_Update_Dashboard()', 1000);"
            , true);
        }
    }
}