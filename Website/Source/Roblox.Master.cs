using System;
using System.Web.UI;
using System.Collections.Generic;
using Roblox.Website.ViewModels;

namespace Roblox.Website
{
    public partial class RobloxMaster : System.Web.UI.MasterPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            SetupBundles();
            SetupMetadata(new MetaTagListViewModel());
        }


        private void SetupBundles()
        {
            //RobloxCSS.PageCSS.Add("PartialViews/Navigation.css");
            // Moved to MenuRedesign.ascx
        }


        private void SetupMetadata(MetaTagListViewModel metaTagModel)
        {
            if (string.IsNullOrEmpty(Page.Title))
                Page.Title = "ROBLOX.com";
            else
                Page.Title += " - ROBLOX";

            Page.Header.Description = metaTagModel.Description;
            Page.Header.Keywords = metaTagModel.Keywords;
            Page.MetaDescription = metaTagModel.Description;
            Page.MetaKeywords = metaTagModel.Keywords;
            metadescription.Content = Page.MetaDescription;
            metakeywords.Content = Page.MetaKeywords;
        }
    }
}