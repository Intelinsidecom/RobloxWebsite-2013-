using Roblox.Platform.MembershipCore;
using Roblox.Platform.UserSetting.Entities;

namespace Roblox.Platform.UserSetting;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Platform.UserSetting.IUserSettings" />
/// </summary>
internal class UserSettings : IUserSettings
{
	private readonly UserSettingDomainFactories _DomainFactories;

	private readonly IUserIdentifier _User;

	private IUserSettingEntity _Entity;

	public bool CuratedGamesOnlyIsEnabled => _Entity.CuratedGamesOnlyIsEnabled;

	public UserSettings(UserSettingDomainFactories domainFactories, IUserIdentifier user, IUserSettingEntity entity)
	{
		_DomainFactories = domainFactories;
		_User = user;
		_Entity = entity;
	}

	public void UpdateCuratedGamesOnlyIsEnabled(bool value)
	{
		IUserSettingEntity entity = _DomainFactories.UserSettingEntityFactory.GetOrCreate(_User.Id);
		entity.CuratedGamesOnlyIsEnabled = value;
		entity.Update();
		_Entity = entity;
	}
}
