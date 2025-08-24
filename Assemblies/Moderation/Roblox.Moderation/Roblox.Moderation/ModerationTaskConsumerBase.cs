using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using Roblox.Amazon.Sqs;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Moderation.Properties;
using Roblox.TrackingQueue;

namespace Roblox.Platform.Moderation;

/// <summary>
/// A base class for reading and/or deleting various types of moderation tasks from the SQS queue. 
/// This class centralizes on how the Sqs client is created from config settings, as well as the 
/// business logic of using the right client to read/delete a task based on the input locale and priority.
///
/// Note, the type of moderation task being retrieved/deleted is determined by the child class that 
/// implements this base class.
/// </summary>
internal abstract class ModerationTaskConsumerBase : ModerationTaskClientBase<ITrackingQueueConsumer>, IModerationTaskConsumer, IDisposable
{
	private readonly ISqsConfigSettingsFactory _SqsConfigSettingsFactory;

	private readonly ISqsConsumerFactory _SqsConsumerFactory;

	private readonly ISqsConsumerSettings _Settings;

	private readonly ITrackingQueueConsumerFactory _TrackingQueueConsumerFactory;

	private readonly ISqsOpenTaskFactory _SqsOpenTaskFactory;

	private readonly Random _Rand;

	internal virtual ICollection<ISqsConsumerWithReceipt> ConsumerWithReceipts { get; }

	internal List<string> RequestedMessageAttributes => null;

	internal abstract string PerformanceMonitorCategory { get; }

	protected ModerationTaskConsumerBase(ILogger logger, ISqsConfigSettingsFactory sqsConfigSettingsFactory, ISqsConsumerFactory sqsConsumerFactory, ISqsConsumerSettings sqsSettings, ITrackingQueueConsumerFactory trackingQueueConsumerFactory, ISqsOpenTaskFactory sqsOpenTaskFactory, ITaskQueueIdentifierFactory taskQueueIdentifierFactory)
		: base(logger, taskQueueIdentifierFactory)
	{
		_SqsConfigSettingsFactory = sqsConfigSettingsFactory ?? throw new ArgumentNullException("sqsConfigSettingsFactory");
		_SqsConsumerFactory = sqsConsumerFactory ?? throw new ArgumentNullException("sqsConsumerFactory");
		_Settings = sqsSettings ?? throw new ArgumentNullException("sqsSettings");
		_TrackingQueueConsumerFactory = trackingQueueConsumerFactory ?? throw new ArgumentNullException("trackingQueueConsumerFactory");
		_SqsOpenTaskFactory = sqsOpenTaskFactory ?? throw new ArgumentNullException("sqsOpenTaskFactory");
		_Rand = new Random();
		ConsumerWithReceipts = new List<ISqsConsumerWithReceipt>();
		MonitorSqsQueueSettingsChanges();
	}

