using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Universes.Events;
using Roblox.Universes.Client;

namespace Roblox.Platform.Universes;

/// <summary>
/// Implements <see cref="T:Roblox.Platform.Universes.IUniverseWriter" />
/// </summary>
public class UniverseWriter : IUniverseWriter
{
	/// <summary>
	/// A <see cref="T:Roblox.Universes.Client.IUniversesClient" />
	/// </summary>
	internal virtual IUniversesClient UniversesClient { get; }

	/// <summary>
	/// A <see cref="P:Roblox.Platform.Universes.UniverseWriter.UniverseChangeReporter" />
	/// </summary>
	internal virtual UniverseChangeReporter UniverseChangeReporter { get; }

	/// <summary>
	/// A <see cref="T:Roblox.EventLog.ILogger" />&gt;
	/// </summary>
	internal virtual ILogger Logger { get; }

	/// <summary>
	/// A <see cref="T:Roblox.Platform.Universes.Events.IUniverseEventsObserver" />&gt;
	/// </summary>
	internal virtual IUniverseEventsObserver UniverseEventsObserver { get; }

	/// <summary>
	/// Constructs a <see cref="T:Roblox.Platform.Universes.UniverseWriter" />
	/// </summary>
	/// <param name="universesClient">A <see cref="T:Roblox.Universes.Client.IUniversesClient" /></param>
	/// <param name="logger">A <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universesClient" /></exception>
	public UniverseWriter(IUniversesClient universesClient, ILogger logger, ICounterRegistry counterRegistry)
		: this(universesClient, new UniverseChangeReporter(), logger, new UniverseEventsPublisher(logger, counterRegistry))
	{
	}

	internal UniverseWriter(IUniversesClient universesClient, UniverseChangeReporter universeChangeReporter, ILogger logger, IUniverseEventsObserver universeEventsObserver)
	{
		UniversesClient = universesClient ?? throw new ArgumentNullException("universesClient");
		Logger = logger ?? throw new ArgumentNullException("logger");
		UniverseChangeReporter = universeChangeReporter ?? throw new ArgumentNullException("universeChangeReporter");
		UniverseEventsObserver = universeEventsObserver ?? throw new ArgumentNullException("universeEventsObserver");
		universeEventsObserver.Subscribe(universeChangeReporter);
	}

	/// <inheritdoc />
	public void UpdateIsArchived(IUniverse universe, bool isArchived)
	{
		universe.IsArchived = isArchived;
		UniversesClient.UpdateUniverse(universe.Id, universe.Name, universe.Description, universe.RootPlaceId, universe.StudioAccessToApisAllowed, isArchived, (PrivacyType?)null);
		UniverseChangeReporter.EntityChanged(universe.Id, UniverseChangeType.IsArchivedChanged);
	}
}
