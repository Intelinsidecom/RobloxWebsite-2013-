namespace Roblox.Platform.IpAddresses;

/// <summary>
/// Checks how many accounts have been accessed from an IP address
/// </summary>
internal interface IAccountIpAddressCardinalityDetector
{
	/// <summary>
	/// Checks if more than a given number of accounts have been accessed from an IP address
	/// </summary>
	/// <param name="ipAddress">The IP address</param>
	/// <param name="threshold">Threshold number</param>
	bool IsCardinalityGreaterThanThreshold(string ipAddress, int threshold);
}
