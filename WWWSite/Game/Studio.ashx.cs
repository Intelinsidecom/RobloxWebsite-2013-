using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobloxWebSite.Game {
    /// <summary>
    /// Summary description for Studio
    /// </summary>
    public class Studio : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}