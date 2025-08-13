namespace Roblox.Platform.Games;

public interface IEventPublisher
{
	void PublishGameUpdatedEvent(long placeid);

	void PublishGameRemovedEvent(long placeid);
}
