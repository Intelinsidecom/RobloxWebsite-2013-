namespace Roblox.Web.Devices;

/// <summary>
/// Instantiated by the <see cref="T:Roblox.Web.Devices.WebDeviceHandleInspectorBase" /> to increment ephemeral counters based on the results of
/// device handle evaluations for web requests for a deployable component (e.g. ApiProxy, the website, or the Auth Api).
/// of DeviceHandle
/// </summary>
public interface IDeviceHandleInspectorMetricsTracker
{
	/// <summary>
	/// Increments the appropriate counters from a DeviceHandleInspectionResult returned by a <see cref="T:Roblox.Web.Devices.DeviceHandleInspector" />.
	/// </summary>
	/// <param name="result">DeviceHandleInspectionResult returned from a <see cref="T:Roblox.Web.Devices.DeviceHandleInspector" /></param>
	void IncrementCountersFromDeviceHandleInspectionResult(DeviceHandleInspectionResult result);
}
