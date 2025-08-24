namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// A class which listens to the events of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioReplacer" /> and writes the data to a data target.
/// </summary>
public interface IAudioReplacerMonitor
{
	/// <summary>
	/// Start listening to the events of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioReplacer" />.
	/// </summary>
	/// <param name="audioReplacer">The <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioReplacer" /> to listen to.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="audioReplacer" /></exception>
	void RegisterEvents(IAudioReplacer audioReplacer);

	/// <summary>
	/// Registers that an audio asset has been served to a consumer.
	/// </summary>
	void RegisterAudioAssetServed();
}
