namespace Roblox.Platform.UniverseDisplayInformation;

internal interface ISnsEventPublisher<T>
{
	void Publish(T snsEvent);
}
