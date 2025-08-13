namespace Roblox.Platform.IpAddresses;

/// <summary>
/// A factory which could get <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" /> by IpAddress.
/// </summary>
public interface IIpLocationFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" /> by its string value of ipAddress
	/// </summary>
	/// <param name="ipAddress">The string value of ipAddress.</param>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" /> with the given ipAddress, or null if the ipAddress is invalid.</returns>
	IIpLocation GetByIpAddress(string ipAddress);
}
