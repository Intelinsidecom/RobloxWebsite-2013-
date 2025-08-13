namespace Roblox.Platform.Security.SecureBlobs;

internal class SecureBlobDataModel
{
	internal long ExpirationTicks { get; set; }

	internal string Json { get; set; }

	internal string Hash { get; set; }
}
