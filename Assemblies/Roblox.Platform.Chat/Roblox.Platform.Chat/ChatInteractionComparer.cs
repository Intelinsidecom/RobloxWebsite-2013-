using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class ChatInteractionComparer : IEqualityComparer<ChatInteraction>
{
	public static bool AreEqual(ChatInteraction x, ChatInteraction y)
	{
		if (x == null && y == null)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		IParticipant chatParticipant = x.ChatParticipant;
		IParticipant yParticipant = y.ChatParticipant;
		return ParticipantComparer.AreEqual(chatParticipant, yParticipant);
	}

	public bool Equals(ChatInteraction x, ChatInteraction y)
	{
		return AreEqual(x, y);
	}

	public int GetHashCode(ChatInteraction obj)
	{
		if (obj.ChatParticipant != null)
		{
			return (obj.ChatParticipant.TypeId + "_" + obj.ChatParticipant.TargetId).GetHashCode();
		}
		return obj.GetHashCode();
	}
}
