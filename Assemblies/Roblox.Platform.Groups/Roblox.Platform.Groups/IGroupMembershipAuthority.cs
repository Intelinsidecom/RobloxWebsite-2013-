using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public interface IGroupMembershipAuthority
{
	/// <summary>
	/// Claims ownership of a group.
	/// </summary>
	/// <param name="newOwner">The <see cref="T:Roblox.Platform.Membership.IUser" /> claiming the group.</param>
	/// <exception cref="T:Roblox.Platform.Groups.ClaimGroupUnauthorizedException">User was not authorized to claim the group.</exception>
	/// <exception cref="T:Roblox.Platform.Groups.ClaimGroupWithOwnerException">User tried to claim a group with an existing owner.</exception>
	/// <exception cref="T:Roblox.Platform.Groups.ClaimOwnershipFloodCheckedException">User tried to claim too many groups within a time period.</exception>
	/// <exception cref="T:Roblox.Platform.Groups.ClaimGroupException">Exception occurred while the claiming the group. See inner exception or message.</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Claiming ownership is temporarily unavailable.</exception>
	void ClaimOwnership(IGroup group, IUser newOwner);

	OwnershipChangeResult ChangeOwner(IGroup group, IUser authenticatedUser, IUser newOwner);
}
