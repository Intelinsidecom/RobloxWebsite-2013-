using System;
using System.Diagnostics.CodeAnalysis;
using Amazon.SQS.Model;
using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsMessageWithReceipt" />.
/// </summary>
[ExcludeFromCodeCoverage]
internal class SqsMessageWithReceipt : SqsMessage, ISqsMessageWithReceipt, ISqsMessage, IMessage
{
	/// <summary>
	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.ISqsMessageWithReceipt.Receipt" />
	/// </summary>
	public ISqsReceipt Receipt { get; }

	internal SqsMessageWithReceipt(Message sqsMessage, Action<ISqsMessage> onCompletedCallback, DateTime messageExpiry, ISqsReceipt sqsReceipt)
		: base(sqsMessage, onCompletedCallback, messageExpiry)
	{
		Receipt = sqsReceipt ?? throw new ArgumentNullException("sqsReceipt");
	}
}
