using System;
using Roblox.EphemeralCounters;
using Roblox.Platform.Devices;

namespace Roblox.Web.Devices;

/// <summary>
/// Instantiated by the <see cref="T:Roblox.Web.Devices.WebDeviceHandleInspectorBase" /> to increment ephemeral counters based on the results of
/// device handle evaluations for web requests for a deployable component (e.g. ApiProxy, the website, or the Auth Api).
/// of DeviceHandle
/// </summary>
public class DeviceHandleInspectorMetricsTracker : IDeviceHandleInspectorMetricsTracker
{
	private const string _DeviceHandleRequestedEventName = "DeviceHandle_Requested";

	private const string _DeviceHandleInCookieEventName = "DeviceHandle_SuppliedInCookie";

	private const string _DeviceHandleInHeaderEventName = "DeviceHandle_SuppliedInHeader";

	private const string _DeviceHandleInvalidEventName = "DeviceHandle_Invalid";

	private const string _DeviceHandleNotSuppliedEventName = "DeviceHandle_NotSupplied";

	private const string _DeviceHandleFailedEventName = "DeviceHandle_Failed";

	private const string _DeviceHandleValidEventName = "DeviceHandle_Valid";

	private readonly string _ComponentName;

	private readonly string _VersionSuffix;

	private readonly IEphemeralCounterFactory _CounterFactory;

	/// <summary>
	/// Used to increment counters based on DeviceHandleEvaluation.
	/// </summary>
	/// <param name="componentName">The deployable component that is evaluating DeviceHandle (e.g. "Roblox.ApiProxy")</param>
	/// <param name="deviceHandleVersionSuffix">Suffix used to indicate what version of device handle this metrics tracker will be used for, e.g. "V1" or "V2"</param>
	/// <param name="ephemeralCounterFactory"></param>
	public DeviceHandleInspectorMetricsTracker(string componentName, string deviceHandleVersionSuffix, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		_ComponentName = componentName ?? throw new ArgumentNullException("componentName");
		_VersionSuffix = deviceHandleVersionSuffix ?? throw new ArgumentNullException("deviceHandleVersionSuffix");
		_CounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
	}

	internal virtual void IncrementRequestedCounter(OperatingSystemType operatingSystem)
	{
		IncrementCounter("DeviceHandle_Requested", operatingSystem);
	}

	internal virtual void IncrementInCookieCounter(OperatingSystemType operatingSystem)
	{
		IncrementCounter("DeviceHandle_SuppliedInCookie", operatingSystem);
	}

	internal virtual void IncrementInHeaderCounter(OperatingSystemType operatingSystem)
	{
		IncrementCounter("DeviceHandle_SuppliedInHeader", operatingSystem);
	}

	internal virtual void IncrementInvalidCounter(OperatingSystemType operatingSystem, DeviceHandleFailureReason? failureReason)
	{
		IncrementCounter("DeviceHandle_Invalid", operatingSystem);
		if (failureReason.HasValue)
		{
			IncrementCounter(string.Format("{0}_{1}", "DeviceHandle_Invalid", failureReason), operatingSystem);
		}
	}

	internal virtual void IncrementNotSuppliedCounter(OperatingSystemType operatingSystem)
	{
		IncrementCounter("DeviceHandle_NotSupplied", operatingSystem);
	}

	internal virtual void IncrementFailedCounter(OperatingSystemType operatingSystem)
	{
		IncrementCounter("DeviceHandle_Failed", operatingSystem);
	}

	internal virtual void IncrementValidCounter(OperatingSystemType operatingSystem, DeviceHandleEvaluationType? evaluationType)
	{
		IncrementCounter("DeviceHandle_Valid", operatingSystem);
		if (evaluationType.HasValue)
		{
			IncrementCounter(string.Format("{0}_{1}", "DeviceHandle_Valid", evaluationType), operatingSystem);
		}
	}

	/// <summary>
	/// Increments the appropriate counters from a DeviceHandleInspectionResult returned by a <see cref="T:Roblox.Web.Devices.DeviceHandleInspector" />.
	/// </summary>
	/// <param name="result">DeviceHandleInspectionResult returned from a <see cref="T:Roblox.Web.Devices.DeviceHandleInspector" /></param>
	public void IncrementCountersFromDeviceHandleInspectionResult(DeviceHandleInspectionResult result)
	{
		IncrementRequestedCounter(result.OperatingSystemType);
		if (result.SuppliedInCookie)
		{
			IncrementInCookieCounter(result.OperatingSystemType);
		}
		if (result.SuppliedInHeader)
		{
			IncrementInHeaderCounter(result.OperatingSystemType);
		}
		if (!result.SuppliedInCookie && !result.SuppliedInHeader)
		{
			IncrementNotSuppliedCounter(result.OperatingSystemType);
			IncrementFailedCounter(result.OperatingSystemType);
		}
		else if (result.EvaluationResult != null)
		{
			if (result.EvaluationResult.IsValid)
			{
				IncrementValidCounter(result.OperatingSystemType, result.EvaluationResult.EvaluationType);
				return;
			}
			IncrementInvalidCounter(result.OperatingSystemType, result.EvaluationResult.FailureReason);
			IncrementFailedCounter(result.OperatingSystemType);
		}
	}

	internal virtual void IncrementCounter(string eventName, OperatingSystemType operatingSystem)
	{
		string counterName = $"{eventName}_{_VersionSuffix}_{_ComponentName}_{operatingSystem}";
		_CounterFactory.GetCounter(counterName).IncrementInBackground();
	}
}
