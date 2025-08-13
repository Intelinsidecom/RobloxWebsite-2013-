using Roblox.Platform.Core;

namespace Roblox.Platform.IpAddresses;

public interface IIpAddressEntityFactory : IDomainFactory<IpAddressDomainFactories>, IDomainObject<IpAddressDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.IpAddresses.IIpAddressEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IIpAddressEntity" /> with the given ID, or null if none existed.</returns>
	IIpAddressEntity Get(int id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.IpAddresses.IIpAddressEntity" /> with the given IP address string.
	/// </summary>
	/// <param name="value">The IP address string.</param>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IIpAddressEntity" /> with the given given IP address string.</returns>
	IIpAddressEntity GetOrCreate(string value);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.IpAddresses.IIpAddressEntity" /> with the given IP address string.
	/// </summary>
	/// <param name="value">The IP address string.</param>
	/// <returns>The <see cref="T:Roblox.Platform.IpAddresses.IIpAddressEntity" /> with the given IP address string.</returns>
	IIpAddressEntity GetByValue(string value);
}
