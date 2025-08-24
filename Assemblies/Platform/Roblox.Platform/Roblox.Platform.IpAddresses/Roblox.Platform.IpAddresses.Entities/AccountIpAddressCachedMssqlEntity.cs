using System;
using Roblox.Entities;
using Roblox.Platform.IpAddresses.Properties;

namespace Roblox.Platform.IpAddresses.Entities;

internal class AccountIpAddressCachedMssqlEntity : IAccountIpAddressEntity, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public long IpAddressId { get; set; }

	public DateTime Created { get; set; }

	public DateTime? LastSeen { get; set; }

	public void Delete()
	{
		(AccountIPAddressV2.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public void RecordSeen()
	{
		if (IsLastSeenEnabled())
		{
			DateTime utcNow = DateTime.UtcNow;
			if (!LastSeen.HasValue || utcNow - LastSeen.Value >= GetMinTimeSpanBetweenUpdatesForLastSeen())
			{
				DoRecordSeen(utcNow);
			}
		}
	}

	internal virtual void DoRecordSeen(DateTime utcNow)
	{
		AccountIPAddressV2 cal = AccountIPAddressV2.Get(Id);
		cal.LastSeen = utcNow;
		cal.Save();
		LastSeen = cal.LastSeen;
	}

	internal virtual TimeSpan GetMinTimeSpanBetweenUpdatesForLastSeen()
	{
		return Settings.Default.MinTimeSpanBetweenUpdatesForLastSeen;
	}

	internal virtual bool IsLastSeenEnabled()
	{
		return AccountId % 100 < Settings.Default.LastSeenRolloutPercentage;
	}
}
