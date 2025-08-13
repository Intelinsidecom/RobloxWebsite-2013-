using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobloxWebSite.Game.Badge {
    /// <summary>
    /// Summary description for HasBadge
    /// </summary>
    public class HasBadge : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write(0);
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}