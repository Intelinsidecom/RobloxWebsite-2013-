using Roblox.FloodCheckers.Core;

namespace Roblox.Platform.Groups;

public interface IGroupFloodCheckerFactory
{
	IFloodChecker GetJoinGroupFloodChecker(long userId);

	IFloodChecker GetClaimOwnershipFloodChecker(long userId);
}
