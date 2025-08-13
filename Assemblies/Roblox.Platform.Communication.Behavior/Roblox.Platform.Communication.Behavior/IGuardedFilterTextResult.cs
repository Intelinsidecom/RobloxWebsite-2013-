using Roblox.TextFilter.Client;

namespace Roblox.Platform.Communication.Behavior;

/// <summary>
/// Result of filtering text through the CommuincationBehaviorGuard
/// </summary>
public interface IGuardedFilterTextResult
{
	/// <summary>
	/// Results of running the text through our text moderation filters
	/// </summary>
	FilterLiveTextResult FilterLiveTextResult { get; }

	/// <summary>
	/// Additional status indicating whether or not the request is a breach
	/// of our behavior guidelines. NOTE: Even if this status is OK, it does
	/// not imply the text is safe to send, only that it does not incur any 
	/// additional consequences
	/// </summary>
	CommunicationBehaviorGuardStatus Status { get; }
}
