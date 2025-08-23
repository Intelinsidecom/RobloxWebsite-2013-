using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

/// <summary>
/// Handles shutting down game instances for a universe.
/// </summary>
public interface IUniverseShutdownAuthority
{
	/// <summary>
	/// Attempts to close all game instances for a particular universeId. It is assumed that the user making this call is authorized to
	/// manage the universe they are trying to shut down game instances of. A universe could have thousands of instances and this would
	/// iterate over each of them. This should not happen over the main thread and hence the ticket to processorize this - https://jira.roblox.com/browse/AV-1409
	/// </summary>
	/// <param name="universeId">Universe id to shut down game instances of.</param>
	/// <param name="user">User performing the action.</param>
	/// <returns><c>True</c> if all game instances were closed, or <c>False</c> if some of the game instances could not be closed.</returns>
	bool CloseAllGameInstances(long universeId, IUser user);
}
