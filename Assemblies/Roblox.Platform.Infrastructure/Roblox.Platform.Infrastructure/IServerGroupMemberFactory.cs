using System.Collections.Generic;

namespace Roblox.Platform.Infrastructure;

/// <summary>
/// Provides functionality for creating entities of types which implement <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />. 
/// Uses data from ServerGroupMembers table in Infrastracture DB.
/// </summary>
public interface IServerGroupMemberFactory
{
	/// <summary>
	/// Returns read only collection of all <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> for a server. If the cache has it then the data from cache is returned else DB is queried.
	/// </summary>
	/// <param name="serverId">ServerId identifying the server.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />.</returns>
	IReadOnlyCollection<IServerGroupMember> GetServerGroupMembersByServerId(int serverId);

	/// <summary>
	/// Returns read only collection of all <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> for a server. No cached data used.
	/// </summary>
	/// <param name="serverId">ServerId identifying the server.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />.</returns>
	IReadOnlyCollection<IServerGroupMember> GetServerGroupMembersByServerIdWithNoCaching(int serverId);

	/// <summary>
	/// Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> for a server and a specific group. If the cache has it then the data from cache is returned else DB is queried.
	/// </summary>
	/// <param name="serverId">ServerId identifying the server.</param>
	/// <param name="serverGroup">Server group for which <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> needs to be found.</param>
	/// <returns>Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />.</returns>
	IServerGroupMember GetServerGroupMemberByServerIdAndServerGroup(int serverId, ServerGroup serverGroup);

	/// <summary>
	/// Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> for a server and a specific group. No cached data used.
	/// </summary>
	/// <param name="serverId">ServerId identifying the server.</param>
	/// <param name="serverGroup">Server group for which <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> needs to be found.</param>
	/// <returns>Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />.</returns>
	IServerGroupMember GetServerGroupMemberByServerIdAndServerGroupWithNoCaching(int serverId, ServerGroup serverGroup);

	/// <summary>
	/// Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> for a server and a specific group. If the cache has it then the data from cache is returned else DB is queried.
	/// </summary>
	/// <param name="serverId">ServerId identifying the server.</param>
	/// <param name="serverGroupId">Server group id for which <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> needs to be found.</param>
	/// <returns>Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />.</returns>
	IServerGroupMember GetServerGroupMemberByServerIdAndServerGroupId(int serverId, int serverGroupId);

	/// <summary>
	/// Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> for a server and a specific group. No cached data used.
	/// </summary>
	/// <param name="serverId">ServerId identifying the server.</param>
	/// <param name="serverGroupId">Server group id for which <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" /> needs to be found.</param>
	/// <returns>Returns <see cref="T:Roblox.Platform.Infrastructure.IServerGroupMember" />.</returns>
	IServerGroupMember GetServerGroupMemberByServerIdAndServerGroupIdWithNoCaching(int serverId, int serverGroupId);
}
