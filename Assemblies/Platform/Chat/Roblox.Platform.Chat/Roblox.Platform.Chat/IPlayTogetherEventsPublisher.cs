using Roblox.Platform.Chat.Events;

namespace Roblox.Platform.Chat;

internal interface IPlayTogetherEventsPublisher
{
	void Publish(PlayTogetherEvent eventToPublish);
}
