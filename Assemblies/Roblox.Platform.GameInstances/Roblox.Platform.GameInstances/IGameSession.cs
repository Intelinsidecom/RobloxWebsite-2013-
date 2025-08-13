using System;

namespace Roblox.Platform.GameInstances;

public interface IGameSession
{
	Guid SessionId { get; }

	Guid GameId { get; }

	long PlaceId { get; }

	string ClientIpAddress { get; }

	byte PlatformTypeId { get; }

	DateTime SessionStarted { get; }

	long BrowserTrackerId { get; }

	string GetGameSessionString();
}
