using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobloxWebSite.AbuseReport {
    /// <summary>
    /// Summary description for InGameChatHandler
    /// </summary>
    public class InGameChatHandler : IHttpHandler {

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