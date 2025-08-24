using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

public interface IBrowserTrackerDetailProvider
{
	bool IsAccountAssociated(IBrowserTracker browserTracker, IUser user);
}
