namespace Roblox.Platform.Notifications.Stream;

public class StreamEventHandlerRegistrar : IStreamEventHandlerRegistrar
{
	private IStreamMetricsTracker _StreamMetricsTracker;

	public StreamEventHandlerRegistrar(IStreamMetricsTracker metricsTracker)
	{
		_StreamMetricsTracker = metricsTracker;
	}

	public void Register()
	{
		NotificationStreamAccessor.OnStreamNotificationMissing += _StreamMetricsTracker.IncrementMissingStreamNotificationCounter;
	}
}
