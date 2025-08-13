namespace Roblox.Platform.IpAddresses;

/// <summary>
/// Determines if an IP is suspicious, eg. has unusual behavior. 
/// </summary>
public interface ISuspiciousIpChecker
{
	/// <summary>
	/// Is the IP suspicious?
	/// </summary>
	/// <param name="ipAddress">The IP address string</param>
	/// <returns>True, if suspicious.</returns>
	bool IsSuspicious(string ipAddress);
}
