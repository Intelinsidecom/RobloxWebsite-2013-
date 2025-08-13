using System;

namespace Roblox.Platform.TeamCreate.Events;

/// <summary>
/// Interface for Team Create event provider.
/// </summary>
public interface ITeamCreateChangeReporter : IObservable<TeamCreateEvent>
{
	/// <summary>
	/// Method to notify observers of changes to Team Create membership.
	/// </summary>
	/// <param name="universeId"></param>
	/// <param name="changeType"></param>
	/// <param name="userId"></param>
	void EntityChanged(long universeId, TeamCreateChangeType changeType, long? userId);
}
