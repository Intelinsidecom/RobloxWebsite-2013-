using System;
using System.Threading.Tasks;
using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Platform.Games;

public class PrivateServerConfigurationActionCounters
{
	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly ILogger _Logger;

	private readonly string _CounterPrefix = "PrivateServersConfiguration_Action_";

	public PrivateServerConfigurationActionCounters(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
	{
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_Logger = logger;
	}

	public void IncrementCounterAsync(PrivateServerConfigurationActionCounter actionCounter, int incrementValue = 1)
	{
		Task.Run(delegate
		{
			IncrementCounter(actionCounter, incrementValue);
		});
	}

	private void IncrementCounter(PrivateServerConfigurationActionCounter actionCounter, int incrementValue = 1)
	{
		string counterName = GetCounterName(actionCounter);
		try
		{
			_EphemeralCounterFactory.GetCounter(counterName).Increment(incrementValue);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}

	private string GetCounterName(PrivateServerConfigurationActionCounter actionCounter)
	{
		string counterName = Enum.GetName(typeof(PrivateServerConfigurationActionCounter), actionCounter);
		return _CounterPrefix + counterName;
	}
}
