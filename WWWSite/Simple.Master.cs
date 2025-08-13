using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.StaticContent;
using Roblox.Website.ViewModels;

namespace Roblox.Website
{
    public partial class Simple : System.Web.UI.MasterPage
    {
        public MetaTagListViewModel MetaTagListViewModel { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            SetupBundles();
            MetaTagListViewModel = new MetaTagListViewModel();
            SetupMetadata(MetaTagListViewModel);
        }

        private void SetupBundles()
        {
        }

        private void SetupMetadata(MetaTagListViewModel metaTagModel)
        {
            if (string.IsNullOrEmpty(Page.Title))
                Page.Title = "ROBLOX.com";

            Page.MetaKeywords = metaTagModel.Keywords;
            Page.MetaDescription = metaTagModel.Description;
        }
    }
}