using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface that represents an <seealso cref="T:Roblox.Amazon.Sqs.ISqsMessage" /> with an <seealso cref="T:Roblox.Amazon.Sqs.ISqsReceipt" />.
/// </summary>
public interface ISqsMessageWithReceipt : ISqsMessage, IMessage
{
	/// <summary>
	/// The <see cref="T:Roblox.Amazon.Sqs.ISqsReceipt" /> of the message.
	/// </summary>
	ISqsReceipt Receipt { get; }
}
