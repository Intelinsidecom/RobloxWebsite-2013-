using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Configuration;

namespace Roblox.Website
{
    public partial class SystemEnvironmentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Populate fields defensively to avoid crashes when configuration is misbehaving
            try
            {
                // Environment Abbrev + Id
                string abbrev = SafeGet(() => RobloxEnvironment.Abbreviation) ?? "?";
                string id = SafeGet(() => RobloxEnvironment.Id.ToString()) ?? "?";
                var lblAbbrevId = (Label)Master.FindControl("cphRoblox").FindControl("lblEnvAbbrevId");
                if (lblAbbrevId != null) lblAbbrevId.Text = abbrev + id;

                // Name
                var lblName = (Label)Master.FindControl("cphRoblox").FindControl("lblEnvName");
                if (lblName != null) lblName.Text = SafeGet(() => RobloxEnvironment.Name) ?? "?";

                // Machine
                var lblMachine = (Label)Master.FindControl("cphRoblox").FindControl("lblMachine");
                if (lblMachine != null) lblMachine.Text = Environment.MachineName;

                // Domain
                var lblDomain = (Label)Master.FindControl("cphRoblox").FindControl("lblDomain");
                if (lblDomain != null) lblDomain.Text = SafeGet(() => RobloxEnvironment.Domain) ?? "?";

                // Website URL
                var lnkWebsite = (System.Web.UI.HtmlControls.HtmlAnchor)Master.FindControl("cphRoblox").FindControl("lnkWebsite");
                var websiteUrl = SafeGet(() => RobloxEnvironment.WebsiteUrl);
                if (lnkWebsite != null && !string.IsNullOrWhiteSpace(websiteUrl))
                {
                    lnkWebsite.HRef = websiteUrl;
                    lnkWebsite.InnerText = websiteUrl;
                }

                // App URL from Website settings
                var lblAppUrl = (Label)Master.FindControl("cphRoblox").FindControl("lblAppUrl");
                if (lblAppUrl != null)
                {
                    lblAppUrl.Text = SafeGet(() => Roblox.WebsiteSettings.Properties.Settings.Default.ApplicationURL) ?? "?";
                }

                var lblStatus = (Label)Master.FindControl("cphRoblox").FindControl("lblStatus");
                if (lblStatus != null)
                {
                    lblStatus.Text = "OK";
                }
            }
            catch (Exception ex)
            {
                var lblStatus = (Label)Master.FindControl("cphRoblox").FindControl("lblStatus");
                if (lblStatus != null)
                {
                    lblStatus.Text = "Error: " + ex.GetType().Name + ": " + ex.Message;
                }
            }
        }

        private T SafeGet<T>(Func<T> getter)
        {
            try { return getter(); } catch { return default(T); }
        }
    }
}
