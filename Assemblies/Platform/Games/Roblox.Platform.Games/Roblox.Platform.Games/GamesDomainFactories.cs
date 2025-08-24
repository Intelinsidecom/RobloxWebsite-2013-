using System;
using Roblox.CatalogItemChangePublisher;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.Assets.Places;
using Roblox.Platform.Core;
using Roblox.Platform.Games.Events;
using Roblox.Platform.Universes;
using Roblox.Universes.Client;

namespace Roblox.Platform.Games;

public class GamesDomainFactories : DomainFactoriesBase
{
	internal virtual IPlaceFactory PlaceFactory { get; }

	internal virtual IUniverseFactory UniverseFactory { get; }

	internal virtual ILogger Logger { get; }

	/// <summary>
	/// Publishes events to the running games SNS queue
	/// </summary>
	internal virtual IEventPublisher RunningGamesEventPublisher { get; private set; }

	internal virtual ICatalogItemChangePublisher CatalogChangeEventPublisher { get; private set; }

	internal virtual GamePlacesChangeReporter GamePlacesChangeReporter { get; }

	internal virtual IGameAttributesEntityFactory GameAttributesEntityFactory { get; }

	public virtual IGameWithUniverseAndRootPlaceFactory GameWithUniverseAndRootPlaceFactory { get; }

	public virtual IGameAttributesFactory GameAttributesFactory { get; }

	public virtual IGamePlacesManager GamePlacesManager { get; }

	public GamesDomainFactories(IPlaceFactory placeFactory, IUniverseFactory universeFactory, PlaceAttributesDomainFactories placeAttributesDomainFactories, IUniversesClient universesClient, ILogger logger, ICatalogItemChangePublisher catalogPublisher, IEventPublisher runningGamesEventPublisher, ICounterRegistry counterRegistry)
		: this(placeFactory, universeFactory, placeAttributesDomainFactories, universesClient, logger, catalogPublisher, runningGamesEventPublisher, new GamePlacesEventsPublisher(logger, counterRegistry))
	{
	}

	public GamesDomainFactories(IPlaceFactory placeFactory, IUniverseFactory universeFactory, PlaceAttributesDomainFactories placeAttributesDomainFactories, IUniversesClient universesClient, ILogger logger, ICatalogItemChangePublisher catalogPublisher, IEventPublisher runningGamesEventPublisher, IGamePlacesEventsObserver gamePlacesEventsObserver)
	{
		if (placeAttributesDomainFactories == null)
		{
			throw new ArgumentNullException("placeAttributesDomainFactories");
		}
		if (universesClient == null)
		{
			throw new ArgumentNullException("universesClient");
		}
		if (gamePlacesEventsObserver == null)
		{
			throw new ArgumentNullException("gamePlacesEventsObserver");
		}
		PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		Logger = logger ?? throw new ArgumentNullException("logger");
		RunningGamesEventPublisher = runningGamesEventPublisher ?? throw new ArgumentNullException("runningGamesEventPublisher");
		CatalogChangeEventPublisher = catalogPublisher ?? throw new ArgumentNullException("catalogPublisher");
		GameAttributesEntityFactory = new GameAttributesEntityFactory(this);
		GameWithUniverseAndRootPlaceFactory = new GameWithUniverseAndRootPlaceFactory(this);
		GameAttributesFactory = new GameAttributesFactory(this, universeFactory, logger);
		GamePlacesManager = new GamePlacesManager(this, universesClient, universeFactory, placeAttributesDomainFactories);
		gamePlacesEventsObserver.Subscribe(GamePlacesChangeReporter = new GamePlacesChangeReporter());
	}
}
