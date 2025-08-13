using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

public class BrowserTrackerDetailProvider : IBrowserTrackerDetailProvider
{
	private IAccountBrowserTrackerEntityFactory _Factory;

	public BrowserTrackerDetailProvider()
	{
		_Factory = new AccountBrowserTrackerEntityFactory();
	}

	public bool IsAccountAssociated(IBrowserTracker browserTracker, IUser user)
	{
		if (browserTracker == null || user == null)
		{
			return false;
		}
		return _Factory.GetByAccountIdAndBrowserTrackerId(user.AccountId, browserTracker.Id) != null;
	}
}
