using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.Login
{
    /// <summary>
    /// Summary description for Negotiate
    /// </summary>
    public class Negotiate : IHttpHandler
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