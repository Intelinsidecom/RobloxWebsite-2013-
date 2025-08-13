using System;

namespace Roblox.Platform.Devices;

/// <summary>
/// A collection of statistics that fully defines and uniquely identifies a platform.
/// </summary>
public interface IPlatform
{
	/// <summary>
	/// The legacy Id that matches <see cref="T:Roblox.Classification.PlatformType" />.
	/// </summary>
	/// <remarks>Please avoid using this where possible.  When writing new code try to consume <see cref="P:Roblox.Platform.Devices.IPlatform.PlatformType" /> instead.</remarks>
	[Obsolete]
	byte PlatformTypeId { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Devices.IPlatform.PlatformType" />.
	/// </summary>
	PlatformType PlatformType { get; }

	/// <summary>
	/// The name of this <see cref="T:Roblox.Platform.Devices.IPlatform" />.
	/// </summary>
	string PlatformName { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Devices.IPlatform.DeviceType" />.
	/// </summary>
	DeviceType DeviceType { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Devices.IPlatform.OperatingSystemType" />.
	/// </summary>
	OperatingSystemType OperatingSystemType { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Devices.IPlatform.ApplicationType" />
	/// </summary>
	ApplicationType ApplicationType { get; }
}
