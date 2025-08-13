using System;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Roblox;

public class RobloxCookie : IRobloxCookie
{
	private readonly HttpCookie _HttpCookie;

	private static readonly string[] _DeprecatedCookieKeys = new string[3] { "RBXBrowser", "GuestUser", "RBXBrowserTracker" };

	public DateTime Expires
	{
		get
		{
			return _HttpCookie.Expires;
		}
		set
		{
			_HttpCookie.Expires = value;
		}
	}

	public bool HttpOnly
	{
		get
		{
			return _HttpCookie.HttpOnly;
		}
		set
		{
			_HttpCookie.HttpOnly = value;
		}
	}

	public string Name => _HttpCookie.Name;

	public string Value
	{
		get
		{
			return _HttpCookie.Value;
		}
		set
		{
			_HttpCookie.Value = value;
		}
	}

	public string Domain
	{
		get
		{
			return _HttpCookie.Domain;
		}
		set
		{
			_HttpCookie.Domain = value;
		}
	}

	public NameValueCollection Values => _HttpCookie.Values;

	public string Path
	{
		get
		{
			return _HttpCookie.Path;
		}
		set
		{
			_HttpCookie.Path = value;
		}
	}

	private RobloxCookie(HttpCookie cookie)
	{
		_HttpCookie = cookie;
	}

	private static HttpCookie _Get(HttpContext context, string name)
	{
		if (context.Response.Cookies.AllKeys.Contains(name))
		{
			HttpCookie cookie = context.Response.Cookies[name];
			if (cookie.Value == null || cookie.Expires <= DateTime.Now)
			{
				return null;
			}
			return cookie;
		}
		if (context.Request.Cookies.AllKeys.Contains(name))
		{
			return context.Request.Cookies[name];
		}
		return null;
	}

	public static RobloxCookie Get(HttpContext context, string name)
	{
		HttpCookie httpCookie = _Get(context, name);
		if (httpCookie == null)
		{
			return null;
		}
		return new RobloxCookie(httpCookie);
	}

	public static RobloxCookie GetOrCreate(HttpContext context, string name, TimeSpan expirationLength)
	{
		RobloxCookie robloxCookie = Get(context, name);
		if (robloxCookie == null)
		{
			robloxCookie = new RobloxCookie(new HttpCookie(name));
			robloxCookie.Save(expirationLength);
		}
		return robloxCookie;
	}

	/// <summary>
	/// Creates a Session cookie.
	/// </summary>
	/// <param name="context"></param>
	/// <param name="name"></param>
	/// <returns></returns>
	public static RobloxCookie GetOrCreate(HttpContext context, string name)
	{
		RobloxCookie robloxCookie = Get(context, name);
		if (robloxCookie == null)
		{
			robloxCookie = new RobloxCookie(new HttpCookie(name));
			robloxCookie.Save();
		}
		return robloxCookie;
	}

	public void AppendToResponse()
	{
		HttpContext.Current.Response.AppendCookie(_HttpCookie);
	}

	public void Save(TimeSpan expirationLength)
	{
		_HttpCookie.HttpOnly = false;
		_HttpCookie.Expires = DateTime.Now.Add(expirationLength);
		HttpContext.Current.Response.Cookies.Set(_HttpCookie);
	}

	/// <summary>
	/// Session Cookie Save
	/// </summary>
	/// <returns></returns>
	public void Save()
	{
		_HttpCookie.HttpOnly = false;
		_HttpCookie.Expires = DateTime.MinValue;
		HttpContext.Current.Response.Cookies.Set(_HttpCookie);
	}

	public void Delete()
	{
		_HttpCookie.Value = null;
		Save(TimeSpan.FromDays(-1.0));
	}

	[Obsolete("Use Values[] property")]
	public string GetValue(string key)
	{
		if (_HttpCookie.Values.AllKeys.Contains(key))
		{
			return _HttpCookie[key];
		}
		return null;
	}

	[Obsolete("Use Values[] property")]
	public void SetValue(string key, string value)
	{
		_HttpCookie[key] = value;
	}

	[Obsolete("Use Values[] property")]
	public void RemoveValue(string key)
	{
		_HttpCookie.Values.Remove(key);
	}

	[Obsolete("Use Values[] property")]
	public bool HasKey(string key)
	{
		return GetValue(key) != null;
	}

	[Obsolete("Use Domain property")]
	public void SetDomain(string domain)
	{
		_HttpCookie.Domain = domain;
	}

	public static void PurgeDeprecatedCookies(HttpContext context)
	{
		string[] deprecatedCookieKeys = _DeprecatedCookieKeys;
		foreach (string key in deprecatedCookieKeys)
		{
			Get(context, key)?.Delete();
		}
	}
}
