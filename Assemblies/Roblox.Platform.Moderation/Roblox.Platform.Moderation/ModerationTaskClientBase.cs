using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Roblox.EventLog;

namespace Roblox.Platform.Moderation;

/// <summary>
/// This is A base class for moderation task clients interacting with the SQS queues. 
/// Centralizes logic around the initialization of a dictionary set of Sqs clients 
/// identifiable by their queue identifier. The base class abstracts away the multiple 
/// locale-priority queues concept and provides a singular interface for interacting with 
/// various locale-priority Sqs queues.
///
/// Note that we expect the actual publishing and reading/deleting to happen 
/// in different classes, so these methods are not enforced by this base class.
/// </summary>
internal abstract class ModerationTaskClientBase<T>
{
	protected readonly ILogger Logger;

	protected readonly ITaskQueueIdentifierFactory TaskQueueIdentifierFactory;

	private readonly object _SqsLock = new object();

	internal virtual IDictionary<string, T> SqsClients { get; set; } = new Dictionary<string, T>();


	protected ModerationTaskClientBase(ILogger logger, ITaskQueueIdentifierFactory taskQueueIdentifierFactory)
	{
		Logger = logger ?? throw new ArgumentNullException("logger");
		TaskQueueIdentifierFactory = taskQueueIdentifierFactory ?? throw new ArgumentNullException("taskQueueIdentifierFactory");
	}

	internal virtual void ResetQueueSettings(IEnumerable<string> queueSettingsStrings)
	{
		ICollection<SqsQueueSetting> sqsQueueSettings = ParseSqsQueueSettingsFromString(queueSettingsStrings);
		if (sqsQueueSettings != null)
		{
			ResetSqsClients(sqsQueueSettings);
		}
	}

	private void ResetSqsClients(ICollection<SqsQueueSetting> sqsQueueSettings)
	{
		IDictionary<string, T> oldClients = null;
		lock (_SqsLock)
		{
			IDictionary<string, T> newClients = InitializeSqsClients(sqsQueueSettings);
			oldClients = SqsClients;
			SqsClients = newClients;
		}
		ClearSqsClients(oldClients);
	}

	internal virtual ICollection<SqsQueueSetting> ParseSqsQueueSettingsFromString(IEnumerable<string> queueSettingsStrings)
	{
		List<SqsQueueSetting> allSettings = new List<SqsQueueSetting>();
		foreach (string queueSettingsString in queueSettingsStrings)
		{
			ICollection<SqsQueueSetting> settings;
			try
			{
				settings = JsonConvert.DeserializeObject<ICollection<SqsQueueSetting>>(queueSettingsString) ?? new List<SqsQueueSetting>();
			}
			catch (Exception e)
			{
				Logger.Error(e);
				return null;
			}
			allSettings.AddRange(settings);
		}
		return allSettings;
	}

	internal virtual IDictionary<string, T> InitializeSqsClients(ICollection<SqsQueueSetting> sqsQueueSettings)
	{
		Dictionary<string, T> newSqsClients = new Dictionary<string, T>();
		foreach (SqsQueueSetting sqsQueueSetting in sqsQueueSettings)
		{
			ConstructAndAddSqsClient(sqsQueueSetting, newSqsClients);
		}
		return newSqsClients;
	}

	internal abstract void ConstructAndAddSqsClient(SqsQueueSetting sqsQueueSetting, IDictionary<string, T> newSqsClients);

	internal virtual T GetSqsClient(ITaskQueueIdentifier queueIdentifier)
	{
		string key = queueIdentifier.GetKey();
		if (!SqsClients.TryGetValue(key, out var sqsClient))
		{
			string errorMessage = string.Format("{0}: Can not find the {1} for key {2}.", GetType().Name, "sqsClient", key);
			Logger.Error(errorMessage);
			return default(T);
		}
		return sqsClient;
	}

	internal virtual string GetKey(SqsQueueSetting sqsQueueSetting)
	{
		return TaskQueueIdentifierFactory.Create(sqsQueueSetting).GetKey();
	}

	internal virtual void ClearSqsClients(IDictionary<string, T> oldClients)
	{
		oldClients?.Clear();
	}
}
