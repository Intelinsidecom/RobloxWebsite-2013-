using System.Net;

namespace Roblox.Common;

/// <summary>
/// interface for resolving Ips
/// </summary>
/// <typeparam name="TResolveFrom"></typeparam>
public interface IIpResolver<in TResolveFrom>
{
	/// <summary>
	/// Resolve Ip Address from <typeparamref name="TResolveFrom" />
	/// </summary>
	/// <param name="data">data to resolve from</param>
	/// <returns>An ip address</returns>
	IPAddress Resolve(TResolveFrom data);
}
