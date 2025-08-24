using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Marketing.BLL;

namespace Roblox.Platform.Marketing;

[ExcludeFromCodeCoverage]
internal class AccountBrowserTrackerCachedMssqlEntity : IAccountBrowserTrackerEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public long BrowserTrackerId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		AccountBrowserTracker cal = AccountBrowserTracker.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountID = AccountId;
		cal.BrowserTrackerID = BrowserTrackerId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountBrowserTracker.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
