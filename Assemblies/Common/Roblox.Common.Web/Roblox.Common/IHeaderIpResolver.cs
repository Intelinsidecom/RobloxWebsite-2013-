using System.Collections.Generic;
using System.Net;

namespace Roblox.Common;

/// <summary>
/// interface for resolving Ips based on info from Roblox http headers.
/// </summary>
public interface IHeaderIpResolver
{
	/// <summary>
	/// Resolve Ip Address based on client's remote Ip address and header values.
	///
	/// This is necessary because we have data-centers that proxy in to our main
	/// data0center and the headers help define the source.
	/// </summary>
	/// <returns>An ip address</returns>
	IPAddress Resolve(string remoteIpAddress, IDictionary<string, string> headers);
}
