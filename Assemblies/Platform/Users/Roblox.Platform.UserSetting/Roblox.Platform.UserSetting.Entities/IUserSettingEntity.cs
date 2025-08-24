using Roblox.Entities;

namespace Roblox.Platform.UserSetting.Entities;

internal interface IUserSettingEntity : IUpdateableEntity<long>, IEntity<long>
{
	long UserId { get; set; }

	bool CuratedGamesOnlyIsEnabled { get; set; }
}
