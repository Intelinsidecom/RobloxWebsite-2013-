using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Web.Code;

namespace Roblox.Website
{
    public class RobloxCSSBundle
    {
        public string FileName { get; set; }
        
        public string Contents { get; set; }
        
        public string Url { get; set; }
        
        public RobloxCSSBundle(string fileName, string contents)
        {
            FileName = fileName;
            Contents = contents;
            Url = $"/css/m/{fileName}";
        }
        
        public RobloxCSSBundle(BundleCreationResult bundleResult)
        {
            FileName = bundleResult.FileName;
            Contents = bundleResult.Contents;
            // Extract just the filename from the path
            if (!string.IsNullOrEmpty(FileName))
            {
                string[] parts = FileName.Split('/');
                if (parts.Length > 0)
                {
                    Url = $"/css/m/{parts[parts.Length - 1]}";
                }
            }
        }
    }
}
