using Roblox.TextFilter.Client;

namespace Roblox.Platform.Communication.Behavior;

/// <summary>
/// Guard to check that users are communicating in a safe way. Performs additional checks and logic in 
/// addition to calling into the standard text filter. Will prevent users from communicating if they
/// are deemed to be in breach of our standards
/// </summary>
public interface ICommunicationBehaviorGuard
{
	/// <summary>
	/// Filter text through our standard TextFilter and also check for patterns
	/// of bad behavior
	/// </summary>
	/// <param name="filterLiveTextRequest"></param>
	/// <param name="isRevalidation">Is this re-running text previously submitted. 
	/// If true, this call will not cause any consequences for the author</param>
	/// <returns></returns>
	IGuardedFilterTextResult FilterText(FilterLiveTextRequest filterLiveTextRequest, bool isRevalidation);
}
