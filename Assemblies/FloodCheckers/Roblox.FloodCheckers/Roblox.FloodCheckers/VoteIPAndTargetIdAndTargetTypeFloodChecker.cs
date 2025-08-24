using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class VoteIPAndTargetIdAndTargetTypeFloodChecker : FloodChecker
{
	public VoteIPAndTargetIdAndTargetTypeFloodChecker(string ipAddress, long targetId, string targetType)
		: base($"VoteIPFloodChecker_IPAddress:{ipAddress}_TargetId:{targetId}_TargetType:{targetType.Replace(' ', '_')}", Settings.Default.VoteIPAndAssetIdFloodCheckLimit, TimeSpan.FromHours(Settings.Default.VoteIPAndAssetIdFloodCheckExpiryInHours))
	{
	}
}
