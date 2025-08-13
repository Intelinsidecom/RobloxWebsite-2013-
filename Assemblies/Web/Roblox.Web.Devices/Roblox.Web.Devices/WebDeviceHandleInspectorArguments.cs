namespace Roblox.Web.Devices;

/// <summary>
/// Container for necessary components to evaluate both DeviceHandle V1 and DeviceHandle V2 for a request.
/// </summary>
public class WebDeviceHandleInspectorArguments
{
	/// <summary>
	/// Unique identifier for the device making a request. Should be included on all requests.
	/// </summary>
	public ulong BrowserTrackerId;

	/// <summary>
	/// User agent used to identify the operating system for metrics tracking.
	/// </summary>
	public string UserAgent;

	/// <summary>
	/// Value of DeviceHandle V1 cookie (null if not provided)
	/// </summary>
	public string DeviceHandleV1Cookie;

	/// <summary>
	/// Value of DeviceHandle V1 header (null if not provided)
	/// </summary>
	public string DeviceHandleV1Header;

	/// <summary>
	/// Value of DeviceHandle V2 cookie (null if not provided)
	/// </summary>
	public string DeviceHandleV2Cookie;

	/// <summary>
	/// Value of DeviceHandle V2 cookie (null if not provided)
	/// </summary>
	public string DeviceHandleV2Header;
}
