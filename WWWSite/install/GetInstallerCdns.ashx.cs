using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.install
{
    /// <summary>
    /// Summary description for GetInstallerCdns
    /// </summary>
    public class GetInstallerCdns : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.Write("[]");
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