using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.UserSetting.Properties;

namespace Roblox.Platform.UserSetting;

internal class UserSettingsValidator : IUserSettingsValidator
{
	private readonly UserSettingDomainFactories _DomainFactories;

	internal virtual bool CuratedContentOnlyIsEnabled => Settings.Default.CuratedContentOnlyIsEnabled;

	internal virtual bool CuratedContentOnlySoothsayersEnabled => Settings.Default.CuratedContentOnlySoothsayersEnabled;

	public UserSettingsValidator(UserSettingDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
	}

	public bool IsUserConfiguredForCuratedContentOnly(IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (CuratedContentOnlySoothsayersEnabled && _DomainFactories.RoleSetValidator.IsSoothsayer(user))
		{
			return _DomainFactories.UserSettingsFactory.GetUserSettings(user).CuratedGamesOnlyIsEnabled;
		}
		if (!CuratedContentOnlyIsEnabled)
		{
			return false;
		}
		return _DomainFactories.UserSettingsFactory.GetUserSettings(user).CuratedGamesOnlyIsEnabled;
	}

	public bool CuratedContentOnlyIsActive(IUser user)
	{
		if (CuratedContentOnlySoothsayersEnabled && _DomainFactories.RoleSetValidator.IsSoothsayer(user))
		{
			return true;
		}
		if (!CuratedContentOnlyIsEnabled)
		{
			return false;
		}
		return true;
	}
}
