using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels
{
    public class StructuredDataTags
    {
        public string StructuredDataContext { get; set; }
        public string StructuredDataType { get; set; }
        public string StructuredDataName { get; set; }
        public string RobloxUrl { get; set; }
        public string RobloxLogoUrl { get; set; }
        public string RobloxFacebookUrl { get; set; }
        public string RobloxTwitterUrl { get; set; }
        public string RobloxLinkedInUrl { get; set; }
        public string RobloxInstagramUrl { get; set; }
        public string RobloxYouTubeUrl { get; set; }
        public string RobloxGooglePlusUrl { get; set; }
        public string RobloxTwitchTvUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public string ImageWidth { get; set; }
        public string ImageHeight { get; set; }

        public StructuredDataTags()
        {
            StructuredDataContext = "http://schema.org";
            StructuredDataType = "Organization";
            StructuredDataName = "ROBLOX";
            RobloxUrl = "https://www.roblox.com/";
		    RobloxLogoUrl = StaticContent.GetUrl("~/Images/Logo/RobloxIcon.png");
		    RobloxFacebookUrl = "https://www.facebook.com/ROBLOX/";
		    RobloxTwitterUrl = "https://twitter.com/roblox";
		    RobloxLinkedInUrl = "https://www.linkedin.com/company/147977";
		    RobloxInstagramUrl = "https://www.instagram.com/roblox/";
		    RobloxYouTubeUrl = "https://www.youtube.com/user/roblox";
		    RobloxGooglePlusUrl = "https://plus.google.com/+roblox";
		    RobloxTwitchTvUrl = "https://www.twitch.tv/roblox";
		    Title = "ROBLOX";
        }
    }

    public class MetaTagListViewModel
    {
        public Dictionary<string, string> FacebookMetaTags { get; set; }
        public Dictionary<string, string> TwitterMetaTags { get; set; }
        public StructuredDataTags StructuredDataTags { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public bool NoIndexNoFollow { get; set; }
        public bool NoIndex { get; set; }
        public bool NoFollow { get; set; }
        public bool IncludeReferrerOriginTag { get; set; }
        public string GoogleSiteVerificationTag { get; set; }

        public MetaTagListViewModel()
        {
            StructuredDataTags = new StructuredDataTags();
            Description = "User-generated MMO gaming site for kids, teens, and adults. Players architect their own worlds. Builders create free online games that simulate the real world. Create and play amazing 3D games. An online gaming cloud and distributed physics engine.";
            Keywords = "free games, online games, building games, virtual worlds, free mmo, gaming cloud, physics engine";
            NoIndexNoFollow = false;
            NoIndex = false;
            NoFollow = false;
            IncludeReferrerOriginTag = false;
        }

        public Dictionary<string, string> GetMetaTags()
        {
            Dictionary<string, string> metaTags = new Dictionary<string, string>
            {
                { "author", "ROBLOX Corporation" },
                { "description", this.Description },
                { "keywords", this.Keywords},
                { "robots", "all" }
            };
            return metaTags;
        }
    }
}