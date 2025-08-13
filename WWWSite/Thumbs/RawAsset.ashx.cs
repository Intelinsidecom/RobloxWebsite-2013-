using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.Thumbs
{
    /// <summary>
    /// Summary description for RawAsset
    /// </summary>
    public class RawAsset : IHttpHandler
    {
        // https://208.185.116.66/Thumbs/RawAsset.ashx?assetId=1818&width=420&height=420&imageFormat=PNG
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("https://t1.rbxcdn.com/93a3dc9a6693b7fd9b57c2290e3058fb");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}