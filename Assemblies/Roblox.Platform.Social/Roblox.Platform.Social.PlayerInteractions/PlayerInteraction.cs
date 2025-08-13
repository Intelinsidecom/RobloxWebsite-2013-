using System;

namespace Roblox.Platform.Social.PlayerInteractions;

public class PlayerInteraction : IPlayerInteraction
{
	public long UserId { get; private set; }

	public long PlaceId { get; private set; }

	public DateTime InteractionTime { get; private set; }

	internal PlayerInteraction(long userId, long placeId, DateTime interactionTime)
	{
		UserId = userId;
		PlaceId = placeId;
		InteractionTime = interactionTime;
	}
}
