using System;
using System.Collections.Generic;
using Roblox.Coordination;
using Roblox.EventLog;

namespace Roblox.Amazon.Sqs;

internal class SqsConsumer : Consumer
{
	private readonly Func<IMessage, bool> _ProcessMessage;

	private readonly ILogger _Logger;

	private readonly string _Name;

	private readonly SqsReadWriteDeleteClient _SqsReadWriteDeleteClient;

	private readonly Func<int, TimeSpan> _BackoffCalculator;

	private readonly int _RetryIterationLimit;

	protected override Func<IMessage, bool> ProcessMessage => _ProcessMessage;

	protected override string Name => _Name;

	protected override Func<int, TimeSpan> BackoffCalculator => _BackoffCalculator;

	protected override Func<IMessage, int, bool> ShouldContinueToAttemptDelivery => (IMessage message, int iteration) => !HasMessageExpired(message) && iteration < _RetryIterationLimit;

	public SqsConsumer(ILogger logger, string name, Func<IMessage, bool> processMessage, SqsReadWriteDeleteClient sqsReadWriteDeleteClient, Func<int, TimeSpan> backoffCalculator, int retryIterationLimit)
	{
		_Logger = logger;
		_Name = name;
		_ProcessMessage = processMessage;
		_SqsReadWriteDeleteClient = sqsReadWriteDeleteClient;
		_BackoffCalculator = backoffCalculator ?? base.BackoffCalculator;
		_RetryIterationLimit = retryIterationLimit;
	}

	protected override IReadOnlyCollection<IMessage> GetMessages(int batchSize)
	{
		return _SqsReadWriteDeleteClient.GetMessages(batchSize);
	}

	protected override void HandleException(Exception exception)
	{
		_Logger.Error(exception);
	}

	public override void Stop()
	{
		base.Stop();
		_Logger.Info("Stopped processing queue.");
	}

	private static bool HasMessageExpired(IMessage message)
	{
		if (!(message is ISqsMessage sqsMessage))
		{
			throw new ApplicationException("SqsConsumer can only consume ISqsMessages.");
		}
		return DateTime.UtcNow > sqsMessage.MessageExpiry;
	}
}
