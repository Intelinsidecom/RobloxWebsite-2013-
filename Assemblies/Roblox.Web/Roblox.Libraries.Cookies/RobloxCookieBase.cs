using System;
using System.Collections.Specialized;
using System.Web;

namespace Roblox.Libraries.Cookies;

public abstract class RobloxCookieBase
{
	/// <summary>
	/// Domain the cookie is valid for. By default will use the current request domain
	/// </summary>
	private string _Domain = "";

	/// <summary>
	/// Path this cookie is accessible in the web application, allows for scoping cookies to specific sections of an application
	/// Leave blank for default path of `/`
	/// </summary>
	private string _Path = "/";

	/// <summary>
	/// The cookie can only be modified by Set-Cookie header of Http requests to your server and cannot be modified by Javascript code.
	/// </summary>
	private bool _HttpOnly;

	/// <summary>
	/// Name of the cookie
	/// </summary>
	protected abstract string Name { get; }

	/// <summary>
	/// A null ExpirationLength would indicate this is a session cookie.
	/// Also a cookies expiration cannot be read from an existing cookie so changing an existing cookie will have its expiration reset
	/// </summary>
	protected abstract TimeSpan? _ExpirationLength { get; }

	public virtual string Domain
	{
		get
		{
			return _Domain;
		}
		set
		{
			_Domain = value;
		}
	}

	public virtual string Path
	{
		get
		{
			return _Path;
		}
		set
		{
			_Path = value;
		}
	}

	public virtual bool HttpOnly
	{
		get
		{
			return _HttpOnly;
		}
		set
		{
			_HttpOnly = value;
		}
	}

	internal virtual NameValueCollection SerializeValues()
	{
		return DoSerializeValues();
	}

	internal virtual void DeSerializeValues(NameValueCollection keyValues)
	{
		DoDeSerializeValues(keyValues);
	}

	/// <summary>
	/// Deserializes a cookie read from a request object
	/// </summary>
	/// <param name="keyValues">The collection of values from the Cookie in the Request object</param>
	public abstract NameValueCollection DoSerializeValues();

	/// <summary>
	/// A name value collection of all the cookies variables and their string values
	/// </summary>
	/// <returns>All the cookies properties serialized</returns>
	public abstract void DoDeSerializeValues(NameValueCollection keyValues);

	/// <summary>
	/// Saves this cookie to the Response object
	/// </summary>
	public virtual void Save()
	{
		HttpCookie cookie = new HttpCookie(Name);
		if (_ExpirationLength.HasValue)
		{
			cookie.Expires = DateTime.Now.Add(_ExpirationLength.Value);
		}
		cookie.Path = Path;
		cookie.Domain = Domain;
		cookie.HttpOnly = HttpOnly;
		NameValueCollection keyValueCollection = SerializeValues();
		string[] allKeys = keyValueCollection.AllKeys;
		foreach (string key in allKeys)
		{
			cookie[key] = keyValueCollection[key];
		}
		HttpContext.Current.Response.Cookies.Set(cookie);
	}

	/// <summary>
	/// Deletes this cookie by setting the value to null and the expiration date in the past in the Response object
	/// </summary>
	public virtual void Delete()
	{
		HttpCookie cookie = new HttpCookie(Name);
		cookie.Expires = DateTime.Now.AddDays(-1.0);
		cookie.Path = Path;
		cookie.Domain = Domain;
		cookie.HttpOnly = HttpOnly;
		cookie.Value = null;
		HttpContext.Current.Response.Cookies.Set(cookie);
	}
}
