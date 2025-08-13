namespace Roblox.Platform.Devices;

/// <summary>
/// Types of devices.
/// <remarks>
/// DO NOT CHANGE THE ORDER OF THESE VALUES.
/// The byte value of these enum members is written to DynamoDb by the DurableCounter service.
/// </remarks>
/// </summary>
public enum DeviceType
{
	Computer = 1,
	Phone,
	Tablet,
	Console
}
