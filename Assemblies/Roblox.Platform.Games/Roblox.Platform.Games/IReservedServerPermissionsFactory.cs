using System;
using System.Collections.Generic;

namespace Roblox.Platform.Games;

public interface IReservedServerPermissionsFactory
{
	/// <summary>
	/// Generates a new Reserved Server Game Code and uses that to generate an Access Code that can be used to
	/// teleport players to the reserved instance with the returned Game Code.
	/// </summary>
	/// <param name="originPlaceId">Place ID for the place from which the players will be teleported</param>
	/// <param name="reservedServerPlaceId">Place ID for the place to reserve an instance of</param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the reservedServerPlaceId is not in the same universe as the originPlaceId</exception>
	(string AccessCode, Guid GameCode) GenerateAccessCodeAndGameCode(long originPlaceId, long reservedServerPlaceId);

	IReservedServerConfiguration ParseAccessCode(string reservedServerAccessCode);

	bool CheckAccess(string reservedServerAccessCode, long playerId);

	IDictionary<long, bool> CheckAccess(string reservedServerAccessCode, long[] playerIds);

	void GrantAccess(string reservedServerAccessCode, long[] playerIds);

	void RevokeAccess(string reservedServerAccessCode, long[] playerIds);
}
