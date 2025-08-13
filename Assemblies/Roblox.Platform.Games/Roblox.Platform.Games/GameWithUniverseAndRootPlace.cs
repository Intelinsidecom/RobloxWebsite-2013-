using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

internal class GameWithUniverseAndRootPlace : IGameWithUniverseAndRootPlace
{
	private readonly GamesDomainFactories _DomainFactories;

	public long? UniverseId => Universe.Id;

	public long? RootPlaceId => Universe.RootPlaceId;

	public long PlaceId => RootPlace.Id;

	public int? PlayerCount { get; set; }

	public IUniverse Universe { get; }

	public IPlace RootPlace { get; }

	public string DeveloperFacingName => Universe.Name;

	public string PlayerFacingName
	{
		get
		{
			if (string.IsNullOrEmpty(Universe.Name))
			{
				return RootPlace.Name;
			}
			return Universe.Name;
		}
	}

	public GameWithUniverseAndRootPlace(GamesDomainFactories domainFactories, IUniverse universe, IPlace rootPlace)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		Universe = universe ?? throw new ArgumentNullException("universe");
		RootPlace = rootPlace ?? throw new ArgumentNullException("rootPlace");
		if (Universe.RootPlaceId != RootPlace.Id)
		{
			throw new ArgumentException("Universe root place id mismatch.");
		}
	}

	public bool IsSecure()
	{
		return _DomainFactories.GameAttributesFactory.GetGameAttributes(Universe)?.IsSecure ?? false;
	}
}
