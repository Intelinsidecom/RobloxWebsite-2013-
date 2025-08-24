using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.UserSetting.Entities;

[ExcludeFromCodeCoverage]
internal class UserSettingCachedMssqlEntity : IUserSettingEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long UserId { get; set; }

	public bool CuratedGamesOnlyIsEnabled { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		UserSetting cal = UserSetting.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.UserID = UserId;
		cal.CuratedGamesOnlyIsEnabled = CuratedGamesOnlyIsEnabled;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(UserSetting.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
