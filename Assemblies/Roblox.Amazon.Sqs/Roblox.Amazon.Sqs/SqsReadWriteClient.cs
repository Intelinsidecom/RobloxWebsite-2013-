using System;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

internal class SqsReadWriteClient
{
	public Func<string> QueueUrlGetter { get; }

	public Func<IAmazonSQS> SqsClientGetter { get; }

	public Func<TimeSpan> WaitTimeGetter { get; }

	public SqsReadWriteClient(Func<IAmazonSQS> sqsClientGetter, Func<string> queueUrlGetter, Func<TimeSpan> waitTimeGetter = null)
	{
		SqsClientGetter = sqsClientGetter ?? throw new ArgumentException("Required argument not provided: sqsClientGetter.", "sqsClientGetter");
		QueueUrlGetter = queueUrlGetter ?? throw new ArgumentException("Required argument not provided: queueUrlGetter.", "queueUrlGetter");
		WaitTimeGetter = waitTimeGetter ?? ((Func<TimeSpan>)(() => TimeSpan.FromSeconds(10.0)));
	}
}
