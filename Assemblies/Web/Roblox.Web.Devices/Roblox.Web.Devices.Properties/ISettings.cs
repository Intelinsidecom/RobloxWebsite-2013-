namespace Roblox.Web.Devices.Properties;

public interface ISettings
{
	object this[string propertyName] { get; set; }

	bool AcceptDeviceHandleV1 { get; }

	bool AcceptDeviceHandleV2 { get; }

	int AndroidDeviceMemoryThreshold { get; }

	double AndroidDeviceScreenPhysicalInchXThreshold { get; }

	double AndroidDeviceScreenPhysicalInchYThreshold { get; }

	string DeviceHandleV1CookieName { get; }

	string DeviceHandleV1HeaderName { get; }

	string DeviceHandleV2CookieName { get; }

	string DeviceHandleV2HeaderName { get; }

	bool IsDeviceHandleFloodCheckEnabled { get; }

	int MinimumMajorIOSVersion { get; }

	string PowershellUserAgentString { get; }

	bool VerifyDeviceHandleV1 { get; }

	bool VerifyDeviceHandleV2 { get; }

	bool RobloxAppViaUserAgentDetectedAsRobloxAppEnabled { get; }
}
