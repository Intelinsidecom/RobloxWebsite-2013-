using Roblox.Economy;
using Roblox.Platform.Games.PrivateServer;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

public interface IUniversePrivateServersSettingsManager
{
	/// <summary>
	/// Get total number of private servers of a given type for an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <param name="privateServerStatusType">A <see cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerStatusType" /></param>
	/// <returns>Total number of private servers for the given <paramref name="privateServerStatusType" />.</returns>
	long GetTotalNumberOfPrivateServersByPrivateServerStatusType(IUniverse universe, PrivateServerStatusType privateServerStatusType);

	/// <summary>
	/// Determine if a universe allows private servers.
	/// </summary>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <returns>Whether <paramref name="universe" /> allows private servers.</returns>
	bool DoesUniverseAllowPrivateServers(IUniverse universe);

	/// <summary>
	/// Set whether private servers can be created for an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <param name="allowPrivateServers">Whether <paramref name="universe" /> should allow private servers.</param>
	/// <param name="userPerformingChangeId">ID of the user changing <paramref name="universe" />'s configuration.</param>
	/// <param name="priceInRobux">The price in Robux to create a private server for <paramref name="universe" />.</param>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.InvalidOwnerException">Thrown when <paramref name="userPerformingChangeId" /> does not have sufficient priviliges to manage <paramref name="universe" />.</exception>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerArgumentException">Thrown when <paramref name="priceInRobux" /> is non-null and below the default private server price.</exception>
	/// <exception cref="T:System.NotSupportedException">Thrown when <paramref name="universe" /> has a creator type that does not support VIP server creation.</exception>
	void SetUniverseDoesAllowPrivateServers(IUniverse universe, bool allowPrivateServers, long userPerformingChangeId, long? priceInRobux = null);

	/// <summary>
	/// Set the private server price for an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <param name="userPerformingChangeId">ID of the user changing <paramref name="universe" />'s configuration.</param>
	/// <param name="newPriceInRobux">The price in Robux to create a private server for <paramref name="universe" />.</param>
	/// <returns>Whether the price of creating a private server in <paramref name="universe" /> was changed.</returns>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.InvalidOwnerException">Thrown when <paramref name="userPerformingChangeId" /> does not have sufficient priviliges to manage <paramref name="universe" />.</exception>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServerArgumentException">Thrown when <paramref name="newPriceInRobux" /> is non-null and below the default private server price.</exception>
	/// <exception cref="T:Roblox.Platform.Games.PrivateServer.PrivateServersPlatformException">Thrown when there was an issue changing the price.</exception>
	bool SetPrivateServerPriceForUniverse(IUniverse universe, long userPerformingChangeId, long newPriceInRobux);

	/// <summary>
	/// Get the private server product for an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <returns>The private server product for <paramref name="universe" /></returns>
	Product GetPrivateServerProduct(IUniverse universe);

	/// <summary>
	/// Checks if an <see cref="T:Roblox.Platform.Universes.IUniverse" />'s configurations allow VIP servers.
	/// </summary>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <exception cref="T:Roblox.Platform.Games.Exceptions.UniverseDisallowsPrivateServersException">Thrown when VIP servers are disabled for <paramref name="universe" />.</exception>
	/// <exception cref="T:Roblox.Platform.Games.Exceptions.UniverseDisallowsPrivateServersException">Thrown when <paramref name="universe" /> does not have a valid start place.</exception>
	/// <exception cref="T:Roblox.Platform.Games.Exceptions.UniverseDisallowsPrivateServersException">Thrown when <paramref name="universe" /> is not playable.</exception>
	/// <exception cref="T:Roblox.Platform.Games.Exceptions.UniverseDisallowsPrivateServersException">Thrown when <paramref name="universe" /> is set to Friends Only.</exception>
	void VerifyPrivateServerConfigurePermissions(IUniverse universe);
}
