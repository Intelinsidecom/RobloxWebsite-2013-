namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper interface class for submitting trusted Asset Text Info (Name and Description) to be changed.
/// The text info are considered trusted and should bypass text filtering.
/// </summary>
public interface ITrustedAssetTextInfo : INameAndDescription
{
}
