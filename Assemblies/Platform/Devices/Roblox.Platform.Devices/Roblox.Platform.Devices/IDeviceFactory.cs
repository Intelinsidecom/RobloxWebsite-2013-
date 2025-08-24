using System;
using System.Collections.Generic;
using Roblox.Classification;

namespace Roblox.Platform.Devices;

/// <summary>
/// A factory for <see cref="T:Roblox.Platform.Devices.DeviceType" />s and <see cref="T:Roblox.Platform.Devices.OperatingSystemType" />s.
/// </summary>
public interface IDeviceFactory
{
	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Devices.DeviceType" />s.
	/// </summary>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing all possible <see cref="T:Roblox.Platform.Devices.DeviceType" />s.</returns>
	ICollection<DeviceType> GetAllDeviceTypes();

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Devices.OperatingSystemType" />s.
	/// </summary>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing all possible <see cref="T:Roblox.Platform.Devices.OperatingSystemType" />s.</returns>
	ICollection<OperatingSystemType> GetAllOperatingSystemTypes();

	/// <summary>
	/// Derives the type of the operating system.
	/// <see cref="F:Roblox.Platform.Devices.OperatingSystemType.Unknown" /> will be returned if no type can be determined.
	/// </summary>
	/// <param name="osType">OS type string</param>
	/// <returns><see cref="T:Roblox.Platform.Devices.OperatingSystemType" /> instance.</returns>
	OperatingSystemType GetOperatingSystemType(string osType);

	/// <summary>
	/// Gets the supported device types for sponsored page.
	/// </summary>
	/// <param name="sponsoredPageSupportedDevicesBitVector">The sponsored page supported devices bit vector.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing <see cref="T:Roblox.Platform.Devices.OperatingSystemType" />s that are supported for sporsored page.</returns>
	ICollection<DeviceType> GetSupportedDeviceTypesForSponsoredPage(long sponsoredPageSupportedDevicesBitVector);

	/// <summary>
	/// Gets the sponsored page supported devices bit vector.
	/// </summary>
	/// <param name="sponsoredPageSupportedDevicesBitVector">The sponsored page supported devices bit vector.</param>
	/// <param name="deviceTypes">The device types.</param>
	/// <returns>A bit vector representing all <see cref="T:Roblox.Platform.Devices.DeviceType" />s that are supported for sponsored page.</returns>
	long GetSponsoredPageSupportedDevicesBitVector(long sponsoredPageSupportedDevicesBitVector, ICollection<DeviceType> deviceTypes);

	/// <summary>
	/// Gets the friendly name for an <see cref="T:Roblox.Platform.Devices.IOSDeviceType" /> given it's version.
	/// </summary>
	/// <param name="deviceType">An <see cref="T:Roblox.Platform.Devices.IOSDeviceType" />.</param>
	/// <param name="deviceVersion">A <see cref="T:System.Version" />.</param>
	/// <returns>A string representing the friendly device name.</returns>
	string GetFriendlyIOSDeviceName(IOSDeviceType deviceType, Version deviceVersion);

	/// <summary>
	/// Adds or removes a device type from the supported devices bit vector.
	/// </summary>
	/// <param name="supportedDevicesBitVector"></param>
	/// <param name="deviceTypeEntity"></param>
	/// <param name="isSupported">True = the specified device type is added to the bit vector. False = the specified device type is removed from the bit vector.</param>
	/// <returns></returns>
	long AddOrRemoveDeviceTypeBit(long supportedDevicesBitVector, Roblox.Classification.DeviceType deviceTypeEntity, bool isSupported);
}
