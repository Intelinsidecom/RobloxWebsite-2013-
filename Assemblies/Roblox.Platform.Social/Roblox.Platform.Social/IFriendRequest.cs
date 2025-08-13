using System;

namespace Roblox.Platform.Social;

public interface IFriendRequest
{
	long Id { get; }

	long SenderId { get; }

	long RecipientId { get; }

	string Subject { get; }

	string Body { get; }

	DateTime SentAt { get; }

	bool? IsAccepted { get; }
}
