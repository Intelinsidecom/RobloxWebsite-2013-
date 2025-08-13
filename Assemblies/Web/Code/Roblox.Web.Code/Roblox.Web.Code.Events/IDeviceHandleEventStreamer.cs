using Roblox.Web.Devices;

namespace Roblox.Web.Code.Events;

public interface IDeviceHandleEventStreamer
{
	void StreamDeviceHandleEventFromDeviceHandleInspectionResult(DeviceHandleInspectionResult deviceHandleResult);
}
