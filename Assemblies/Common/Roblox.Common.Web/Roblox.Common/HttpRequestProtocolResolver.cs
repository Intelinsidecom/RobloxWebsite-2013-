using System;
using System.Web;

namespace Roblox.Common;

/// <summary>
/// Contains methods to resolve origin protocol of HttpRequest and HttpRequestBase objects
/// </summary>
public class HttpRequestProtocolResolver : IHttpRequestProtocolResolver, IRequestProtocolResolver<HttpRequest>, IRequestProtocolResolver<HttpRequestBase>
{
	private readonly IHttpHeaderProtocolResolver _HeaderResolver;

	/// <summary>
	///
	/// </summary>
	public HttpRequestProtocolResolver(IHttpHeaderProtocolResolver resolver = null)
	{
		_HeaderResolver = resolver ?? new HttpHeaderProtocolResolver();
	}

	/// <summary>
	/// Resolves the protocol, "http" or "https", for a HttpRequest object
	/// based on request headers if they are present
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public string ResolveProtocol(HttpRequest request)
	{
		return ResolveProtocol(new HttpRequestWrapper(request));
	}

	/// <summary>
	/// True if the request originated over https according to request headers
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public bool IsRequestSecure(HttpRequest request)
	{
		return ResolveProtocol(request) == Uri.UriSchemeHttps;
	}

	/// <summary>
	/// Resolves the protocol, "http" or "https", for a HttpRequestBase object
	/// based on request headers if they are present
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public string ResolveProtocol(HttpRequestBase request)
	{
		string requestProtocol = (request.IsSecureConnection ? Uri.UriSchemeHttps : Uri.UriSchemeHttp);
		return _HeaderResolver.ResolveProtocolFromRequestProperties(request.UserHostAddress, requestProtocol, request.Headers["X-Forwarded-Proto"]);
	}

	/// <summary>
	/// True if the request originated over https according to request headers
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public bool IsRequestSecure(HttpRequestBase request)
	{
		return ResolveProtocol(request) == Uri.UriSchemeHttps;
	}
}
