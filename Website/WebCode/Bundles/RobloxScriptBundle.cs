using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Web.Code;

namespace Roblox.Website
{
    public class RobloxScriptBundle
    {
        public string FileName { get; set; }
        
        public string Contents { get; set; }
        
        public string Url { get; set; }
        
        public RobloxScriptBundle(string fileName, string contents)
        {
            FileName = fileName;
            Contents = contents;
            Url = $"/js/m/{fileName}";
        }
        
        public RobloxScriptBundle(BundleCreationResult bundleResult)
        {
            FileName = bundleResult.FileName;
            Contents = bundleResult.Contents;
            // Extract just the filename from the path
            if (!string.IsNullOrEmpty(FileName))
            {
                string[] parts = FileName.Split('/');
                if (parts.Length > 0)
                {
                    Url = $"/js/m/{parts[parts.Length - 1]}";
                }
            }
        }
    }
}
