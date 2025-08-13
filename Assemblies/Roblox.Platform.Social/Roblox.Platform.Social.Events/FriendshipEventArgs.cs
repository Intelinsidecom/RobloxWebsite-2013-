using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.Social.Events;

public class FriendshipEventArgs : WebEventArgs
{
	public long SenderId { get; set; }

	public long RecipientId { get; set; }

	public bool FromInApp { get; set; }

	public bool FromInGame { get; set; }

	public string Context { get; set; }
}
