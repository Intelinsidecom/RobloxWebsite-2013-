using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

internal class GameWithUniverseAndRootPlaceFactory : IGameWithUniverseAndRootPlaceFactory
{
	private readonly GamesDomainFactories _DomainFactories;

	public GameWithUniverseAndRootPlaceFactory(GamesDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
	}

	public IGameWithUniverseAndRootPlace Get(IUniverse universe)
	{
		if (universe == null || !universe.RootPlaceId.HasValue)
		{
			return null;
		}
		IPlace rootPlace = _DomainFactories.PlaceFactory.Get(universe.RootPlaceId.Value);
		if (rootPlace == null)
		{
			return null;
		}
		return new GameWithUniverseAndRootPlace(_DomainFactories, universe, rootPlace);
	}

	public IGameWithUniverseAndRootPlace GetByRootPlace(IPlace rootPlace)
	{
		if (rootPlace == null)
		{
			return null;
		}
		IUniverse universe = _DomainFactories.UniverseFactory.GetPlaceUniverse(rootPlace);
		if (universe?.RootPlaceId != rootPlace.Id)
		{
			return null;
		}
		return new GameWithUniverseAndRootPlace(_DomainFactories, universe, rootPlace);
	}

	public IGameWithUniverseAndRootPlace GetByPlace(IPlace place)
	{
		if (place == null)
		{
			return null;
		}
		IUniverse universe = _DomainFactories.UniverseFactory.GetPlaceUniverse(place);
		if (universe == null)
		{
			return null;
		}
		if (universe.RootPlaceId == place.Id)
		{
			return new GameWithUniverseAndRootPlace(_DomainFactories, universe, place);
		}
		return Get(universe);
	}

	public IGameWithUniverseAndRootPlace GetByPlaceId(long placeId, string name = null)
	{
		return new PlaceIdWithUniverseRootPlacePair(_DomainFactories, placeId, name);
	}

	public IGameWithUniverseAndRootPlace GetByUniverseId(long universeId)
	{
		return new UniverseIdWithUniverseRootPlacePair(_DomainFactories, universeId);
	}
}
