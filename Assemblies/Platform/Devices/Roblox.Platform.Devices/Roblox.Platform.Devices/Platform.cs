using System;

namespace Roblox.Platform.Devices;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.Devices.IPlatform" />.
/// </summary>
public class Platform : IPlatform
{
	[Obsolete]
	public byte PlatformTypeId { get; }

	public PlatformType PlatformType { get; }

	public string PlatformName { get; }

	public DeviceType DeviceType { get; }

	public OperatingSystemType OperatingSystemType { get; }

	public ApplicationType ApplicationType { get; }

	internal Platform(byte platformTypeId, DeviceType deviceType, PlatformType platformType, string platformName, OperatingSystemType operatingSystemType, ApplicationType applicationType)
	{
		PlatformTypeId = platformTypeId;
		DeviceType = deviceType;
		PlatformType = platformType;
		PlatformName = platformName;
		OperatingSystemType = operatingSystemType;
		ApplicationType = applicationType;
	}
}
