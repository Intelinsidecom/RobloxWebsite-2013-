namespace Roblox.Platform.GameLocalization.Events;

internal interface ISnsEventPublisher<T>
{
	void Publish(T snsEvent);
}
