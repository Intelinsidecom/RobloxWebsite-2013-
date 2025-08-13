using System;
using Roblox.Platform.Moderation.Interfaces;

namespace Roblox.Platform.Moderation.Factories;

public class InGameAdvertisingBanFactory : IInGameAdvertisingBan
{
	public bool IsDeveloperBanned(long userId)
	{
		InGameAdvertisingBan ban = InGameAdvertisingBan.GetByUserID(userId);
		if (ban != null)
		{
			if (ban.Expiration.HasValue)
			{
				return ban.Expiration.Value > DateTime.Now;
			}
			return true;
		}
		return false;
	}

	public DateTime? GetBanExpirationDate(long userId)
	{
		InGameAdvertisingBan ban = InGameAdvertisingBan.GetByUserID(userId);
		if (ban != null && ban.Expiration.HasValue)
		{
			return ban.Expiration;
		}
		return null;
	}

	public void BanUser(long userId, TimeSpan? timeSpan = null)
	{
		InGameAdvertisingBan ban = InGameAdvertisingBan.GetByUserID(userId);
		DateTime? banEnd = (timeSpan.HasValue ? new DateTime?(DateTime.Now.Add(timeSpan.Value)) : null);
		if (ban == null)
		{
			InGameAdvertisingBan.CreateNew(userId, banEnd);
			return;
		}
		ban.Expiration = banEnd;
		ban.Save();
	}

	public void UnbanUser(long userId)
	{
		InGameAdvertisingBan ban = InGameAdvertisingBan.GetByUserID(userId);
		if (ban != null)
		{
			ban.Expiration = DateTime.Now;
			ban.Save();
		}
	}
}
