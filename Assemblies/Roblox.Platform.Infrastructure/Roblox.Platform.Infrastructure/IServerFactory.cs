using System.Collections.Generic;

namespace Roblox.Platform.Infrastructure;

/// <summary>
/// Provides functionality for creating entities of types which implementing <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
/// Using data from Infrastracture DB for getting and building collections of <see cref="T:Roblox.Platform.Infrastructure.IServer" /> which are corresponding 
/// to specified conditions
/// </summary>
public interface IServerFactory
{
	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverType">Type of the server.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerType(ServerType serverType);

	/// <summary>
	/// Returns readonly collection of corresponding Live <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverType">Type of the server.</param>
	/// <param name="serverGroup">The server group.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerTypeAndServerGroup(ServerType serverType, ServerGroup serverGroup);

	/// <summary>
	/// Returns readonly collection of corresponding Live <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverType">Type of the server.</param>
	/// <param name="serverGroup">The server group.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerTypeAndServerGroupWithNoCaching(ServerType serverType, ServerGroup serverGroup);

	/// <summary>
	/// Returns readonly collection of corresponding Live <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverGroupId">The server group identifier.</param>
	/// <param name="serverTypeId">The server type identifier.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerGroupIdAndServerTypeId(int serverGroupId, int serverTypeId);

	/// <summary>
	/// Returns readonly collection of corresponding Live <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverGroupId">The server group identifier.</param>
	/// <param name="serverTypeId">The server type identifier.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerGroupIdAndServerTypeIdWithNoCaching(int serverGroupId, int serverTypeId);

	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverType">Type of the server.</param>
	/// <param name="serverGroup">The server group.</param>
	/// <param name="serverStatus">The server status.</param>
	/// <returns></returns>
	IReadOnlyCollection<IServer> GetServersByServerTypeServerGroupAndServerStatus(ServerType serverType, ServerGroup serverGroup, ServerStatus serverStatus);

	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverType">Type of the server.</param>
	/// <param name="serverGroup">The server group.</param>
	/// <param name="serverStatus">The server status.</param>
	/// <returns></returns>
	IReadOnlyCollection<IServer> GetServersByServerTypeServerGroupAndServerStatusWithNoCaching(ServerType serverType, ServerGroup serverGroup, ServerStatus serverStatus);

	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverGroupId">The server group identifier.</param>
	/// <param name="serverTypeId">The server type identifier.</param>
	/// <param name="serverStatusId">The server status identifier.</param>
	/// <returns></returns>
	IReadOnlyCollection<IServer> GetServersByServerGroupIdServerTypeIdAndServerStatusId(int serverGroupId, int serverTypeId, int serverStatusId);

	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverGroupId">The server group identifier.</param>
	/// <param name="serverTypeId">The server type identifier.</param>
	/// <param name="serverStatusId">The server status identifier.</param>
	/// <returns></returns>
	IReadOnlyCollection<IServer> GetServersByServerGroupIdServerTypeIdAndServerStatusIdWithNoCaching(int serverGroupId, int serverTypeId, int serverStatusId);

	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverTypeId">The server type identifier.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerTypeId(int serverTypeId);

	/// <summary>
	/// Returns readonly collection of corresponding <see cref="T:Roblox.Platform.Infrastructure.IServer" />.
	/// </summary>
	/// <param name="serverTypeId">The server type identifier.</param>
	/// <returns>Read only collection of <see cref="T:Roblox.Platform.Infrastructure.IServer" />.</returns>
	IReadOnlyCollection<IServer> GetServersByServerTypeIdWithNoCaching(int serverTypeId);

	/// <summary>
	/// Gets the server by identifier.
	/// </summary>
	/// <param name="serverId">The server identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Infrastructure.IServer" /></returns>
	IServer GetServerById(int serverId);

	/// <summary>
	/// Gets the server by identifier.
	/// </summary>
	/// <param name="hostName">The server host name.</param>
	/// <returns><see cref="T:Roblox.Platform.Infrastructure.IServer" /></returns>
	IServer GetServerByHostNameWithNoCaching(string hostName);

	/// <summary>
	/// Gets the server by identifier with no caching.
	/// </summary>
	/// <param name="serverId">The server identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Infrastructure.IServer" /></returns>
	IServer GetServerByIdWithNoCaching(int serverId);

	/// <summary>
	/// Gets all server types.
	/// </summary>
	/// <returns>Collection of key value pairs where key is the type identifier and value is name of the type</returns>
	IDictionary<int, string> GetAllServerTypes();

	/// <summary>
	/// Gets all server types with no caching.
	/// </summary>
	/// <returns>Collection of key value pairs where key is the type identifier and value is name of the type</returns>
	IDictionary<int, string> GetAllServerTypesWithNoCaching();
}
