using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

/// <summary>
/// A platform exception thrown when the newly uploaded video has already been disapproved previously. It is intended to be thrown to stop asset creation.
/// The caller should handle this exception gracefully.
/// </summary>
/// <inheritdoc cref="T:Roblox.Platform.Core.PlatformException" />
public class VideoDisapprovedException : PlatformException
{
}
