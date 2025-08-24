using Roblox.Platform.Core;

namespace Roblox.Platform.Social.Follow;

internal interface IUserFollowPrivacySettingEntityFactory : IDomainFactory<FollowDomainFactories>, IDomainObject<FollowDomainFactories>
{
	IUserFollowPrivacySettingEntity Get(long id);

	IUserFollowPrivacySettingEntity GetOrCreate(long userId, byte defaultPrivacyTypeId);
}
