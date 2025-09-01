using System;
namespace Roblox.Moderation.Interfaces {
    public interface IInGameAdvertisingBan

{
	bool IsDeveloperBanned(long userId);

	DateTime? GetBanExpirationDate(long userId);

	void BanUser(long userId, TimeSpan? timeSpan);

	void UnbanUser(long userId);
}


}
