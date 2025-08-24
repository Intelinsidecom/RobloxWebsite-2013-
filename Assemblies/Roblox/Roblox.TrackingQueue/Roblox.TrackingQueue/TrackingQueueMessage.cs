namespace Roblox.TrackingQueue;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TrackingQueue.ITrackingQueueMessage" />
/// </summary>
public class TrackingQueueMessage : ITrackingQueueMessage
{
	/// <inheritdoc cref="P:Roblox.TrackingQueue.ITrackingQueueMessage.Id" />
	public string Id { get; set; }

	/// <inheritdoc cref="P:Roblox.TrackingQueue.ITrackingQueueMessage.Body" />
	public string Body { get; set; }

	public TrackingQueueMessage(string messageId, string messageBody)
	{
		Id = messageId;
		Body = messageBody;
	}
}
