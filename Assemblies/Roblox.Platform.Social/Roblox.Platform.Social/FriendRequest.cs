using System;

namespace Roblox.Platform.Social;

internal class FriendRequest : IFriendRequest
{
	public long Id { get; set; }

	public long SenderId { get; set; }

	public long RecipientId { get; set; }

	public string Subject { get; set; }

	public string Body { get; set; }

	public DateTime SentAt { get; set; }

	public bool? IsAccepted { get; set; }
}
