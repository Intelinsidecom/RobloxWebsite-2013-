namespace Roblox.Platform.Devices;

/// <summary>
/// For V1 and V2, indicates why an evaluation of DeviceHandle failed.
/// </summary>
public enum DeviceHandleFailureReason
{
	ComparisonFailed,
	ParseFailed,
	Expired
}
