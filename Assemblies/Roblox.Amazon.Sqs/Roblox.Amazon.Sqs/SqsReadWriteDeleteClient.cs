using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Amazon.SQS;
using Amazon.SQS.Model;
using Roblox.Amazon.Sqs.Properties;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default implementation of <see cref="T:Roblox.Amazon.Sqs.ISqsReadWriteDeleteClient" />.
/// </summary>
internal class SqsReadWriteDeleteClient : SqsReadWriteClient, ISqsReadWriteDeleteClient
{
	private static readonly SqsMessage[] _EmptyMessageList = new SqsMessage[0];

	private static readonly SqsMessageWithReceipt[] _EmptyMessageWithReceiptList = new SqsMessageWithReceipt[0];

	private static readonly List<string> _EmptyMessageAttributesList = new List<string>();

	private readonly List<string> _RequestedMessageAttributes;

	private readonly ISqsPerformanceMonitor _TotalsPerformanceMonitor;

	private readonly ISqsPerformanceMonitor _RegionPerformanceMonitor;

	private readonly string _SystemName;

	private readonly ISqsReceiptFactory _SqsReceiptFactory;

	private static int DefaultVisibilityTimeout => Settings.Default.DefaultSqsVisibilityTimeoutSeconds;

	public Func<ISqsBatchDeleter> SqsBatchDeleterGetter { get; }

	public SqsReadWriteDeleteClient(Func<ISqsBatchDeleter> batchDeleterGetter, Func<IAmazonSQS> sqsClientGetter, Func<string> queueUrlGetter, Func<TimeSpan> waitTimeGetter, List<string> requestedMessageAttributes, ISqsPerformanceMonitor totalsPerformanceMonitor, ISqsPerformanceMonitor regionPerformanceMonitor, ISqsReceiptFactory sqsReceiptFactory, string systemName)
		: base(sqsClientGetter, queueUrlGetter, waitTimeGetter)
	{
		SqsBatchDeleterGetter = batchDeleterGetter ?? throw new ArgumentException(string.Format("Required argument not provided:{0}", "batchDeleterGetter"));
		_RequestedMessageAttributes = requestedMessageAttributes ?? _EmptyMessageAttributesList;
		_TotalsPerformanceMonitor = totalsPerformanceMonitor ?? throw new ArgumentException(string.Format("Required argument not provided: {0}", "totalsPerformanceMonitor"));
		_RegionPerformanceMonitor = regionPerformanceMonitor ?? throw new ArgumentException(string.Format("Required argument not provided: {0}", "regionPerformanceMonitor"));
		_SqsReceiptFactory = sqsReceiptFactory ?? throw new ArgumentNullException("sqsReceiptFactory");
		_SystemName = systemName;
	}

	public IReadOnlyCollection<ISqsMessage> GetMessages(int batchSize)
	{
		ReceiveMessageResponse response = GetMessagesFromSqs(batchSize, DefaultVisibilityTimeout);
		if (response == null)
		{
			return (IReadOnlyCollection<ISqsMessage>)(object)_EmptyMessageList;
		}
		List<Message> messages = response.Messages;
		if (messages == null)
		{
			return (IReadOnlyCollection<ISqsMessage>)(object)_EmptyMessageList;
		}
		DateTime messageReceiveTime = DateTime.UtcNow;
		DateTime messageExpiry = messageReceiveTime + TimeSpan.FromSeconds(DefaultVisibilityTimeout);
		return (IReadOnlyCollection<ISqsMessage>)(object)messages.Select((Message m) => GetSqsMessage(m, Message_OnCompleted, messageExpiry)).ToArray();
	}

	public IReadOnlyCollection<ISqsMessageWithReceipt> GetMessagesWithReceipt(int batchSize, int visibilityTimeout)
	{
		ReceiveMessageResponse response = GetMessagesFromSqs(batchSize, visibilityTimeout);
		if (response == null)
		{
			return (IReadOnlyCollection<ISqsMessageWithReceipt>)(object)_EmptyMessageWithReceiptList;
		}
		List<Message> messages = response.Messages;
		if (messages == null)
		{
			return (IReadOnlyCollection<ISqsMessageWithReceipt>)(object)_EmptyMessageWithReceiptList;
		}
		DateTime messageReceiveTime = DateTime.UtcNow;
		DateTime messageExpiry = messageReceiveTime + TimeSpan.FromSeconds(visibilityTimeout);
		return (IReadOnlyCollection<ISqsMessageWithReceipt>)(object)messages.Select((Message m) => GetSqsMessageWithReceipt(m, _SystemName, Message_OnCompleted, messageExpiry)).ToArray();
	}

	private ReceiveMessageResponse GetMessagesFromSqs(int batchSize, int visibilityTimeout)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		ReceiveMessageRequest receiveMessageRequest = new ReceiveMessageRequest
		{
			QueueUrl = base.QueueUrlGetter(),
			MaxNumberOfMessages = Math.Max(Math.Min(10, batchSize), 1),
			WaitTimeSeconds = Math.Max(Math.Min((int)base.WaitTimeGetter().TotalSeconds, 20), 0),
			AttributeNames = _RequestedMessageAttributes,
			VisibilityTimeout = visibilityTimeout
		};
		Stopwatch stopwatch = Stopwatch.StartNew();
		ReceiveMessageResponse response = base.SqsClientGetter().ReceiveMessageAsync(receiveMessageRequest, default(CancellationToken)).GetAwaiter()
			.GetResult();
		stopwatch.Stop();
		long paddedFetchDuration = stopwatch.ElapsedMilliseconds;
		_TotalsPerformanceMonitor.LogSuccessfulFetchMessages(paddedFetchDuration, ((response == null) ? null : response.Messages?.Count) ?? 0);
		_RegionPerformanceMonitor.LogSuccessfulFetchMessages(paddedFetchDuration, ((response == null) ? null : response.Messages?.Count) ?? 0);
		return response;
	}

	private void Message_OnCompleted(ISqsMessage message)
	{
		SqsBatchDeleterGetter().DeleteMessage(message.FullMessage.ReceiptHandle);
	}

	private ISqsMessage GetSqsMessage(Message message, Action<ISqsMessage> message_OnCompleted, DateTime messageExpiry)
	{
		return new SqsMessage(message, message_OnCompleted, messageExpiry);
	}

	private ISqsMessageWithReceipt GetSqsMessageWithReceipt(Message message, string systemName, Action<ISqsMessage> message_OnCompleted, DateTime messageExpiry)
	{
		ISqsReceipt sqsReceipt = _SqsReceiptFactory.GetSqsReceipt((message != null) ? message.ReceiptHandle : null, systemName);
		return new SqsMessageWithReceipt(message, message_OnCompleted, messageExpiry, sqsReceipt);
	}
}
