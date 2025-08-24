using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

[ExcludeFromCodeCoverage]
internal class EmoteConfigurationEntityFactory : IEmoteConfigurationEntityFactory, IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	public AvatarDomainFactories DomainFactories { get; }

	public EmoteConfigurationEntityFactory(AvatarDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IEmoteConfigurationEntity Get(long id)
	{
		return CalToCachedMssql(EmoteConfigurationEntity.Get(id));
	}

	public IEmoteConfigurationEntity GetByUserIdAndPosition(long userId, byte position)
	{
		return CalToCachedMssql(EmoteConfigurationEntity.GetByUserIDAndPosition(userId, position));
	}

	public ICollection<IEmoteConfigurationEntity> GetByUserIdEnumerative(long userId, int count, byte? exclusiveStartPosition = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return EmoteConfigurationEntity.GetEmoteConfigurationsByUserID(userId, count, exclusiveStartPosition).Select(CalToCachedMssql).ToArray();
	}

	public IEmoteConfigurationEntity CreateOrUpdate(long userId, long assetId, byte position)
	{
		if (userId < 1)
		{
			throw new ArgumentException("User Id must be positive");
		}
		if (assetId < 1)
		{
			throw new ArgumentException("Asset Id must be positive");
		}
		if (position < 1)
		{
			throw new ArgumentException("Position must be positive");
		}
		EmoteConfigurationEntity existingConfiguration = EmoteConfigurationEntity.GetByUserIDAndPosition(userId, position);
		if (existingConfiguration != null)
		{
			existingConfiguration.AssetID = assetId;
			existingConfiguration.Save();
			return CalToCachedMssql(existingConfiguration);
		}
		EmoteConfigurationEntity emoteConfigurationEntity = new EmoteConfigurationEntity();
		emoteConfigurationEntity.AssetID = assetId;
		emoteConfigurationEntity.UserID = userId;
		emoteConfigurationEntity.Position = position;
		emoteConfigurationEntity.Save();
		return CalToCachedMssql(emoteConfigurationEntity);
	}

	public void Delete(long userId, byte position)
	{
		EmoteConfigurationEntity.GetByUserIDAndPosition(userId, position)?.Delete();
	}

	private static IEmoteConfigurationEntity CalToCachedMssql(EmoteConfigurationEntity cal)
	{
		if (cal != null)
		{
			return new EmoteConfigurationCachedMssqlEntity
			{
				Id = cal.ID,
				AssetId = cal.AssetID,
				UserId = cal.UserID,
				Position = cal.Position,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
