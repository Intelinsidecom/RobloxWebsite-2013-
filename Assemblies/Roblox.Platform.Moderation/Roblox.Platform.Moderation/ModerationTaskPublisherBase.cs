using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Roblox.Amazon.Sqs;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Moderation.Properties;
using Roblox.TrackingQueue;

namespace Roblox.Platform.Moderation;

/// <summary>
/// A base class for publishing various types of moderation tasks to the SQS queue. 
/// This class centralizes on how the publishing Sqs client is created from config 
/// settings, as well as the business logic of using the right client to publish a task 
/// based on the input locale and priority.
///
/// Note, the type of moderation task being published is determined by the child class that 
/// implements this base class.
/// </summary>
internal abstract class ModerationTaskPublisherBase : ModerationTaskClientBase<ITrackingQueuePublisher>, IDisposable
{
	private readonly ISqsSettings _Settings;

	private readonly ITrackingQueuePublisherFactory _TrackingQueuePublisherFactory;

	internal virtual ICollection<ISqsBatchSender> BatchSenders { get; }

	protected ModerationTaskPublisherBase(ILogger logger, ISqsSettings publisherSettings, ITrackingQueuePublisherFactory trackingQueuePublisherFactory, ITaskQueueIdentifierFactory taskQueueIdentifierFactory)
		: base(logger, taskQueueIdentifierFactory)
	{
		_Settings = publisherSettings ?? throw new ArgumentNullException("publisherSettings");
		_TrackingQueuePublisherFactory = trackingQueuePublisherFactory ?? throw new ArgumentNullException("trackingQueuePublisherFactory");
		BatchSenders = new List<ISqsBatchSender>();
		MonitorSqsQueueSettingsChanges();
	}

	private void MonitorSqsQueueSettingsChanges()
	{
		_Settings.ReadValueAndMonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsUnk), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsEs), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsZhcn), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsZhtw), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsDe), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsPt), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsFr), (Action)delegate
		{
			ResetQueueSettings(AllQueueSettings());
		});
		_Settings.MonitorChanges((Expression<Func<ISqsSettings, string>>)((ISqsSettings s) => s.SqsTaskClientConfigSettingsKo), (Action)delegate
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

	[ExcludeFromCodeCoverage]
	internal override void ConstructAndAddSqsClient(SqsQueueSetting sqsQueueSetting, IDictionary<string, ITrackingQueuePublisher> newSqsClients)
	{
		SqsBatchSender newBatchSender = new SqsBatchSender(sqsQueueSetting.PublishSqsAccessSetting.SqsAccessKey, sqsQueueSetting.PublishSqsAccessSetting.SqsSecretAccessKey, sqsQueueSetting.SqsUrl, 10, 100, 0, retryInOtherRegions: true);
		newBatchSender.ExceptionOccured += Logger.Error;
		newBatchSender.Start();
		BatchSenders.Add(newBatchSender);
		string key = GetKey(sqsQueueSetting);
		ITrackingQueuePublisher trackingQueuePublisher = _TrackingQueuePublisherFactory.Create(newBatchSender, key);
		newSqsClients.Add(key, trackingQueuePublisher);
	}

	public virtual void Publish(string message, ITaskQueueIdentifier queueIdentifier)
	{
		if (string.IsNullOrWhiteSpace(message))
		{
			throw new ArgumentNullException("message");
		}
		if (queueIdentifier == null)
		{
			throw new ArgumentNullException("queueIdentifier");
		}
		TrackingQueueMessage trackingQueueMessage = new TrackingQueueMessage(message, message);
		GetSqsClient(queueIdentifier)?.SendMessage(trackingQueueMessage);
	}

	public void Dispose()
	{
		ClearSqsClients(SqsClients);
		foreach (ISqsBatchSender batchSender in BatchSenders)
		{
			batchSender?.Dispose();
		}
		BatchSenders.Clear();
	}
}
