using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class VoteFloodChecker : FloodChecker
{
	public VoteFloodChecker(long userId)
		: base($"VoteFloodChecker_UserID:{userId}", Settings.Default.VoteFloodCheckLimit, TimeSpan.FromHours(Settings.Default.VoteFloodCheckExpiry))
	{
	}
}
