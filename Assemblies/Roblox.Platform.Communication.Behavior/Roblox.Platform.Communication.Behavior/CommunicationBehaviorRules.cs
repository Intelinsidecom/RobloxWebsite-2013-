using System.Collections.Generic;
using Roblox.Platform.Communication.Behavior.Properties;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Communication.Behavior;

internal class CommunicationBehaviorRules : ICommunicationBehaviorRules
{
	private readonly ISettings _Settings;

	public CommunicationBehaviorRules()
		: this(Settings.Default)
	{
	}

	internal CommunicationBehaviorRules(ISettings settings)
	{
		_Settings = settings;
	}

	public bool IsUnacceptableBehavior(FilterTextResult filterTextResult)
	{
		ICollection<int> triggeredModerationCategories = filterTextResult.TriggeredModerationCategories;
		if (triggeredModerationCategories != null && triggeredModerationCategories.Contains(4))
		{
			return true;
		}
		return false;
	}

	public FilterTextResult GetRelevantRuleResult(FilterLiveTextRequest filterLiveTextRequest, FilterLiveTextResult filterLiveTextResult)
	{
		if (filterLiveTextRequest.Author == null || filterLiveTextResult == null)
		{
			return null;
		}
		if (filterLiveTextRequest.Author.IsUnder13)
		{
			return filterLiveTextResult.FilteredResultUnderage;
		}
		return filterLiveTextResult.FilteredResult;
	}

	public bool IsEventStreamLoggingEnabled(FilterLiveTextRequest filterLiveTextRequest)
	{
		if (filterLiveTextRequest.Author != null)
		{
			return filterLiveTextRequest.Author.Id % 100 < _Settings.EventStreamLoggingUserPercentage;
		}
		return false;
	}

	public bool IsBanEnforced()
	{
		return _Settings.IsPiiBanEnforced;
	}

	public bool IsInfractionTrackingEnabled()
	{
		return _Settings.IsPiiInfractionTrackingEnabled;
	}
}
