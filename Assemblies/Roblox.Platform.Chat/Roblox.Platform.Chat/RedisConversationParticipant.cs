using System;

namespace Roblox.Platform.Chat;

internal class RedisConversationParticipant
{
	public int ParticipantTypeId { get; set; }

	public long ParticipantTargetId { get; set; }

	public DateTime ConversationJoinTime { get; set; }
}
