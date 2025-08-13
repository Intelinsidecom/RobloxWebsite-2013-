using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using Roblox.Common.Properties;

namespace Roblox.Common;

/// <inheritdoc cref="T:Roblox.Common.IIpResolver`1" />
public class HttpContextIpResolver : IIpResolver<HttpContext>, IIpResolver<HttpContextBase>, IHeaderIpResolver
{
	private readonly IIpResolver<HttpHeaderIpResolverModel> _HttpHeaderResolver;

	private readonly IIpResolver<HttpHeaderSecureIpResolverModel> _HttpSecureResolver;

	/// <inheritdoc />
	public HttpContextIpResolver(IIpResolver<HttpHeaderIpResolverModel> headerResolver, IIpResolver<HttpHeaderSecureIpResolverModel> secureResolver)
	{
		_HttpHeaderResolver = headerResolver ?? throw new ArgumentNullException("headerResolver");
		_HttpSecureResolver = secureResolver ?? throw new ArgumentNullException("secureResolver");
	}

	/// <inheritdoc />
	public IPAddress Resolve(HttpContext context)
	{
		return Resolve(new HttpContextWrapper(context));
	}

	/// <inheritdoc />
	public IPAddress Resolve(HttpContextBase context)
	{
		NameValueCollection headers = context.Request.Headers;
		Dictionary<string, string> headersDict = headers.AllKeys.ToDictionary((string k) => k, (string k) => headers[k], StringComparer.OrdinalIgnoreCase);
		return Resolve(context.Request.UserHostAddress, headersDict);
	}

	public IPAddress Resolve(string remoteIpAddress, IDictionary<string, string> headers)
	{
		IPAddress ipAddress = null;
		if (Settings.Default.EnableSecureIpHeadersForOriginIp)
		{
			ipAddress = _HttpSecureResolver.Resolve(new HttpHeaderSecureIpResolverModel
			{
				TrueIp = TryGetHeader(headers, "Roblox-CNP-True-IP", null),
				ProxyUrl = TryGetHeader(headers, "Roblox-CNP-Url", null),
				Nonce = TryGetHeader(headers, "Roblox-CNP-Date", null),
				SecureHash1 = TryGetHeader(headers, "Roblox-CNP-Secure", null),
				SecureHash2 = TryGetHeader(headers, "Roblox-CNP-Secure2", null),
				EnableHashCheck = Settings.Default.EnableSecureIpHeadersHashCheck,
				Key1 = Settings.Default.SecureIpCnProxySecretKey,
				Key2 = Settings.Default.SecureIpCnProxySecretKey2
			});
		}
		if (ipAddress == null)
		{
			ipAddress = _HttpHeaderResolver.Resolve(new HttpHeaderIpResolverModel
			{
				UserHostAddress = remoteIpAddress,
				ForwardedFor = (headers.ContainsKey("X-Forwarded-For") ? headers["X-Forwarded-For"] : null),
				DosArrestRealIpHeaderName = (headers.ContainsKey("X-Real-IP") ? headers["X-Real-IP"] : null),
				RobloxProxiedFor = (headers.ContainsKey("Roblox-Proxied-IP") ? headers["Roblox-Proxied-IP"] : null)
			});
		}
		return ipAddress;
	}

	private string TryGetHeader(IDictionary<string, string> headers, string key, string defaultValue)
	{
		headers.TryGetValue(key, out defaultValue);
		return defaultValue;
	}
}
