using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class VoteTargetIdAndTargetTypeAndValueFloodChecker : FloodChecker
{
	public VoteTargetIdAndTargetTypeAndValueFloodChecker(long targetId, string targetType, bool vote)
		: base($"VoteFloodChecker_TargetId:{targetId}_TargetType:{targetType.Replace(' ', '_')}_Value:{vote}", Settings.Default.VoteAssetIdAndValueFloodCheckLimit, Settings.Default.VoteAssetIdAndValueFloodCheckExpiry)
	{
	}
}
