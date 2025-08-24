using Roblox.Platform.EventStream;

namespace Roblox.Platform.Communication.Behavior.EventStreaming;

internal class CommunicationBehaviorEventStreamer : ICommunicationBehaviorEventStreamer
{
	private readonly IEventStreamer _EventStreamer;

	public CommunicationBehaviorEventStreamer(IEventStreamer eventStreamer)
	{
		_EventStreamer = eventStreamer;
	}

	public void Stream(UndesirableCommunicationBehaviorEventArgs eventArgs)
	{
		new UndesirableCommunicationBehaviorEvent(_EventStreamer, eventArgs).Stream();
	}
}
