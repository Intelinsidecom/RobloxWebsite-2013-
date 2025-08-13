using System;
using System.Web;

namespace Roblox.Common;

/// <summary>
/// HttpRequest extension methods
/// </summary>
public static class HttpRequestExtensions
{
	internal static readonly HttpRequestProtocolResolver RequestProtocolResolver = new HttpRequestProtocolResolver();

	/// <summary>
	/// Determines if the originating connection was over https based on headers
	/// added to the request (if the request is coming through a load balancer)
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public static bool IsOriginSecureConnection(this HttpRequest request)
	{
		return RequestProtocolResolver.ResolveProtocol(request) == Uri.UriSchemeHttps;
	}

	/// <summary>
	/// Determines if the originating connection was over https based on headers
	/// added to the request (if the request is coming through a load balancer)
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	public static bool IsOriginSecureConnection(this HttpRequestBase request)
	{
		return RequestProtocolResolver.ResolveProtocol(request) == Uri.UriSchemeHttps;
	}
}
