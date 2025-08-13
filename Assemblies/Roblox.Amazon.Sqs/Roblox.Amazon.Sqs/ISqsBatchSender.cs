using System;
using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface represents the background-running batch message sender for AWS SQS.
/// </summary>
public interface ISqsBatchSender : ISqsSender, IBackgroundWorker, IDisposable
{
}
