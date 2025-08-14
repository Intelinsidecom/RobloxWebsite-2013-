using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;

namespace RobloxWebSite.Game 
{
    /// <summary>
    /// Summary description for Join
    /// </summary>
    public class Join : IHttpHandler 
    {

        public void ProcessRequest(HttpContext context) 
        {
            context.Response.ContentType = "application/json";
            context.Response.Write("{}");
        }

        public bool IsReusable => false;
    }
}
