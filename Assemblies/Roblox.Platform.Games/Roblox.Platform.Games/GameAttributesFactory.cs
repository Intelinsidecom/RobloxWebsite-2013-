using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <inheritdoc cref="T:Roblox.Platform.Games.IGameAttributesFactory" />
internal class GameAttributesFactory : IGameAttributesFactory
{
	private readonly GamesDomainFactories _GamesDomainFactories;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly ILogger _Logger;

	internal virtual bool IsPlaceAttributesReadyToEvaluateIsSecure => Settings.Default.IsPlaceAttributesReadyToEvaluateIsSecure;

	public GameAttributesFactory(GamesDomainFactories gamesDomainFactories, IUniverseFactory universeFactory, ILogger logger)
	{
		_GamesDomainFactories = gamesDomainFactories.AssignOrThrowIfNull("gamesDomainFactories");
		_UniverseFactory = universeFactory.AssignOrThrowIfNull("universeFactory");
		_Logger = logger;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributesFactory.GetGameAttributes(Roblox.Platform.Universes.IUniverse)" />
	public IGameAttributes GetGameAttributes(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		IGameAttributesEntity entity = _GamesDomainFactories.GameAttributesEntityFactory.GetByUniverseId(universe.Id);
		if (entity == null)
		{
			return null;
		}
		return new GameAttributes(entity, _GamesDomainFactories);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributesFactory.GetOrCreateGameAttributes(Roblox.Platform.Universes.IUniverse)" />
	public IGameAttributes GetOrCreateGameAttributes(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		IGameAttributesEntity entity = _GamesDomainFactories.GameAttributesEntityFactory.GetOrCreate(universe.Id);
		if (entity.Created == entity.Updated)
		{
			InitializeIsSecured(universe, entity);
		}
		return new GameAttributes(entity, _GamesDomainFactories);
	}

	private void InitializeIsSecured(IUniverse universe, IGameAttributesEntity entity)
	{
		bool hasAnyNonFilteringEnabledPlaces = _GamesDomainFactories.GamePlacesManager.IsAnyPlaceInUniverseNotFilteringEnabled(universe);
		if (IsPlaceAttributesReadyToEvaluateIsSecure && !hasAnyNonFilteringEnabledPlaces)
		{
			entity.IsSecure = true;
		}
		else
		{
			entity.IsSecure = false;
		}
		entity.Update();
	}

	public IPlatformPageResponse<long, IUniverse> GetTrustedGames(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		SortOrder sortOrder = exclusiveStartKeyInfo.GetDatabaseRequestSortOrder();
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		IEnumerable<IGameAttributesEntity> entities = _GamesDomainFactories.GameAttributesEntityFactory.GetByIsTrustedEnumerative(isTrusted: true, exclusiveStartId, exclusiveStartKeyInfo.Count + 1, sortOrder);
		IUniverse[] universes;
		if (Settings.Default.IsGetUniversesUpdateEnabled)
		{
			IEnumerable<long> universeIds = entities.Select((IGameAttributesEntity e) => e.UniverseId);
			universes = _UniverseFactory.GetUniverses(universeIds).ToArray();
		}
		else
		{
			universes = entities.Select((IGameAttributesEntity e) => _UniverseFactory.GetUniverse(e.UniverseId)).ToArray();
		}
		return new PlatformPageResponse<long, IUniverse>(universes, exclusiveStartKeyInfo, (IUniverse u) => u.Id);
	}
}
