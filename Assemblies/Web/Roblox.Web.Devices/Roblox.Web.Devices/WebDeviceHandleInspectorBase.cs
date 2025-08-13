using System;
using Roblox.EphemeralCounters;
using Roblox.Platform.Devices;
using Roblox.Web.Devices.Properties;

namespace Roblox.Web.Devices;

/// <summary>
/// Class to be extended to accept and evaluate if DeviceHandle is valid for specific types of requests (e.g. HttpRequestBase vs HttpRequestMessage)
/// </summary>
public abstract class WebDeviceHandleInspectorBase
{
	private readonly ISettings _Settings;

	private readonly IDeviceHandleInspector _DeviceHandleV1Inspector;

	private readonly IDeviceHandleInspectorMetricsTracker _DeviceHandleV1MetricsTracker;

	private readonly IDeviceHandleInspector _DeviceHandleV2Inspector;

	private readonly IDeviceHandleInspectorMetricsTracker _DeviceHandleV2MetricsTracker;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	/// <summary>
	/// Fired when a <see cref="T:Roblox.Web.Devices.IDeviceHandleInspector" /> is used to evaluate DeviceHandle V1 or V2
	/// </summary>
	public event Action<DeviceHandleInspectionResult> OnDeviceHandleInspectionCompleted;

	/// <summary>
	/// Constructs the necessary evaluation and metrics tracking objects.
	/// </summary>
	/// <param name="componentName">This will be used to name ephemeral counters for DeviceHandle evaluation tracking.</param>
	/// <param name="counterFactory">Necessary for metrics tracking.</param>
	/// <param name="identifier">Identifies operating system of requests for metrics tracking.</param>
	protected WebDeviceHandleInspectorBase(string componentName, IEphemeralCounterFactory counterFactory, IClientDeviceIdentifier identifier)
	{
		_Settings = Settings.Default;
		_ClientDeviceIdentifier = identifier;
		DeviceHandleEncryptor deviceHandleV1Encryptor = new DeviceHandleEncryptor();
		_DeviceHandleV1Inspector = new DeviceHandleInspector(deviceHandleV1Encryptor);
		_DeviceHandleV1MetricsTracker = new DeviceHandleInspectorMetricsTracker(componentName, "V1", counterFactory);
		DeviceHandleV2Encryptor deviceHandleV2Encryptor = new DeviceHandleV2Encryptor();
		_DeviceHandleV2Inspector = new DeviceHandleInspector(deviceHandleV2Encryptor);
		_DeviceHandleV2MetricsTracker = new DeviceHandleInspectorMetricsTracker(componentName, "V2", counterFactory);
	}

	/// <summary>
	/// Internal constructor for testing.
	/// </summary>
	/// <param name="componentName"></param>
	/// <param name="settings"></param>
	/// <param name="v1Inspector"></param>
	/// <param name="v1MetricsTracker"></param>
	/// <param name="v2Inspector"></param>
	/// <param name="v2MetricsTracker"></param>
	/// <param name="clientDeviceIdentifier"></param>
	protected internal WebDeviceHandleInspectorBase(string componentName, ISettings settings, IDeviceHandleInspector v1Inspector, IDeviceHandleInspectorMetricsTracker v1MetricsTracker, IDeviceHandleInspector v2Inspector, IDeviceHandleInspectorMetricsTracker v2MetricsTracker, IClientDeviceIdentifier clientDeviceIdentifier)
	{
		_Settings = settings;
		_DeviceHandleV1Inspector = v1Inspector;
		_DeviceHandleV1MetricsTracker = v1MetricsTracker;
		_DeviceHandleV2Inspector = v2Inspector;
		_DeviceHandleV2MetricsTracker = v2MetricsTracker;
		_ClientDeviceIdentifier = clientDeviceIdentifier;
	}

	/// <summary>
	/// Returns the <see cref="T:Roblox.Web.Devices.DeviceHandleInspectionResult" /> of the DeviceHandle method used to evaluate the request.
	/// </summary>
	/// <param name="args"><see cref="T:Roblox.Web.Devices.WebDeviceHandleInspectorArguments" /></param>
	/// <returns>Returns the <see cref="T:Roblox.Web.Devices.DeviceHandleInspectionResult" /> of the DeviceHandle method used to evaluate the request. Null if neither is evaluated.</returns>
	public DeviceHandleInspectionResult EvaluateDeviceHandle(WebDeviceHandleInspectorArguments args)
	{
		OperatingSystemType operatingSystem = _ClientDeviceIdentifier.DetectOperatingSystemType(args.UserAgent);
		DeviceHandleInspectionResult inspectionResult = new DeviceHandleInspectionResult
		{
			SuppliedInCookie = false,
			SuppliedInHeader = false,
			EvaluationResult = null,
			OperatingSystemType = operatingSystem
		};
		if (_Settings.AcceptDeviceHandleV2 || _Settings.VerifyDeviceHandleV2)
		{
			DeviceHandleInspectionResult deviceHandleV2InspectionResult = _DeviceHandleV2Inspector.ResolveDeviceHandleValidFromHeaderOrCookie(args.DeviceHandleV2Header, args.DeviceHandleV2Cookie, args.BrowserTrackerId, operatingSystem);
			_DeviceHandleV2MetricsTracker.IncrementCountersFromDeviceHandleInspectionResult(deviceHandleV2InspectionResult);
			this.OnDeviceHandleInspectionCompleted?.Invoke(deviceHandleV2InspectionResult);
			if (_Settings.AcceptDeviceHandleV2 && deviceHandleV2InspectionResult != null)
			{
				inspectionResult = deviceHandleV2InspectionResult;
				DeviceHandleEvaluationResult evaluationResult = deviceHandleV2InspectionResult.EvaluationResult;
				if (evaluationResult != null && evaluationResult.IsValid)
				{
					return inspectionResult;
				}
			}
		}
		if (_Settings.AcceptDeviceHandleV1 || _Settings.VerifyDeviceHandleV1)
		{
			DeviceHandleInspectionResult deviceHandleV1InspectionResult = _DeviceHandleV1Inspector.ResolveDeviceHandleValidFromHeaderOrCookie(args.DeviceHandleV1Header, args.DeviceHandleV1Cookie, args.BrowserTrackerId, operatingSystem);
			_DeviceHandleV1MetricsTracker.IncrementCountersFromDeviceHandleInspectionResult(deviceHandleV1InspectionResult);
			this.OnDeviceHandleInspectionCompleted?.Invoke(deviceHandleV1InspectionResult);
			if (_Settings.AcceptDeviceHandleV1 && deviceHandleV1InspectionResult != null)
			{
				return deviceHandleV1InspectionResult;
			}
		}
		return inspectionResult;
	}
}
