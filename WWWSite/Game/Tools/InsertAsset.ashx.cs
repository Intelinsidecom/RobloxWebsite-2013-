using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.Game.Tools
{
    /// <summary>
    /// Summary description for InsertAsset
    /// </summary>
    public class InsertAsset : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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