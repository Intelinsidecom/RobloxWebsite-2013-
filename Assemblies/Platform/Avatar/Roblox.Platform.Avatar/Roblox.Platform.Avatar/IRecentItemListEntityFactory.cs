using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal interface IRecentItemListEntityFactory : IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	IRecentItemListEntity Get(long id);

	IRecentItemListEntity GetOrCreate(long userId, byte recentItemListTypeId);
}
