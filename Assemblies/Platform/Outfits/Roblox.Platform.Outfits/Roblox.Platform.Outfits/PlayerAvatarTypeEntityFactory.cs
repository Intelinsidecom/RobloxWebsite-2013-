using Roblox.Common;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

public class PlayerAvatarTypeEntityFactory : IPlayerAvatarTypeEntityFactory, IDomainFactory<OutfitDomainFactories>, IDomainObject<OutfitDomainFactories>
{
	public OutfitDomainFactories DomainFactories { get; }

	public PlayerAvatarTypeEntityFactory(OutfitDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IPlayerAvatarTypeEntity Get(byte id)
	{
		return CalToCachedMssql(PlayerAvatarTypeEntity.Get(id));
	}

	public IPlayerAvatarTypeEntity GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		if (!EnumUtils.StrictTryParseEnum<PlayerAvatarType>(value).HasValue)
		{
			return null;
		}
		return CalToCachedMssql(PlayerAvatarTypeEntity.GetByValue(value));
	}

	private static IPlayerAvatarTypeEntity CalToCachedMssql(PlayerAvatarTypeEntity cal)
	{
		if (cal != null)
		{
			return new PlayerAvatarTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
