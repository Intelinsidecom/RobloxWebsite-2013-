namespace Roblox.Platform.Groups.Events;

/// <summary>
/// A pipeline or Queue for notifying other parts of the system about changes to Groups.
/// </summary>
public interface IGroupEventPublisher
{
	/// <summary>
	/// Publish that a change of the given type has happened to the given groupId.
	/// The userId is optional, but should indicate the acting user.
	/// </summary>
	/// <param name="groupId"></param>
	/// <param name="groupEventType"></param>
	/// <param name="userId"></param>
	void Publish(long groupId, GroupEventType groupEventType, long? userId);
}
