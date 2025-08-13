using System;

namespace Roblox.Platform.Devices.Properties;

public interface ISettings
{
	object this[string propertyName] { get; set; }

	bool DefaultConsolePlayableIsEnabled { get; }

	string DeviceHandlePrivateKey1 { get; }

	string DeviceHandlePrivateKey2 { get; }

	bool DeviceHandleV2EnforceTimestamp { get; }

	string DeviceHandleV2PrivateKey1 { get; }

	string DeviceHandleV2PrivateKey2 { get; }

	TimeSpan DeviceHandleV2TimestampValidTimespan { get; }

	bool LogUnknownPlatformsEnabled { get; }
}
