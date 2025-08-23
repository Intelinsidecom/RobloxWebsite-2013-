using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;

namespace Roblox.Web;

public static class RequestContextDictionaryProvider
{
	private const string _RequestCacheDictionaryKey = "RequestCacheDictionary";

	public static Func<IDictionary> GetRequestContextDictionary()
	{
		return delegate
		{
			if (HttpContext.Current == null)
			{
				return null;
			}
			if (!HttpContext.Current.Items.Contains("RequestCacheDictionary"))
			{
				HttpContext.Current.Items["RequestCacheDictionary"] = new Dictionary<string, object>();
			}
			return (IDictionary)HttpContext.Current.Items["RequestCacheDictionary"];
		};
	}
}
