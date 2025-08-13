using System;

namespace Roblox.Platform.Social.PlayerInteractions;

public interface IPlayerInteraction
{
	long UserId { get; }

	long PlaceId { get; }

	DateTime InteractionTime { get; }
}
