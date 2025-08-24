using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.UniverseSettings.Properties;

namespace Roblox.Platform.UniverseSettings.Events;

/// <summary>
/// No-op publisher that logs UniverseSettings events. SNS integration removed to drop AWS dependency.
/// </summary>
internal class UniverseSettingsEventsPublisher : IUniverseSettingsEventsObserver, IObserver<UniverseSettingsEvent>
{
    private readonly ILogger _Logger;

    private IDisposable _Observable;

    private readonly ICounterRegistry _CounterRegistry;

    private string Name => "UniverseSettingsEventsPublisher";

    public UniverseSettingsEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
    {
        _Logger = logger ?? throw new ArgumentNullException("logger");
        _CounterRegistry = counterRegistry;
        // No external initialization required in no-op implementation
    }

    /// <inheritdoc />
    public void Subscribe(IObservable<UniverseSettingsEvent> observable)
    {
        _Observable = observable.Subscribe(this);
    }

    /// <inheritdoc />
    public void Unsubscribe()
    {
        _Observable.Dispose();
    }

    /// <inheritdoc />
    public void OnNext(UniverseSettingsEvent value)
    {
        if (Settings.Default.IsPublishToUniverseSettingsChangeTopicEnabled && value != null)
        {
            // Log the event instead of publishing to SNS
            _Logger.Info($"{Name} observed event for universeId:{value.UniverseId}");
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
