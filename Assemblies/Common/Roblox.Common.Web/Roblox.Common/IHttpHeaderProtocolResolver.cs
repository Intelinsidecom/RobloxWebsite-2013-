namespace Roblox.Common;

/// <summary>
/// Interface for determining protocol from raw request data
/// </summary>
public interface IHttpHeaderProtocolResolver
{
	/// <summary>
	/// Resolves protocol from provided parameters
	/// </summary>
	/// <param name="userHostAddress">The IP address according to a request</param>
	/// <param name="requestProtocol">The protocol (http or https) according to a request</param>
	/// <param name="xForwardedProtoValue">The protocol according to the X-Forwarded-Proto header of a request</param>
	/// <returns></returns>
	string ResolveProtocolFromRequestProperties(string userHostAddress, string requestProtocol, string xForwardedProtoValue);

	/// <summary>
	/// Returns true if request originated over https according to request properties
	/// </summary>
	/// <param name="userHostAddress"></param>
	/// <param name="requestProtocol"></param>
	/// <param name="xForwardedProtoValue"></param>
	/// <returns></returns>
	bool GetIsRequestSecureFromRequestProperties(string userHostAddress, string requestProtocol, string xForwardedProtoValue);
}
