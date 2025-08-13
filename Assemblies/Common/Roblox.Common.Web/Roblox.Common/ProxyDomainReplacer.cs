using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Common.Properties;
using Roblox.Configuration;

namespace Roblox.Common;

public class ProxyDomainReplacer
{
	private static IEnumerable<string> WhitelistedProxyDomains;

	private static bool EnableProxyUrlDetection => Settings.Default.EnableProxyUrlDetection;

	static ProxyDomainReplacer()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.ProxyUrlDomainsCsv, delegate(string newCsv)
		{
			WhitelistedProxyDomains = (from d in MultiValueSettingParser.ParseCommaDelimitedListString(newCsv)
				select d.ToLower()).ToArray();
		});
	}

	public static string ReplaceDomain(HttpRequest request, string s)
	{
		return ReplaceDomain(request.Headers["Roblox-CNP-Url"], s);
	}

	public static string ReplaceDomain(string robloxCnProxyUrl, string s)
	{
		if (EnableProxyUrlDetection && IsProxiedChinaRequest(robloxCnProxyUrl, out var proxyHost))
		{
			char[] dotSeparators = new char[1] { '.' };
			string[] proxyHostComponents = proxyHost.Split(dotSeparators);
			string topProxyDomain = "." + string.Join(".", proxyHostComponents.Where((string source, int index) => index != 0));
			string tld = RobloxEnvironment.Domain;
			if (!tld.StartsWith("."))
			{
				tld = "." + tld;
			}
			s = s.Replace(tld, topProxyDomain);
		}
		return s;
	}

	public static bool IsProxiedChinaRequest(HttpRequest request, out string proxyHost)
	{
		return IsProxiedChinaRequest(request.Headers["Roblox-CNP-Url"], out proxyHost);
	}

	public static bool IsProxiedChinaRequest(string robloxCnProxyUrl, out string proxyHost)
	{
		proxyHost = null;
		if (Uri.TryCreate(robloxCnProxyUrl, UriKind.Absolute, out var proxyUrl))
		{
			proxyHost = proxyUrl.Host;
			return WhitelistedProxyDomains.Any((string whitelistedProxyDomain) => proxyUrl.Host.EndsWith(whitelistedProxyDomain));
		}
		return false;
	}
}
