using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Universes.Properties;

namespace Roblox.Platform.Universes.Events;

/// <summary>
/// UniverseEventsPublisher implements <see cref="T:Roblox.Platform.Universes.Events.IUniverseEventsObserver" /> to get notifications of 
/// events and publishes them to a Universe entity changed SNS topic.
/// </summary>
internal class UniverseEventsPublisher : IUniverseEventsObserver, IObserver<UniverseEntityEvent>
{
    private readonly ILogger _Logger;

    private readonly ICounterRegistry _CounterRegistry;

    private IDisposable _Observable;

    private string Name => "UniverseEventsPublisher";

    /// <summary>
    /// Constructs a new <see cref="T:Roblox.Platform.Universes.Events.UniverseEventsPublisher" />. This is a no-op publisher.
    /// </summary>
    /// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
    /// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
    public UniverseEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
    {
        _Logger = logger ?? throw new ArgumentNullException("logger");
        _CounterRegistry = counterRegistry;
        // No external dependencies; events will be logged only when enabled.
    }

    /// <inheritdoc />
    public void Subscribe(IObservable<UniverseEntityEvent> observable)
    {
        _Observable = observable.Subscribe(this);
    }

    /// <inheritdoc />
    public void Unsubscribe()
    {
        _Observable?.Dispose();
    }

    /// <inheritdoc />
    public void OnNext(UniverseEntityEvent value)
    {
        if (Settings.Default.IsPublishToUniverseChangeTopicEnabled && value != null)
        {
            // No-op publish; log for visibility.
            _Logger.Info($"{Name} would publish event for universeId:{value.UniverseId}");
        }
    }

    /// <summary>
    /// This is not implemented.
    /// </summary>
    /// <param name="error"></param>
    /// <exception cref="T:System.NotImplementedException"></exception>
    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public void OnCompleted()
    {
        Unsubscribe();
    }
}
