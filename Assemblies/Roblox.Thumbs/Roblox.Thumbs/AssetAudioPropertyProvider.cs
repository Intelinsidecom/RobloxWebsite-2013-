using Roblox.Thumbs.Properties;

namespace Roblox.Thumbs;

/// <summary>
/// Provider of Properties from this project
/// </summary>
public class AssetAudioPropertyProvider : IAssetAudioPropertyProvider
{
	/// <summary>
	/// Get value of the property "AudioPlaybackEnabled"
	/// </summary>
	public bool GetAudioPlaybackEnabledValue()
	{
		return Settings.Default.AudioPlaybackEnabled;
	}
}
