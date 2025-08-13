using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Website.UserControls.Abuse
{
    public partial class ReportAbuseButton : System.Web.UI.UserControl
    {
        public long OffendingID { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string reportAbuseUrl = String.Format("AbuseReportUrlLoadedFromResources.aspx?ID={0}&RedirectUrl={1}", OffendingID, HttpContext.Current.Request.Url.AbsoluteUri);
            ReportAbuseIconHyperLink.NavigateUrl = reportAbuseUrl; //abuseReport/userprofile?id=33155788&amp;RedirectUrl=http%3a%2f%2fwww.roblox.com%2fUser.aspx%3fID%3d33155788
            ReportAbuseTextHyperLink.NavigateUrl = reportAbuseUrl;
        }
    }
}