using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class ChatInteraction
{
	public IParticipant ChatParticipant { get; }

	public UtcInstant LastInteracted { get; }

	public ChatInteraction(IParticipant chatParticipant, UtcInstant lastInteracted)
	{
		ChatParticipant = chatParticipant;
		LastInteracted = lastInteracted;
	}
}
