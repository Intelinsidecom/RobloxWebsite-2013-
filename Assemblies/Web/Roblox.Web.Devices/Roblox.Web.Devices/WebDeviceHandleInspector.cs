using System.Web;
using Roblox.EphemeralCounters;
using Roblox.Web.Devices.Properties;

namespace Roblox.Web.Devices;

public sealed class WebDeviceHandleInspector : WebDeviceHandleInspectorBase, IWebDeviceHandleInspector
{
	/// <inheritdoc cref="T:Roblox.Web.Devices.WebDeviceHandleInspectorBase" />
	public WebDeviceHandleInspector(string componentName, IEphemeralCounterFactory counterFactory, IClientDeviceIdentifier identifier)
		: base(componentName, counterFactory, identifier)
	{
	}

	public DeviceHandleInspectionResult InspectDeviceHandleRequest(HttpRequestBase request, ulong browserTrackerId)
	{
		WebDeviceHandleInspectorArguments inspectorArgs = new WebDeviceHandleInspectorArguments();
		inspectorArgs.DeviceHandleV1Cookie = request.Cookies[Settings.Default.DeviceHandleV1CookieName]?.Value;
		inspectorArgs.DeviceHandleV1Header = request.Headers[Settings.Default.DeviceHandleV1HeaderName];
		inspectorArgs.DeviceHandleV2Cookie = request.Cookies[Settings.Default.DeviceHandleV2CookieName]?.Value;
		inspectorArgs.DeviceHandleV2Header = request.Headers[Settings.Default.DeviceHandleV2HeaderName];
		inspectorArgs.BrowserTrackerId = browserTrackerId;
		inspectorArgs.UserAgent = request.UserAgent;
		return EvaluateDeviceHandle(inspectorArgs);
	}

	public DeviceHandleInspectionResult InspectDeviceHandleRequest(HttpRequest request, ulong browserTrackerId)
	{
		return InspectDeviceHandleRequest(new HttpRequestWrapper(request), browserTrackerId);
	}

	public bool IsValidDeviceHandleRequest(HttpRequestBase request, ulong browserTrackerId)
	{
		DeviceHandleInspectionResult deviceHandleInspectionResult = InspectDeviceHandleRequest(request, browserTrackerId);
		if (deviceHandleInspectionResult == null)
		{
			return false;
		}
		return deviceHandleInspectionResult.EvaluationResult?.IsValid == true;
	}

	public bool IsValidDeviceHandleRequest(HttpRequest request, ulong browserTrackerId)
	{
		return IsValidDeviceHandleRequest(new HttpRequestWrapper(request), browserTrackerId);
	}

	public bool IsValidDeviceHandleRequest(HttpRequestBase request, long browserTrackerId)
	{
		return IsValidDeviceHandleRequest(request, (ulong)browserTrackerId);
	}

	public bool IsValidDeviceHandleRequest(HttpRequest request, long browserTrackerId)
	{
		return IsValidDeviceHandleRequest(request, (ulong)browserTrackerId);
	}
}
