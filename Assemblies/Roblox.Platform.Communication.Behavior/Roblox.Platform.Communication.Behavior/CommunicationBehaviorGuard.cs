using System;
using System.Linq;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Communication.Behavior.EventStreaming;
using Roblox.Platform.Communication.Behavior.Properties;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Infractions;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Communication.Behavior;

public class CommunicationBehaviorGuard : ICommunicationBehaviorGuard
{
	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly ICommunicationBehaviorEventStreamer _EventStreamer;

	private readonly ILogger _Logger;

	private readonly ICommunicationBehaviorRules _CommunicationBehaviorRules;

	private readonly IInfractionTracker<IClientTextAuthor> _PiiInfractionTracker;

	private const string _PiiInfractionTopic = "Pii";

	public CommunicationBehaviorGuard(ICounterRegistry counterRegistry, ITextFilterClientV2 textFilterClientV2, IEventStreamer eventStreamer, ILogger logger)
		: this(textFilterClientV2, logger, new CommunicationBehaviorEventStreamer(eventStreamer), new CommunicationBehaviorRules(), new InfractionTracker<IClientTextAuthor>(counterRegistry, "Pii", GetPiiInfractionSpec(), (IClientTextAuthor ta) => ta.Id, logger))
	{
	}

	internal CommunicationBehaviorGuard(ITextFilterClientV2 textFilterClientV2, ILogger logger, ICommunicationBehaviorEventStreamer eventStreamer, ICommunicationBehaviorRules communicationBehaviorRules, IInfractionTracker<IClientTextAuthor> piiInfractionTracker)
	{
		_TextFilterClientV2 = textFilterClientV2;
		_EventStreamer = eventStreamer;
		_Logger = logger;
		_CommunicationBehaviorRules = communicationBehaviorRules;
		_PiiInfractionTracker = piiInfractionTracker;
	}

	public IGuardedFilterTextResult FilterText(FilterLiveTextRequest filterLiveTextRequest, bool isRevalidation)
	{
		if (isRevalidation)
		{
			return new GuardedFilterTextResult(_TextFilterClientV2.FilterLiveText(filterLiveTextRequest.Text, filterLiveTextRequest.Author, filterLiveTextRequest.TextUsage, filterLiveTextRequest.Server, filterLiveTextRequest.InstanceIdentifier), CommunicationBehaviorGuardStatus.Unenforced);
		}
		if (_CommunicationBehaviorRules.IsBanEnforced() && SafelyExecute(() => _PiiInfractionTracker.ShouldConsequencesBeEnforced(filterLiveTextRequest.Author), fallback: false))
		{
			return new GuardedFilterTextResult(null, CommunicationBehaviorGuardStatus.FailedAlreadyBanned);
		}
		CommunicationBehaviorGuardStatus behaviorGuardStatus = CommunicationBehaviorGuardStatus.Ok;
		FilterLiveTextResult filterLiveTextResult = _TextFilterClientV2.FilterLiveText(filterLiveTextRequest.Text, filterLiveTextRequest.Author, filterLiveTextRequest.TextUsage, filterLiveTextRequest.Server, filterLiveTextRequest.InstanceIdentifier);
		try
		{
			FilterTextResult relevantRuleResult = _CommunicationBehaviorRules.GetRelevantRuleResult(filterLiveTextRequest, filterLiveTextResult);
			if (_CommunicationBehaviorRules.IsUnacceptableBehavior(relevantRuleResult))
			{
				if (_CommunicationBehaviorRules.IsInfractionTrackingEnabled())
				{
					behaviorGuardStatus = CommunicationBehaviorGuardStatus.FailedWithWarning;
					if (_PiiInfractionTracker.RecordInfraction(filterLiveTextRequest.Author))
					{
						behaviorGuardStatus = CommunicationBehaviorGuardStatus.FailedWithBanning;
					}
				}
				RecordEvent(filterLiveTextRequest, relevantRuleResult);
			}
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
		return new GuardedFilterTextResult(filterLiveTextResult, behaviorGuardStatus);
	}

	private void RecordEvent(FilterLiveTextRequest filterLiveTextRequest, FilterTextResult filterTextResult)
	{
		if (_CommunicationBehaviorRules.IsEventStreamLoggingEnabled(filterLiveTextRequest))
		{
			UndesirableCommunicationBehaviorEventArgs eventArgs = new UndesirableCommunicationBehaviorEventArgs
			{
				Target = EventTarget.Www,
				UserId = filterLiveTextRequest.Author.Id,
				IsUnder13 = filterLiveTextRequest.Author.IsUnder13,
				Source = filterLiveTextRequest.TextUsage,
				Reasons = string.Join(",", filterTextResult.TriggeredModerationCategories.Select((int x) => (ModerationCategory)x).ToArray()),
				IsFullyModerated = (filterTextResult.ModerationLevel == 3)
			};
			_EventStreamer.Stream(eventArgs);
		}
	}

	private static IInfractionTrackerSpec GetPiiInfractionSpec()
	{
		return new InfractionTrackerSpec
		{
			InfractionConsequenceThreshold = () => Settings.Default.PiiInfractionLimit,
			InfractionConsequenceTimespan = () => Settings.Default.PiiInfractionTimespan,
			InfractionConsequenceEnforcementTimespan = () => Settings.Default.PiiBanTimespan,
			GlobalEnforcementLimit = () => Settings.Default.PiiGlobalBanLimit,
			GlobalEnforcementLimitTimespan = () => Settings.Default.PiiGlobalBanLimitTimespan,
			ResetInfractionCountWhenConsequencesEnforced = () => true
		};
	}

	private T SafelyExecute<T>(Func<T> func, T fallback)
	{
		try
		{
			return func();
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
			return fallback;
		}
	}
}
