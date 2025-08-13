using System;
using System.Threading.Tasks;
using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Platform.Notifications.Push;

internal class EphemeralCounters
{
	private readonly EphemeralCounterFactory _EphemeralCounterFactory;

	private readonly ILogger _Logger;

	private readonly string _PerformanceCategory;

	public EphemeralCounters(string performanceCategory, EphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
	{
		_PerformanceCategory = performanceCategory;
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_Logger = logger;
	}

	public void IncrementDeliveryFailedCounter(PushApplicationType application, PushPlatformType platform, string failureType)
	{
		string destinationType = InstrumentationUtilties.GetDestinationTypeString(application, platform);
		string counterName = $"{_PerformanceCategory}.PushNotificationDeliveryFailure_{destinationType}_{failureType}";
		IncrementCounterAsync(counterName);
	}

	public void IncrementDestinationFloodedCounter(PushApplicationType application, PushPlatformType platform)
	{
		string destinationType = InstrumentationUtilties.GetDestinationTypeString(application, platform);
		string counterName = $"{_PerformanceCategory}.PushNotificationDestinationFlooded_{destinationType}";
		IncrementCounterAsync(counterName);
	}

	public void IncrementDestinationAndTypeCombinationFlooded(PushApplicationType application, string notificationType)
	{
		string counterName = $"{_PerformanceCategory}.PushNotificationDestinationAndTypeCombinationFlooded_{application}_{notificationType}";
		IncrementCounterAsync(counterName);
	}

	private void IncrementCounterAsync(string counterName, int incrementValue = 1)
	{
		Task.Run(delegate
		{
			IncrementCounter(counterName, incrementValue);
		});
	}

	private void IncrementCounter(string counterName, int incrementValue)
	{
		try
		{
			_EphemeralCounterFactory.GetCounter(counterName).Increment(incrementValue);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}
}
