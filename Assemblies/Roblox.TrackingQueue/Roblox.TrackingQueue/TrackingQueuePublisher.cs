using System;
using Newtonsoft.Json;
using Roblox.Amazon.Sqs;

namespace Roblox.TrackingQueue;

/// <inheritdoc cref="T:Roblox.TrackingQueue.ITrackingQueuePublisher" />
internal class TrackingQueuePublisher : ITrackingQueuePublisher
{
	private readonly IQueueTracker _QueueTracker;

	private readonly ISqsSender _SqsSender;

	internal TrackingQueuePublisher(ISqsSender sqsSender, IQueueTracker queueTracker)
	{
		_QueueTracker = queueTracker ?? throw new ArgumentNullException("queueTracker");
		_SqsSender = sqsSender ?? throw new ArgumentNullException("sqsSender");
	}

	/// <inheritdoc cref="M:Roblox.TrackingQueue.ITrackingQueuePublisher.SendMessage(Roblox.TrackingQueue.ITrackingQueueMessage)" />
	public void SendMessage(ITrackingQueueMessage message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		string serializedMessage = JsonConvert.SerializeObject(message);
		_SqsSender.SendMessage(serializedMessage);
		_QueueTracker.TrackMessagePublished(message);
	}
}
