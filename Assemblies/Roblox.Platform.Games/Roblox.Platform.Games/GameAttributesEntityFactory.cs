using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Games.Entities;

namespace Roblox.Platform.Games;

internal class GameAttributesEntityFactory : IGameAttributesEntityFactory, IDomainFactory<GamesDomainFactories>, IDomainObject<GamesDomainFactories>
{
	public GamesDomainFactories DomainFactories { get; }

	public GameAttributesEntityFactory(GamesDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IGameAttributesEntity Get(long id)
	{
		return CalToCachedMssql(Roblox.Platform.Games.Entities.GameAttributes.Get(id));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributesEntityFactory.GetByUniverseId(System.Int64)" />
	public IGameAttributesEntity GetByUniverseId(long universeId)
	{
		if (universeId <= 0)
		{
			throw new PlatformArgumentException("universeId");
		}
		return CalToCachedMssql(Roblox.Platform.Games.Entities.GameAttributes.GetByUniverseID(universeId));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributesEntityFactory.GetOrCreate(System.Int64)" />
	public IGameAttributesEntity GetOrCreate(long universeId)
	{
		if (universeId <= 0)
		{
			throw new PlatformArgumentException("universeId");
		}
		return CalToCachedMssql(Roblox.Platform.Games.Entities.GameAttributes.GetOrCreate(universeId));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributesEntityFactory.GetByIsTrustedEnumerative(System.Boolean,System.Int64,System.Int32,Roblox.DataV2.Core.SortOrder)" />
	public IEnumerable<IGameAttributesEntity> GetByIsTrustedEnumerative(bool isTrusted, long exclusiveStartUniverseId, int count, SortOrder sortOrder)
	{
		if (count <= 0)
		{
			throw new PlatformArgumentException("count");
		}
		return Roblox.Platform.Games.Entities.GameAttributes.GetGameAttributesByIsTrusted(isTrusted, exclusiveStartUniverseId, count, sortOrder).Select(CalToCachedMssql);
	}

	private static IGameAttributesEntity CalToCachedMssql(Roblox.Platform.Games.Entities.GameAttributes cal)
	{
		if (cal != null)
		{
			return new GameAttributesCachedMssqlEntity
			{
				Id = cal.ID,
				UniverseId = cal.UniverseID,
				IsSecure = cal.IsSecure,
				IsTrusted = cal.IsTrusted,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
