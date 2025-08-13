using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobloxWebSite.Thumbs {
    /// <summary>
    /// Summary description for AvatarImage
    /// </summary>
    public class AvatarImage : IHttpHandler {

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