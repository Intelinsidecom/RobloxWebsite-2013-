using System;
using Roblox.CatalogItemChangePublisher;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.Universes.Events;
using Roblox.TextFilter.Client;
using Roblox.Universes.Client;

namespace Roblox.Platform.Universes;

public class UniverseDomainFactories
{
	public virtual IUniverseFactory UniverseFactory { get; }

	internal virtual IUniversesClient UniversesClient { get; }

	internal virtual IUniverseTextFilter UniverseTextFilter { get; }

	internal virtual IUniverseEventsObserver UniverseEventsObserver { get; }

	internal virtual ICatalogItemChangePublisher CatalogPublisher { get; }

	internal virtual UniverseChangeReporter UniverseChangeReporter { get; }

	internal virtual IPlaceFactory PlaceFactory { get; }

	/// <summary>
	/// Only to be used for unit tests
	/// </summary>
	internal UniverseDomainFactories()
	{
	}

	/// <summary>
	/// The normal <see cref="T:Roblox.Platform.Universes.UniverseDomainFactories" /> constructor
	/// </summary>
	/// <param name="universesClient"><see cref="T:Roblox.Universes.Client.IUniversesClient" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="catalogPublisher"></param>
	/// <param name="placeFactory"><see cref="T:Roblox.Platform.Assets.IPlaceFactory" /></param>
	/// <param name="counterRegistry"></param>
	public UniverseDomainFactories(IUniversesClient universesClient, ITextFilterClientV2 textFilterClientV2, ILogger logger, ICatalogItemChangePublisher catalogPublisher, IPlaceFactory placeFactory, ICounterRegistry counterRegistry)
		: this(universesClient, textFilterClientV2, catalogPublisher, new UniverseEventsPublisher(logger, counterRegistry), placeFactory)
	{
	}

	/// <summary>
	/// Specialized <see cref="T:Roblox.Platform.Universes.UniverseDomainFactories" /> constructor
	/// </summary>
	/// <param name="universesClient"><see cref="T:Roblox.Universes.Client.IUniversesClient" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="catalogPublisher"></param>
	/// <param name="universeEventsObserver">Inject a custom <see cref="T:Roblox.Platform.Universes.Events.IUniverseEventsObserver" /> for testing or a very good reason.</param>
	/// <param name="placeFactory"><see cref="T:Roblox.Platform.Assets.IPlaceFactory" /></param>
	/// <remarks>
	/// This constructor should only be used when you have a specific and well understood need to supply your own <see cref="T:Roblox.Platform.Universes.Events.IUniverseEventsObserver" />.
	/// </remarks>
	public UniverseDomainFactories(IUniversesClient universesClient, ITextFilterClientV2 textFilterClientV2, ICatalogItemChangePublisher catalogPublisher, IUniverseEventsObserver universeEventsObserver, IPlaceFactory placeFactory)
	{
		if (textFilterClientV2 == null)
		{
			throw new ArgumentNullException("textFilterClientV2");
		}
		UniversesClient = universesClient ?? throw new ArgumentNullException("universesClient");
		CatalogPublisher = catalogPublisher ?? throw new ArgumentNullException("catalogPublisher");
		PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		UniverseFactory universeFactory = new UniverseFactory(universesClient, this);
		UniverseFactory = universeFactory;
		UniverseTextFilter = new UniverseTextFilter(textFilterClientV2);
		UniverseChangeReporter universeChangeReporter = (UniverseChangeReporter = new UniverseChangeReporter());
		UniverseEventsObserver = universeEventsObserver ?? throw new ArgumentNullException("universeEventsObserver");
		universeEventsObserver.Subscribe(universeChangeReporter);
	}
}
