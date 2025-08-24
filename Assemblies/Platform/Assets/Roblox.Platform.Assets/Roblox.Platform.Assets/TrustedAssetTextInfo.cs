namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper class for submitting trusted Asset Text Info (Name and Description) to be changed.
/// The text info are considered trusted and should bypass text filtering.
/// </summary>
public class TrustedAssetTextInfo : ITrustedAssetTextInfo, INameAndDescription
{
	/// <summary>
	/// The new Name of the Asset.
	/// </summary>
	public string Name { get; }

	/// <summary>
	/// The new Description of the Asset.
	/// </summary>
	public string Description { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="name"></param>
	/// <param name="description"></param>
	public TrustedAssetTextInfo(string name, string description)
	{
		Name = name;
		Description = description;
	}
}
