using System.Net;

namespace Roblox.Platform.Throttling.Implementation;

/// <summary>
/// Determines if an IP address is flagged as suspicious.
/// </summary>
public interface IFlaggedIpAddressAuthority
{
	/// <summary>
	/// Returns true if the <see cref="T:System.Net.IPAddress">IP Address</see> is flagged as suspicious
	/// according to the data source backing this class.
	/// </summary>
	/// <param name="ipAddress"></param>
	/// <returns></returns>
	bool IsIpAddressFlagged(IPAddress ipAddress);

	/// <summary>
	/// Attempts to parse input IP address string and returns false if it is not formatted correctly.
	/// </summary>
	/// <param name="ipAddressString"></param>
	/// <returns></returns>
	bool IsIpAddressStringFlagged(string ipAddressString);
}
