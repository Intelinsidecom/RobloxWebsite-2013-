using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;

namespace RobloxWebSite.Game 
{
    /// <summary>
    /// Summary description for ChatFilter
    /// </summary>
    public class ChatFilter : IHttpHandler 
    {

        public void ProcessRequest(HttpContext context) 
        {
            context.Response.ContentType = "application/json";
            context.Response.Write("{\"data\":[]}");
        }

        public bool IsReusable => false;
    }
}
