using System;
using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// An interface for a class that constructs interfaces for entities around team create
/// </summary>
public interface ITeamCreateMembershipFactory
{
	/// <summary>
	/// Gets a list of <see cref="T:Roblox.Platform.TeamCreate.ITeamCreateMembership" />s for an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="exclusiveStartInfo">The exclusive start information.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to team create service failed.</exception>
	IPlatformPageResponse<ITeamCreateMembership, ITeamCreateMembership> GetUniverseTeamCreateMembers(IUniverse universe, IExclusiveStartKeyInfo<ITeamCreateMembership> exclusiveStartInfo);

	/// <summary>
	/// Gets a list of <see cref="T:Roblox.Platform.TeamCreate.ITeamCreateMembership" />s an <see cref="T:Roblox.Platform.Membership.IUser" /> is able to team create.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="exclusiveStartInfo">The exclusive start information.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to team create service failed.</exception>
	IPlatformPageResponse<ITeamCreateMembership, ITeamCreateMembership> GetUserTeamCreateMemberships(IUser user, IExclusiveStartKeyInfo<ITeamCreateMembership> exclusiveStartInfo);

	/// <summary>
	/// Gets a list of universe team create members paged.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="pageNumber">The page number.</param>
	/// <returns><see cref="T:System.Collections.Generic.ICollection`1" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="pageNumber" /> is below 1.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Call to permissions service failed.</exception>
	[Obsolete("Please use GetUniverseTeamCreateMembers instead.")]
	ICollection<IUser> GetUniverseTeamCreateMembersPaged(IUniverse universe, int pageNumber);
}
