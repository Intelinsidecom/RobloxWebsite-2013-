using System;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> which was created from a place id.
/// </summary>
internal class PlaceIdWithUniverseRootPlacePair : IGameWithUniverseAndRootPlace
{
	private readonly ILogger _Logger;

	private readonly GamesDomainFactories _GamesDomainFactories;

	private readonly string _Name;

	private readonly Lazy<IUniverseRootPlacePair> _UniverseRootPlacePair;

	public long? UniverseId => Universe?.Id;

	public long? RootPlaceId => Universe?.RootPlaceId;

	public long PlaceId { get; }

	public int? PlayerCount { get; set; }

	public IUniverse Universe => _UniverseRootPlacePair.Value?.Universe;

	public IPlace RootPlace => _UniverseRootPlacePair.Value?.RootPlace;

	public string DeveloperFacingName => Universe?.Name;

	public string PlayerFacingName
	{
		get
		{
			string name = _Name;
			if (name == null)
			{
				if (string.IsNullOrEmpty(Universe?.Name))
				{
					return RootPlace?.Name;
				}
				name = Universe.Name;
			}
			return name;
		}
	}

	/// <summary>
	/// Create an instance of <see cref="T:Roblox.Platform.Games.PlaceIdWithUniverseRootPlacePair" />.
	/// </summary>
	/// <param name="gamesDomainFactories"></param>
	/// <param name="placeId">The place's id. It's fine if the specified place is not a root place.</param>
	/// <param name="name">The game's name. When it's null, the universe's name will be used.</param>
	public PlaceIdWithUniverseRootPlacePair(GamesDomainFactories gamesDomainFactories, long placeId, string name = null)
	{
		_GamesDomainFactories = gamesDomainFactories ?? throw new ArgumentNullException("gamesDomainFactories");
		PlaceId = placeId;
		_Name = name;
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
		IUniverse universe = _GamesDomainFactories.UniverseFactory.GetPlaceUniverse(PlaceId);
		IPlace rootPlace = ((universe == null || !universe.RootPlaceId.HasValue) ? null : _GamesDomainFactories.PlaceFactory.Get(universe.RootPlaceId.Value));
		return new UniverseRootPlacePair
		{
			Universe = universe,
			RootPlace = rootPlace
		};
	}
}
