using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels;

namespace Roblox.Website.UserControls.TrackingPixels
{
    public partial class JavascriptErrorTracker : System.Web.UI.UserControl
    {
        public JavascriptErrorTrackerViewModel JavascriptErrorTrackerViewModel = new JavascriptErrorTrackerViewModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}