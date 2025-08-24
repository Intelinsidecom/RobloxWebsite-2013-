using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <inheritdoc cref="T:Roblox.Platform.Games.IGameAttributes" />
internal class GameAttributes : IGameAttributes
{
	internal GamesDomainFactories _DomainFactories;

	/// <inheritdoc cref="P:Roblox.Platform.Games.IGameAttributes.UniverseId" />
	public long UniverseId { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Games.IGameAttributes.IsSecure" />
	public bool IsSecure { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Games.IGameAttributes.IsTrusted" />
	public bool IsTrusted { get; set; }

	internal GameAttributes(IGameAttributesEntity gameAttributesEntity, GamesDomainFactories domainFactories)
	{
		UniverseId = gameAttributesEntity.UniverseId;
		IsSecure = gameAttributesEntity.IsSecure;
		IsTrusted = gameAttributesEntity.IsTrusted;
		_DomainFactories = domainFactories;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributes.SetIsSecure(System.Boolean)" />
	public void SetIsSecure(bool isSecure)
	{
		IGameAttributesEntity entity = _DomainFactories.GameAttributesEntityFactory.GetOrCreate(UniverseId);
		if (entity.IsSecure != isSecure)
		{
			entity.IsSecure = isSecure;
			entity.Update();
			IsSecure = isSecure;
			IUniverse universe = _DomainFactories.UniverseFactory.GetUniverse(UniverseId);
			PublishGameUpdated(universe.RootPlaceId);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Games.IGameAttributes.SetIsTrusted(System.Boolean)" />
	public void SetIsTrusted(bool isTrusted)
	{
		IGameAttributesEntity entity = _DomainFactories.GameAttributesEntityFactory.GetOrCreate(UniverseId);
		if (entity.IsTrusted != isTrusted)
		{
			entity.IsTrusted = isTrusted;
			entity.Update();
			IsTrusted = isTrusted;
			IUniverse universe = _DomainFactories.UniverseFactory.GetUniverse(UniverseId);
			PublishGameUpdated(universe.RootPlaceId);
		}
	}

	private void PublishGameUpdated(long? rootPlaceId)
	{
		if (rootPlaceId.HasValue)
		{
			_DomainFactories.RunningGamesEventPublisher.PublishGameUpdatedEvent(rootPlaceId.Value);
			_DomainFactories.CatalogChangeEventPublisher.Publish(rootPlaceId.Value);
		}
	}
}
