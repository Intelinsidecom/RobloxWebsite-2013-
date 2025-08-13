using System;
using System.Collections.Generic;

namespace Roblox.Platform.GameInstances;

public interface IGameInstance
{
	Guid Id { get; }

	long PlaceId { get; }

	double Fps { get; }

	int Ping { get; }

	ICollection<long> PlayerIds { get; }

	byte Capacity { get; }

	string ServerIpAddress { get; }

	Guid? GameCode { get; }

	int MatchmakingContextId { get; }
}
