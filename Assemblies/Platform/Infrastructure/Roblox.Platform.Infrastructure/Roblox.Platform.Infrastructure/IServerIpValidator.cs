namespace Roblox.Platform.Infrastructure;

/// <summary>
/// Provides functionality for checking that specified ipAddress belongs to server with appropriate <see cref="P:Roblox.Platform.Infrastructure.IServerIpValidator.ServerGroup" /> and <see cref="P:Roblox.Platform.Infrastructure.IServerIpValidator.ServerType" />.
/// </summary>
public interface IServerIpValidator
{
	/// <summary>
	/// Gets the type of the server.
	/// </summary>
	/// <value>
	/// The type of the server.
	/// </value>
	ServerType ServerType { get; }

	/// <summary>
	/// Gets the server group.
	/// </summary>
	/// <value>
	/// The server group.
	/// </value>
	ServerGroup ServerGroup { get; }

	/// <summary>
	/// Validates that ipAddress belongs to server with appropriate <see cref="P:Roblox.Platform.Infrastructure.IServerIpValidator.ServerGroup" /> and <see cref="P:Roblox.Platform.Infrastructure.IServerIpValidator.ServerType" />.
	/// </summary>
	/// <param name="ipAddress">The ip address.</param>
	/// <returns>
	/// true if ipAddress is ipAddress of server which corresponds to specified settings, otherwise false.
	/// </returns>
	bool VerifyServerAccess(string ipAddress);
}
