using System.Web;
using Roblox.Platform.Devices;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Random;
using Roblox.Web.Code.EventStream.WebEvents;
using Roblox.Web.Code.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Code.Events;

public class DeviceHandleEventStreamer : IDeviceHandleEventStreamer
{
	private readonly IWebEventArgsFactory _WebEventArgsFactory;

	private readonly IEventStreamer _EventStreamer;

	private readonly IRandomFactory _RandomFactory;

	public DeviceHandleEventStreamer(IWebEventArgsFactory argsFactory, IEventStreamer eventStreamer, IRandomFactory randomFactory)
	{
		_WebEventArgsFactory = argsFactory;
		_EventStreamer = eventStreamer;
		_RandomFactory = randomFactory;
	}

	internal virtual DeviceHandleRequestedEventArgs CreateEventArgsAndPopulateDefaultParameters()
	{
		return _WebEventArgsFactory.Create<DeviceHandleRequestedEventArgs>(HttpContext.Current);
	}

	public void StreamDeviceHandleEventFromDeviceHandleInspectionResult(DeviceHandleInspectionResult deviceHandleResult)
	{
		DeviceHandleRequestedEventArgs eventArgs = CreateEventArgsAndPopulateDefaultParameters();
		eventArgs.PageUrl = HttpContext.Current.Request.Url.ToString();
		eventArgs.SuppliedInCookie = deviceHandleResult.SuppliedInCookie;
		eventArgs.SuppliedInHeader = deviceHandleResult.SuppliedInHeader;
		eventArgs.NotSupplied = !deviceHandleResult.SuppliedInCookie && !deviceHandleResult.SuppliedInHeader;
		eventArgs.Valid = deviceHandleResult.EvaluationResult?.IsValid ?? false;
		DeviceHandleEvaluationResult evaluationResult = deviceHandleResult.EvaluationResult;
		eventArgs.Failed = evaluationResult == null || !evaluationResult.IsValid;
		DeviceHandleEvaluationResult evaluationResult2 = deviceHandleResult.EvaluationResult;
		eventArgs.Invalid = (evaluationResult2 == null || !evaluationResult2.IsValid) && (deviceHandleResult.SuppliedInCookie || deviceHandleResult.SuppliedInHeader);
		if (eventArgs.BrowserTrackerId.HasValue && _RandomFactory.GetDefaultRandom().Next(0, 100) < Settings.Default.DeviceHandleEventStreamLogPercent)
		{
			new DeviceHandleRequestedEvent(_EventStreamer, eventArgs).Stream();
		}
	}
}
