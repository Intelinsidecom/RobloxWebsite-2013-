using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.UserSetting.Entities;

namespace Roblox.Platform.UserSetting;

internal class UserSettingsFactory : IUserSettingsFactory
{
	private readonly UserSettingDomainFactories _DomainFactories;

	public UserSettingsFactory(UserSettingDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
	}

	public IUserSettings GetUserSettings(IUserIdentifier user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		IUserSettingEntity entity = _DomainFactories.UserSettingEntityFactory.GetOrCreate(user.Id);
		return new UserSettings(_DomainFactories, user, entity);
	}
}
