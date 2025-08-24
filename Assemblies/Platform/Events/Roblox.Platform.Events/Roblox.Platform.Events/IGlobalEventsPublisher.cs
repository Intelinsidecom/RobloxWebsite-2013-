namespace Roblox.Platform.Events;

public interface IGlobalEventsPublisher
{
	bool PublishMessage(object message, long eventDestinationId);

	long GetOrCreateEventDestination(EventDestinationType eventDestinationType, string eventDestinationName);
}
