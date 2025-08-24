using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Moderation.Properties;
using Roblox.TrackingQueue;

namespace Roblox.Platform.Moderation;

internal class ModerationQueueMetrics : ModerationTaskClientBase<IDictionary<string, ITrackingQueueMetrics>>, IModerationQueueMetrics
{
	private readonly ISqsSettings _Settings;

	private readonly ITrackingQueueMetricsFactory _TrackingQueueMetricsFactory;

	private readonly ModerationTaskType _ModerationTaskType;

	internal ModerationQueueMetrics(ILogger logger, ISqsSettings settings, ITrackingQueueMetricsFactory trackingQueueMetricsFactory, ModerationTaskType moderationTaskType, ITaskQueueIdentifierFactory taskQueueIdentifierFactory)
		: base(logger, taskQueueIdentifierFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_TrackingQueueMetricsFactory = trackingQueueMetricsFactory ?? throw new ArgumentNullException("trackingQueueMetricsFactory");
		_ModerationTaskType = moderationTaskType;
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

	internal override void ConstructAndAddSqsClient(SqsQueueSetting sqsQueueSetting, IDictionary<string, IDictionary<string, ITrackingQueueMetrics>> newSqsClients)
	{
		if (sqsQueueSetting.ModerationTaskType == _ModerationTaskType)
		{
			string key = GetKey(sqsQueueSetting);
			ITrackingQueueMetrics trackingQueueMetrics = _TrackingQueueMetricsFactory.Create(key);
			string localeKey = sqsQueueSetting.LocaleId.ToString();
			string priorityKey = ((int)sqsQueueSetting.Priority).ToString();
			if (newSqsClients.TryGetValue(localeKey, out var queueMetricses))
			{
				queueMetricses[priorityKey] = trackingQueueMetrics;
				return;
			}
			Dictionary<string, ITrackingQueueMetrics> newQueueMetricses = new Dictionary<string, ITrackingQueueMetrics> { { priorityKey, trackingQueueMetrics } };
			newSqsClients.Add(localeKey, newQueueMetricses);
		}
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueMetrics.GetTotalNumberOfOpenTasks" />
	/// </summary>
	public long GetTotalNumberOfOpenTasks()
	{
		return SqsClients.Values.Sum((IDictionary<string, ITrackingQueueMetrics> queueMetricses) => queueMetricses.Values.Sum((ITrackingQueueMetrics trackingQueueMetrics) => trackingQueueMetrics.GetNumberOfItemsInQueue()));
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueMetrics.GetTotalNumberOfOpenTasksByLocale(System.Int32)" />
	/// </summary>
	public long GetTotalNumberOfOpenTasksByLocale(int localeId)
	{
		string localeKey = localeId.ToString();
		if (SqsClients.TryGetValue(localeKey, out var queueMetricses))
		{
			return queueMetricses.Values.Sum((ITrackingQueueMetrics trackingQueueMetrics) => trackingQueueMetrics.GetNumberOfItemsInQueue());
		}
		throw new ArgumentException($"The metrics for {localeId} is not supported");
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueMetrics.GetTotalNumberOfActiveModerators" />
	/// </summary>
	public long GetTotalNumberOfActiveModerators()
	{
		return SqsClients.Values.Sum((IDictionary<string, ITrackingQueueMetrics> queueMetricses) => queueMetricses.Values.Sum((ITrackingQueueMetrics trackingQueueMetrics) => trackingQueueMetrics.GetNumberOfQueueWorkers()));
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueMetrics.GetTotalNumberOfActiveModeratorsByLocale(System.Int32)" />
	/// </summary>
	public long GetTotalNumberOfActiveModeratorsByLocale(int localeId)
	{
		string localeKey = localeId.ToString();
		if (SqsClients.TryGetValue(localeKey, out var queueMetricses))
		{
			return queueMetricses.Values.Sum((ITrackingQueueMetrics trackingQueueMetrics) => trackingQueueMetrics.GetNumberOfQueueWorkers());
		}
		throw new ArgumentException($"The metrics for {localeId} is not supported");
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueMetrics.GetAgeOfOldestOpenTaskInSeconds" />
	/// </summary>
	public int GetAgeOfOldestOpenTaskInSeconds()
	{
		return SqsClients.Values.SelectMany((IDictionary<string, ITrackingQueueMetrics> queueMetricses) => queueMetricses.Values.Select((ITrackingQueueMetrics trackingQueueMetrics) => (int)trackingQueueMetrics.AgeOfOldestItemInQueue().TotalSeconds)).Max();
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueMetrics.GetAgeOfOldestOpenTaskInSecondsByLocale(System.Int32)" />
	/// </summary>
	public int GetAgeOfOldestOpenTaskInSecondsByLocale(int localeId)
	{
		string localeKey = localeId.ToString();
		if (SqsClients.TryGetValue(localeKey, out var queueMetricses))
		{
			return queueMetricses.Values.Select((ITrackingQueueMetrics trackingQueueMetrics) => (int)trackingQueueMetrics.AgeOfOldestItemInQueue().TotalSeconds).Max();
		}
		throw new ArgumentException($"The metrics for {localeId} is not supported");
	}
}
