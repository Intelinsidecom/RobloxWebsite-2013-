using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Factory for getting the flood checkers relate to two-step verification operations
/// </summary>
public interface ITwoStepVerificationFloodCheckerFactory
{
	/// <summary>
	/// Get the set two-step verification <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> for the given <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> who tried to set two-step verification.</param>
	/// <returns>A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /></returns>
	IFloodChecker GetFloodCheckerForSetTwoStepSetting(IUser user);
}
