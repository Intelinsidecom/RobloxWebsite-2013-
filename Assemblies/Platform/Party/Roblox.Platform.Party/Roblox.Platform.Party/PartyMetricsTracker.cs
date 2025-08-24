using System;
using System.Threading.Tasks;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Party;

public class PartyMetricsTracker : IPartyMetricsTracker
{
	private readonly EphemeralCounterFactory _EphemeralCounterFactory;

	private readonly ILogger _Logger;

	private readonly string _PartyCreatedCounterName;

	private readonly string _PartyUserJoinedCounterName;

	private readonly string _PartyJoinedGame;

	private readonly string _PartyMembersJoinedGame;

	private const string _PerformanceCategory = "Roblox.Platform.Party";

	public PartyMetricsTracker(EphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
	{
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_Logger = logger;
		_PartyCreatedCounterName = "Roblox.Platform.Party.PartyCreated";
		_PartyUserJoinedCounterName = "Roblox.Platform.Party.PartyUserJoined";
		_PartyJoinedGame = "Roblox.Platform.Party.PartyJoinedGame";
		_PartyMembersJoinedGame = "Roblox.Platform.Party.PartyMembersJoinedGame";
	}

	public void RecordPartyCreation(DeviceType deviceType)
	{
		IncrementCounterAsync(_PartyCreatedCounterName, deviceType, 1);
	}

	public void RecordPartyUserJoined(DeviceType deviceType, int userCount = 1)
	{
		IncrementCounterAsync(_PartyUserJoinedCounterName, deviceType, 1);
	}

	public void RecordPartyJoinedGame(DeviceType deviceType, int usersInParty)
	{
		IncrementCounterAsync(_PartyJoinedGame, deviceType, 1);
		IncrementCounterAsync(_PartyMembersJoinedGame, deviceType, usersInParty);
	}

	private void IncrementCounterAsync(string counterName, DeviceType deviceType, int incrementValue)
	{
		Task.Run(delegate
		{
			IncrementCounter(counterName, deviceType, incrementValue);
		});
	}

	private void IncrementCounter(string counterName, DeviceType deviceType, int incrementValue)
	{
		try
		{
			string deviceSpecificCounter = counterName + "_" + deviceType;
			_EphemeralCounterFactory.GetCounter(deviceSpecificCounter).Increment(incrementValue);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}
}
