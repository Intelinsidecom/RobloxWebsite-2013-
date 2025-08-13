using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Platform.Games.Counters;

internal class PlaySessionDataCounter : PlaySessionCounterBase
{
	public PlaySessionDataCounter(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(ephemeralCounterFactory, logger)
	{
	}

	public void IncrementPartyJoinCount(int seconds)
	{
		string key = "PlaySessionEnded_PartyJoins";
		IncrementCountAndTotalSeconds(key, seconds);
	}
}
