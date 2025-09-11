using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using Roblox.Website.ViewModels;
using Roblox.Web.Code;
using Roblox.Web.StaticContent;

namespace Roblox.Website
{
    public partial class RobloxMaster : System.Web.UI.MasterPage
    {


        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            // Apply default title as early as possible if none is specified by the page.
            if (string.IsNullOrEmpty(Page.Title))
            {
                Page.Title = PageTitleProvider.GetForRequest(Context);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SetupBundles();
            SetupMetadata(new MetaTagListViewModel());
            EnsureBundlesRendered();
        }


        private void SetupBundles()
        {
            //RobloxCSS.PageCSS.Add("PartialViews/Navigation.css");
            // Moved to MenuRedesign.ascx
        }

        private void EnsureBundlesRendered()
        {
            // Insert CSS and JS bundles into the <head> to prevent raw output at the top of the page.
            if (Page?.Header == null)
            {
                return;
            }

            // CSS bundles
            var cssHtml = string.Empty;
            try
            {
                cssHtml += RobloxCSSShim.RenderBundleHtml("main");
            }
            catch { /* ignore if unavailable */ }
            try
            {
                cssHtml += RobloxCSSShim.RenderHtml(StaticContent.GetPageCSSBundle());
            }
            catch { /* ignore if unavailable */ }

            if (!string.IsNullOrWhiteSpace(cssHtml))
            {
                // Add CSS as early as possible in the head
                Page.Header.Controls.AddAt(0, new Literal { Text = cssHtml });
            }

            // Script bundles
            var scriptsHtml = string.Empty;
            try
            {
                scriptsHtml += RobloxScriptsShim.RenderBundle("master");
            }
            catch { /* ignore if unavailable */ }
            try
            {
                scriptsHtml += RobloxScriptsShim.Render(StaticContent.GetPageScriptBundle());
            }
            catch { /* ignore if unavailable */ }

            if (!string.IsNullOrWhiteSpace(scriptsHtml))
            {
                Page.Header.Controls.Add(new Literal { Text = scriptsHtml });
            }
        }


        private void SetupMetadata(MetaTagListViewModel metaTagModel)
        {
            // If the page already defined a title, respect it.
            // Otherwise, use our default/provider-based title.
            if (string.IsNullOrEmpty(Page.Title))
            {
                Page.Title = PageTitleProvider.GetForRequest(Context);
            }

            // Ensure the HtmlHead title reflects the computed Page.Title
            if (Page.Header != null)
            {
                Page.Header.Title = Page.Title;
            }

            Page.Header.Description = metaTagModel.Description;
            Page.Header.Keywords = metaTagModel.Keywords;
            Page.MetaDescription = metaTagModel.Description;
            Page.MetaKeywords = metaTagModel.Keywords;
            metadescription.Content = Page.MetaDescription;
            metakeywords.Content = Page.MetaKeywords;
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            // Final safeguard to ensure we always have a meaningful title.
            if (string.IsNullOrWhiteSpace(Page.Title))
            {
                Page.Title = PageTitleProvider.GetForRequest(Context);
            }

            // Make sure the <title> element is synchronized right before rendering
            if (Page.Header != null)
            {
                Page.Header.Title = Page.Title;
            }

            // Evaluate any data-bound expressions (e.g., <%# ... %>) in the master page, including the <head> content.
            // This ensures CSS/JS bundle markup renders in-place, not as raw text at the top of the page.
            this.DataBind();
        }

    }
}