using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Devices;
using Roblox.Platform.Games.Counters.Properties;

namespace Roblox.Platform.Games.Counters;

/// <summary>
/// Provides functionality for incrementing counters related to amount of sessions in VR
/// </summary>
public class PlaySessionFromVRCounter : BufferedEphemeralCounterBase
{
	private const string _CounterNamespace = "GameJoins_FromVR_";

	protected override TimeSpan CommitInterval => Settings.Default.GameJoinFromVRCounterCommitInterval;

	protected override int MaxDegreeOfParallelism => Settings.Default.GameJoinFromVRCounterMaxDegreeOfParallelism;

	public PlaySessionFromVRCounter(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(ephemeralCounterFactory, logger)
	{
	}

	/// <summary>
	/// Increments a counter that tracks sessions to the game from VR by device type
	/// </summary>
	/// <param name="deviceType">Type of the device.</param>
	/// <param name="increment">Number to increment.</param>
	public void IncrementForDeviceType(DeviceType deviceType, int increment = 1)
	{
		string key = string.Format("{0}ByDeviceType_{1}", "GameJoins_FromVR_", deviceType.ToString("G"));
		Increment(key, increment);
	}

	/// <summary>
	/// Increments a counter that tracks sessions to the game from VR
	/// </summary>
	/// <param name="increment">Number to increment.</param>
	public void IncrementTotal(int increment = 1)
	{
		string key = string.Format("{0}Total", "GameJoins_FromVR_");
		Increment(key, increment);
	}
}
