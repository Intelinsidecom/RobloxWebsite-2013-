using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// An <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioReplacerMonitor" /> which writes to perfmon counters.
/// </summary>
public class AudioReplacerPerfmonMonitor : IAudioReplacerMonitor
{
	private const string _PerformanceCategory = "Roblox.Platform.AudioRightsManagement.AudioReplacerV1";

	private readonly IRateOfCountsPerSecondCounter RawContentHasBeenReplaced;

	private readonly IRateOfCountsPerSecondCounter AudioAssetServed;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioReplacerPerfmonMonitor" />.
	/// </summary>
	public AudioReplacerPerfmonMonitor(ICounterRegistry counterRegistry)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		RawContentHasBeenReplaced = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.AudioRightsManagement.AudioReplacerV1", "RawContentHasBeenReplaced");
		AudioAssetServed = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.AudioRightsManagement.AudioReplacerV1", "AudioAssetServed");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioReplacerMonitor.RegisterEvents(Roblox.Platform.AudioRightsManagement.IAudioReplacer)" />
	public void RegisterEvents(IAudioReplacer audioReplacer)
	{
		if (audioReplacer == null)
		{
			throw new ArgumentNullException("audioReplacer");
		}
		audioReplacer.OnRawContentHasBeenReplaced += delegate
		{
			RawContentHasBeenReplaced.Increment();
		};
	}

	/// <summary>
	/// Registers that an audio asset has been served to a consumer.
	/// </summary>
	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioReplacerMonitor.RegisterAudioAssetServed" />
	public void RegisterAudioAssetServed()
	{
		AudioAssetServed.Increment();
	}
}
