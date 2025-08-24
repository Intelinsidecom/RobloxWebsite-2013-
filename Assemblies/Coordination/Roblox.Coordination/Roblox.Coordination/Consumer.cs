using System;
using System.Collections.Generic;
using System.Threading;
using Roblox.Coordination.Interface;

namespace Roblox.Coordination;

public abstract class Consumer : BackgroundWorker, IConsumer, IBackgroundWorker
{
	private class DeliverMessageResult
	{
		public bool DeliveredSuccessfully { get; set; }

		public bool ShouldContinueToAttemptDelivery { get; set; }
	}

	private const bool _DefaultShouldContineToAttemptDelivery = true;

	private static readonly TimeSpan _DefaultBackoff = TimeSpan.FromMilliseconds(50.0);

	private int _MessagesReceived;

	public int BatchSize { get; set; }

	public bool MessageDeliveryWasThrottled { get; private set; }

	public int SurplusCapacity => Math.Max(0, BatchSize - _MessagesReceived);

	protected virtual Func<int, TimeSpan> BackoffCalculator => ConstantBackoff;

	protected abstract Func<IMessage, int, bool> ShouldContinueToAttemptDelivery { get; }

	protected abstract Func<IMessage, bool> ProcessMessage { get; }

	protected abstract string Name { get; }

	protected abstract IReadOnlyCollection<IMessage> GetMessages(int batchSize);

	protected override void DoWork()
	{
		if (ProcessMessage == null)
		{
			throw new Exception($"Unable to deliver messages for Consumer: {Name}. No ProcessMessage function was provided.");
		}
		MessageDeliveryWasThrottled = false;
		IReadOnlyCollection<IMessage> messages = GetMessages(BatchSize);
		_MessagesReceived = messages.Count;
		int iteration = 0;
		while (messages.Count > 0)
		{
			List<IMessage> redeliveryList = new List<IMessage>();
			foreach (IMessage message in messages)
			{
				DeliverMessageResult result = DeliverMessage(message, iteration);
				if (!result.DeliveredSuccessfully && result.ShouldContinueToAttemptDelivery)
				{
					redeliveryList.Add(message);
				}
			}
			messages = redeliveryList;
			iteration++;
		}
	}

	private DeliverMessageResult DeliverMessage(IMessage message, int iteration)
	{
		if (iteration > 0)
		{
			TimeSpan backoff = BackoffCalculator(iteration);
			if (backoff > TimeSpan.Zero)
			{
				Thread.Sleep(backoff);
			}
		}
		bool shouldContinueToAttemptDelivery = false;
		bool messageWasDelivered = ProcessMessage(message);
		if (iteration == 0)
		{
			MessageDeliveryWasThrottled = !messageWasDelivered;
		}
		if (!messageWasDelivered)
		{
			shouldContinueToAttemptDelivery = ShouldContinueToAttemptDelivery?.Invoke(message, iteration) ?? true;
		}
		return new DeliverMessageResult
		{
			DeliveredSuccessfully = messageWasDelivered,
			ShouldContinueToAttemptDelivery = shouldContinueToAttemptDelivery
		};
	}

	private static TimeSpan ConstantBackoff(int iteration)
	{
		return _DefaultBackoff;
	}
}
