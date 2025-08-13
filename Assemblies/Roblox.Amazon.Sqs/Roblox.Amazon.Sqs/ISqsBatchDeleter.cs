using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface that represents the background-running batch message deleter for AWS SQS.
/// </summary>
internal interface ISqsBatchDeleter : ISqsDeleter, IBackgroundWorker
{
}
