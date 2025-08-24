using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// Factory for getting the flood checkers relate to email operations
/// </summary>
internal interface IUserEmailFloodCheckerFactory
{
	/// <summary>
	/// Get the verify email <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> for the given <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> who tried to verify email.</param>
	/// <returns>A <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /></returns>
	IFloodChecker GetFloodCheckerForVerifyEmail(IUser user);
}
