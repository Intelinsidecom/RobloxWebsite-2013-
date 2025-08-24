using System;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> where the instance is created from a universe id.
/// </summary>
internal class UniverseIdWithUniverseRootPlacePair : IGameWithUniverseAndRootPlace
{
	private readonly ILogger _Logger;

	private readonly GamesDomainFactories _GamesDomainFactories;

	private readonly long _UniverseId;

	private readonly Lazy<IUniverseRootPlacePair> _UniverseRootPlacePair;

	public long? UniverseId => _UniverseId;

	public long? RootPlaceId => Universe?.RootPlaceId;

	public long PlaceId => Universe?.RootPlaceId ?? 0;

	public int? PlayerCount { get; set; }

	public IUniverse Universe => _UniverseRootPlacePair.Value?.Universe;

	public IPlace RootPlace => _UniverseRootPlacePair.Value?.RootPlace;

	public string DeveloperFacingName => Universe?.Name;

	public string PlayerFacingName
	{
		get
		{
			if (string.IsNullOrEmpty(Universe?.Name))
			{
				return RootPlace?.Name;
			}
			return Universe.Name;
		}
	}

	/// <summary>
	/// Create an instance of <see cref="T:Roblox.Platform.Games.PlaceIdWithUniverseRootPlacePair" />.
	/// </summary>
	/// <param name="gamesDomainFactories"></param>
	/// <param name="universeId">The universe's id.</param>
	public UniverseIdWithUniverseRootPlacePair(GamesDomainFactories gamesDomainFactories, long universeId)
	{
		_GamesDomainFactories = gamesDomainFactories ?? throw new ArgumentNullException("gamesDomainFactories");
		_UniverseId = universeId;
		_UniverseRootPlacePair = new Lazy<IUniverseRootPlacePair>(GetUniverseRootPlacePair);
	}

	public bool IsSecure()
	{
		if (Universe != null)
		{
			return _GamesDomainFactories.GameAttributesFactory.GetGameAttributes(Universe)?.IsSecure ?? false;
		}
		return false;
	}

	private IUniverseRootPlacePair GetUniverseRootPlacePair()
	{
		IUniverse universe = _GamesDomainFactories.UniverseFactory.GetUniverse(_UniverseId);
		IPlace rootPlace = ((universe == null || !universe.RootPlaceId.HasValue) ? null : _GamesDomainFactories.PlaceFactory.Get(universe.RootPlaceId.Value));
		return new UniverseRootPlacePair
		{
			Universe = universe,
			RootPlace = rootPlace
		};
	}
}
