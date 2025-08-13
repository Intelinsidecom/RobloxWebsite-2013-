using System;
using System.Collections.Specialized;
using System.Web;

namespace Roblox.Web.ElevatedActions.Base;

public class HttpRequestKeyInfoExtractor : IHttpRequestKeyInfoExtractor
{
	public string GetIpAddress(HttpRequestBase request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return _GetIpAddress(request.ServerVariables);
	}

	public int GetBrowserTrackerId(HttpRequestBase request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return _GetBrowserTrackerId(request.Cookies);
	}

	public string GetIpAddress(HttpRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return _GetIpAddress(request.ServerVariables);
	}

	public int GetBrowserTrackerId(HttpRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return _GetBrowserTrackerId(request.Cookies);
	}

	private int _GetBrowserTrackerId(HttpCookieCollection cookies)
	{
		if (cookies == null)
		{
			throw new ArgumentNullException("cookies");
		}
		HttpCookie cookie = cookies["RBXEventTracker"];
		int browserTrackerId = 0;
		if (cookie != null)
		{
			int.TryParse(cookie["browserid"], out browserTrackerId);
		}
		return browserTrackerId;
	}

	private string _GetIpAddress(NameValueCollection serverVariables)
	{
		if (serverVariables == null)
		{
			throw new ArgumentNullException("serverVariables");
		}
		if (!string.IsNullOrEmpty(serverVariables["HTTP_X_FORWARDED_FOR"]))
		{
			return serverVariables["HTTP_X_FORWARDED_FOR"];
		}
		return serverVariables["REMOTE_ADDR"];
	}
}
