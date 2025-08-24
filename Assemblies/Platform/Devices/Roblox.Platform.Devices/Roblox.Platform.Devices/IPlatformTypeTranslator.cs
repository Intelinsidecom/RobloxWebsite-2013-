using Roblox.Classification;

namespace Roblox.Platform.Devices;

/// <summary>
/// Translates between <see cref="T:Roblox.Classification.PlatformType" />s and <see cref="T:Roblox.Platform.Devices.PlatformType" />s.
/// </summary>
internal interface IPlatformTypeTranslator
{
	/// <summary>
	/// Translates an instance of <see cref="T:Roblox.Platform.Devices.PlatformType" /> into a byte corresponding to the ID of a <see cref="T:Roblox.Classification.PlatformType" />.
	/// </summary>
	/// <param name="platformType">An instance of <see cref="T:Roblox.Platform.Devices.PlatformType" /></param>
	/// <returns>The corresponding byte.</returns>
	byte ToByte(PlatformType platformType);

	/// <summary>
	/// Translates an instance of <see cref="T:Roblox.Classification.PlatformType" /> into an instance of <see cref="T:Roblox.Platform.Devices.PlatformType" />.
	/// </summary>
	/// <param name="platformType">An instance of <see cref="T:Roblox.Classification.PlatformType" />.</param>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Devices.PlatformType" />.</returns>
	PlatformType ToEnum(Roblox.Classification.PlatformType platformType);

	/// <summary>
	/// Translates an application type ID into an <see cref="T:Roblox.Platform.Devices.ApplicationType" /> value.
	/// </summary>
	/// <param name="applicationTypeId">The application type ID found in <see cref="T:Roblox.Classification.PlatformType" />.</param>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Devices.ApplicationType" />.</returns>
	ApplicationType ApplicationTypeFromId(byte applicationTypeId);
}
