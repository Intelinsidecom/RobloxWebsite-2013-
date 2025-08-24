using System;
using Amazon.SQS.Model;
using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsMessage" />.
/// </summary>
internal class SqsMessage : ISqsMessage, IMessage
{
	private readonly Action<ISqsMessage> _OnCompleted;

	public string Message => FullMessage.Body;

	public Message FullMessage { get; private set; }

	public DateTime MessageExpiry { get; private set; }

	internal SqsMessage(Message sqsMessage, Action<ISqsMessage> onCompletedCallback, DateTime messageExpiry)
	{
		FullMessage = sqsMessage;
		_OnCompleted = onCompletedCallback ?? throw new ArgumentException("Required argument not provided: onCompletedCallback.", "onCompletedCallback");
		MessageExpiry = messageExpiry;
	}

	public void OnCompleted()
	{
		_OnCompleted(this);
	}
}
