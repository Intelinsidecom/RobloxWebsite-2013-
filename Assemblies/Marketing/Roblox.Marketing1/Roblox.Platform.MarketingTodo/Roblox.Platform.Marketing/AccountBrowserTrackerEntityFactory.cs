using System.Diagnostics.CodeAnalysis;
using Roblox.Marketing.BLL;

namespace Roblox.Platform.Marketing;

[ExcludeFromCodeCoverage]
internal class AccountBrowserTrackerEntityFactory : IAccountBrowserTrackerEntityFactory
{
	public IAccountBrowserTrackerEntity GetByAccountIdAndBrowserTrackerId(long accountId, long browserTrackerId)
	{
		return CalToCachedMssql(AccountBrowserTracker.GetByAccountIDAndBrowserTrackerID(accountId, browserTrackerId));
	}

	private static IAccountBrowserTrackerEntity CalToCachedMssql(AccountBrowserTracker cal)
	{
		if (cal != null)
		{
			return new AccountBrowserTrackerCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				BrowserTrackerId = cal.BrowserTrackerID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
