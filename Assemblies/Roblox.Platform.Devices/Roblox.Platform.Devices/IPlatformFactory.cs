using System.Collections.Generic;

namespace Roblox.Platform.Devices;

/// <summary>
/// A factory for producing <see cref="T:Roblox.Platform.Devices.IPlatform" />s.
/// </summary>
public interface IPlatformFactory
{
	/// <summary>
	/// Gets all platforms.
	/// </summary>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> containing all platforms.</returns>
	IEnumerable<IPlatform> GetAllPlatforms();

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Devices.IPlatform" /> instance based on its ID.
	/// </summary>
	/// <param name="platformTypeId">The <see cref="T:Roblox.Platform.Devices.IPlatform" />'s type ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Devices.IPlatform" /> instance.</returns>
	IPlatform GetById(byte platformTypeId);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Devices.IPlatform" /> instance based on the <see cref="T:Roblox.Platform.Devices.PlatformType" />.
	/// </summary>
	/// <param name="platformType">The <see cref="T:Roblox.Platform.Devices.PlatformType" />.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Devices.IPlatform" /> instance.</returns>
	IPlatform GetByType(PlatformType platformType);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Devices.IPlatform" /> instance based by its name.
	/// </summary>
	/// <param name="value">The name.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Devices.IPlatform" /> instance.</returns>
	IPlatform GetByValue(string value);
}
