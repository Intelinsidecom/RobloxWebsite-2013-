using System;
using Roblox.Common.Properties;
using Roblox.Platform.Infrastructure;

namespace Roblox.Common;

/// <summary>
/// Contains logic for determining origin request protocol using values
/// from the request object
/// </summary>
public class HttpHeaderProtocolResolver : IHttpHeaderProtocolResolver
{
	private readonly ISettings _Settings;

	private readonly IServerValidator _ServerValidator;

	/// <summary>
	/// Resolves origin protocol based on request properties
	/// </summary>
	public HttpHeaderProtocolResolver()
		: this(Settings.Default, ServerValidator.RobloxServerValidator)
	{
	}

	internal HttpHeaderProtocolResolver(ISettings settings, IServerValidator serverValidator)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ServerValidator = serverValidator ?? throw new ArgumentNullException("serverValidator");
	}

	internal string TrimAndValidateXForwardedProtoHeader(string header)
	{
		if (header != null)
		{
			header = header.Trim().ToLower();
			if (header == Uri.UriSchemeHttp || header == Uri.UriSchemeHttps)
			{
				return header;
			}
		}
		return null;
	}

	/// <summary>
	/// Determines whether the provided IP address is an allowed proxy IP and returns the protocol
	/// of the request from the X-Forwarded-Proto header value
	/// </summary>
	/// <param name="userHostAddress">The IP address reported by the request</param>
	/// <param name="requestProtocol">The protocol "http" or "https" reported by the request</param>
	/// <param name="xForwardedProtoValue">The value of the X-Forwarded-Proto header</param>
	/// <returns></returns>
	public string ResolveProtocolFromRequestProperties(string userHostAddress, string requestProtocol, string xForwardedProtoValue)
	{
		xForwardedProtoValue = TrimAndValidateXForwardedProtoHeader(xForwardedProtoValue);
		if (_Settings.EnableXForwardedProtoOriginProtocol && _ServerValidator.IsAllowedProxyIp(userHostAddress) && xForwardedProtoValue != null)
		{
			return xForwardedProtoValue;
		}
		return requestProtocol;
	}

	/// <summary>
	/// Returns true if request originated over https according to request properties
	/// </summary>
	/// <param name="userHostAddress">IP address according to request</param>
	/// <param name="requestProtocol">Protocol according to request</param>
	/// <param name="xForwardedProtoValue">Protocol according to X-Forwarded-Proto header</param>
	/// <returns></returns>
	public bool GetIsRequestSecureFromRequestProperties(string userHostAddress, string requestProtocol, string xForwardedProtoValue)
	{
		return ResolveProtocolFromRequestProperties(userHostAddress, requestProtocol, xForwardedProtoValue) == Uri.UriSchemeHttps;
	}
}
