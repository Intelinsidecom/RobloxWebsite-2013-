using Roblox.TextFilter.Client;

namespace Roblox.Platform.Communication.Behavior;

internal class GuardedFilterTextResult : IGuardedFilterTextResult
{
	public CommunicationBehaviorGuardStatus Status { get; }

	public FilterLiveTextResult FilterLiveTextResult { get; }

	public GuardedFilterTextResult(FilterLiveTextResult filterLiveTextResult, CommunicationBehaviorGuardStatus status)
	{
		FilterLiveTextResult = filterLiveTextResult;
		Status = status;
	}
}
