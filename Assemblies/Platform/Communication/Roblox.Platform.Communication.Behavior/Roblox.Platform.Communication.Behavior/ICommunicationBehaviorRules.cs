using Roblox.TextFilter.Client;

namespace Roblox.Platform.Communication.Behavior;

internal interface ICommunicationBehaviorRules
{
	bool IsUnacceptableBehavior(FilterTextResult filterTextResult);

	FilterTextResult GetRelevantRuleResult(FilterLiveTextRequest filterLiveTextRequest, FilterLiveTextResult filterLiveTextResult);

	bool IsEventStreamLoggingEnabled(FilterLiveTextRequest filterLiveTextRequest);

	bool IsBanEnforced();

	bool IsInfractionTrackingEnabled();
}