	private void MonitorSqsQueueSettingsChanges()
	{
		_Settings.ReadValueAndMonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsUnk), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsEs), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsZhcn), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsZhtw), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsDe), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsPt), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsFr), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsConsumerSettings, string>>)((ISqsConsumerSettings s) => s.SqsTaskClientConfigSettingsKo), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
	}

	internal virtual IEnumerable<string> AllQueueSettings()
	{
		yield return _Settings.SqsTaskClientConfigSettingsUnk;
		yield return _Settings.SqsTaskClientConfigSettingsEs;
		yield return _Settings.SqsTaskClientConfigSettingsZhcn;
		yield return _Settings.SqsTaskClientConfigSettingsZhtw;
		yield return _Settings.SqsTaskClientConfigSettingsDe;
		yield return _Settings.SqsTaskClientConfigSettingsPt;
		yield return _Settings.SqsTaskClientConfigSettingsFr;
		yield return _Settings.SqsTaskClientConfigSettingsKo;
	}

	internal override void ConstructAndAddSqsClient(SqsQueueSetting sqsQueueSetting, IDictionary<string, ITrackingQueueConsumer> newSqsClients)
	{
		if (sqsQueueSetting == null)
		{
			throw new ArgumentNullException("sqsQueueSetting");
		}
		if (newSqsClients == null)
		{
			throw new ArgumentNullException("newSqsClients");
		}
		ISqsConfigSettings sqsConfigSettings = _SqsConfigSettingsFactory.GetSqsConfigSettings(sqsQueueSetting.SqsUrl, sqsQueueSetting.ReceiveSqsAccessSetting.SqsAccessKey, sqsQueueSetting.ReceiveSqsAccessSetting.SqsSecretAccessKey);
		ISqsConsumerWithReceipt sqsConsumer = _SqsConsumerFactory.GetSqsConsumerWithReceipt(sqsConfigSettings, RequestedMessageAttributes, PerformanceMonitorCategory, sqsQueueSetting.BatchSize, sqsQueueSetting.VisibilityTimeoutInSeconds);
		ConsumerWithReceipts.Add(sqsConsumer);
		string key = GetKey(sqsQueueSetting);
		ITrackingQueueConsumer trackingQueueConsumer = _TrackingQueueConsumerFactory.Create(sqsConsumer, key);
		newSqsClients.Add(key, trackingQueueConsumer);
	}

	internal virtual bool UseHighPriorityQueue()
	{
		double highPriorityAbuseQueueUsagePercentage = _Settings.HighPriorityAbuseQueueUsagePercentage;
		if (highPriorityAbuseQueueUsagePercentage < _Settings.HighPriorityAbuseQueueMinimumUsagePercentage)
		{
			Logger.Error(string.Format("The setting {0} is set to a value below 1%.", "highPriorityAbuseQueueUsagePercentage"));
			highPriorityAbuseQueueUsagePercentage = _Settings.HighPriorityAbuseQueueMinimumUsagePercentage;
		}
		return NextDouble() < highPriorityAbuseQueueUsagePercentage;
	}

	internal virtual double NextDouble()
	{
		return _Rand.NextDouble();
	}

	internal virtual ISqsOpenTask GetNextMessage(ITaskQueueIdentifier queueIdentifier, string worker)
	{
		ITrackingQueueConsumer sqsConsumer = GetSqsClient(queueIdentifier);
		try
		{
			ITrackingQueueMessageWithReceipt messageWithReceipt = sqsConsumer?.GetNextMessageForWorker(worker);
			if (messageWithReceipt != null)
			{
				return CreateOpenTask(queueIdentifier, worker, messageWithReceipt);
			}
		}
		catch (SocketException ex)
		{
			Logger.Error(ex);
			throw ex;
		}
		return null;
	}

	internal virtual ICollection<ISqsOpenTask> GetNextMessages(ITaskQueueIdentifier queueIdentifier, string worker, int maxCount)
	{
		ITrackingQueueConsumer sqsConsumer = GetSqsClient(queueIdentifier);
		try
		{
			return (from m in (sqsConsumer?.GetNextMessagesForWorker(worker, maxCount))?.Where((ITrackingQueueMessageWithReceipt m) => m != null)
				select CreateOpenTask(queueIdentifier, worker, m)).ToArray() ?? new ISqsOpenTask[0];
		}
		catch (SocketException ex)
		{
			Logger.Error(ex);
			throw ex;
		}
	}

	private ISqsOpenTask CreateOpenTask(ITaskQueueIdentifier queueIdentifier, string worker, ITrackingQueueMessageWithReceipt messageWithReceipt)
	{
		OpenTaskIdentifier openTaskIdentifier2 = default(OpenTaskIdentifier);
		openTaskIdentifier2.ReceiptHandle = messageWithReceipt.ReceiptHandle;
		openTaskIdentifier2.ReceiptRegionName = messageWithReceipt.RegionName;
		OpenTaskIdentifier openTaskIdentifier = openTaskIdentifier2;
		return _SqsOpenTaskFactory.Create(queueIdentifier, messageWithReceipt.Body, messageWithReceipt.MessageExpiry, worker, openTaskIdentifier);
	}

	public void DeleteMessage(ISqsOpenTask openTask)
	{
		if (openTask == null)
		{
			throw new ArgumentNullException("openTask");
		}
		TrackingQueueMessageWithReceipt trackingQueueMessageWithReceipt = new TrackingQueueMessageWithReceipt(openTask.Message, openTask.Message, openTask.TaskIdentifier.ReceiptHandle, openTask.TaskIdentifier.ReceiptRegionName, openTask.TaskExpiry);
		GetSqsClient(openTask.QueueIdentifier)?.DeleteMessageForWorker(trackingQueueMessageWithReceipt, openTask.Worker);
	}

	public void Dispose()
	{
		ClearSqsClients(SqsClients);
		foreach (ISqsConsumerWithReceipt consumerWithReceipt in ConsumerWithReceipts)
		{
			consumerWithReceipt?.Dispose();
		}
		ConsumerWithReceipts.Clear();
	}
}
