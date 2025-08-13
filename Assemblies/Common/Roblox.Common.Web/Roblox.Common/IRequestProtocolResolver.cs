namespace Roblox.Common;

/// <summary>
/// Interface for resolving whether protocol was http or https for a
/// object representing a request
/// </summary>
/// <typeparam name="TRequestObject"></typeparam>
public interface IRequestProtocolResolver<in TRequestObject>
{
	/// <summary>
	/// Resolves protocol as "http" or "https" from <typeparamref name="TRequestObject&gt;&gt;" />
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	string ResolveProtocol(TRequestObject request);

	/// <summary>
	/// True if the request originated through https
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	bool IsRequestSecure(TRequestObject request);
}
