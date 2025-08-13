using Roblox.Platform.Core;

namespace Roblox.Platform.Security.SecureBlobs;

/// <summary>
/// An exception thrown when a SecureBlob is in a valid format, but is expired.
/// </summary>
public class SecureBlobExpiredException : PlatformException
{
}
