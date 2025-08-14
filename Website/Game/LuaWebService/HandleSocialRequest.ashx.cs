using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobloxWebSite.Game.LuaWebService {
    /// <summary>
    /// Summary description for HandleSocialRequest
    /// </summary>
    public class HandleSocialRequest : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            int playerId = int.Parse(context.Request.QueryString["playerid"]);

            context.Response.ContentType = "text/xml";

            switch (context.Request.QueryString["method"])
            {
                case "IsFriendsWith":
                    context.Response.Write("<Value type=\"boolean\">false</Value>");
                    break;
                case "IsBestFriendsWith":
                    context.Response.Write("<Value type=\"boolean\">false</Value>");
                    break;
                case "IsInGroup":
                    int groupId = int.Parse(context.Request.QueryString["groupid"]);

                    context.Response.Write("<Value type=\"boolean\">true</Value>");
                    break;
                case "GetGroupRank":
                    context.Response.Write("<Value type=\"string\">asd</Value>");
                    break;
                case "GetGroupRole":
                    context.Response.Write("<Value type=\"string\">asd</Value>");
                    break;
                default:
                    break;
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}