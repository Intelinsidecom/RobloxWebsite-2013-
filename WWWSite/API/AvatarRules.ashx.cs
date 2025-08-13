using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.API {
    /// <summary>
    /// Summary description for AvatarRules
    /// </summary>
    public class AvatarRules : IHttpHandler {

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