using System;
using Roblox.Marketing.BLL;

namespace Roblox.Platform.Marketing;

public class BrowserTrackerFactory : IBrowserTrackerFactory
{
	/// <summary>
	/// Occurs when a new BrowserTracker is created.
	/// </summary>
	public static event Action<string> OnBrowserTrackerCreated;

	private IBrowserTracker GetBrowserTracker(Roblox.Marketing.BLL.BrowserTracker browserTrackerEntity)
	{
		if (browserTrackerEntity == null)
		{
			throw new UnknownBrowserTrackerException();
		}
		return new BrowserTracker(browserTrackerEntity.ID, browserTrackerEntity.Created, browserTrackerEntity.Updated);
	}

	public IBrowserTracker CreateNew(string requestUrl = null, long? accountId = null)
	{
		Roblox.Marketing.BLL.BrowserTracker browserTrackerEntity = Roblox.Marketing.BLL.BrowserTracker.CreateNew();
		if (BrowserTrackerFactory.OnBrowserTrackerCreated != null && requestUrl != null)
		{
			BrowserTrackerFactory.OnBrowserTrackerCreated(requestUrl);
		}
		if (accountId.HasValue)
		{
			AccountBrowserTracker.GetOrCreate(accountId.Value, browserTrackerEntity.ID).Save();
		}
		return GetBrowserTracker(browserTrackerEntity);
	}

	public IBrowserTracker Get(long id)
	{
		return GetBrowserTracker(Roblox.Marketing.BLL.BrowserTracker.Get(id));
	}
}
