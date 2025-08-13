namespace Roblox.Platform.Communication.Behavior.EventStreaming;

internal interface ICommunicationBehaviorEventStreamer
{
	void Stream(UndesirableCommunicationBehaviorEventArgs eventArgs);
}
