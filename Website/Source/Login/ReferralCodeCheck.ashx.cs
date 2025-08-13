using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.Login
{
    /// <summary>
    /// Summary description for ReferralCodeCheck
    /// </summary>
    public class ReferralCodeCheck : IHttpHandler
    {

		#region IHttpHandler Members

		public bool IsReusable
		{
			get { return true; }
		}

		public void ProcessRequest(HttpContext context)
		{
			HttpRequest request = context.Request;
			var queryString = request.QueryString;

			string code = queryString["code"];
			bool result = false;

			if (!string.IsNullOrEmpty(code))
			{
				if (code.Length >= 4)
				{
					// Valid code
					result = true;
				}
			}

			context.Response.Write(result.ToString().ToLower());
		}

		#endregion
    }
}