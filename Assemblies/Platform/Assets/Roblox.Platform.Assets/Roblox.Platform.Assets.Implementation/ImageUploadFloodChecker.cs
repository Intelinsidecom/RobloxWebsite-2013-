using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Properties;

namespace Roblox.Platform.Assets.Implementation;

internal class ImageUploadFloodChecker : FloodChecker, IRetryAfterFloodChecker, IFloodChecker, IBasicFloodChecker
{
	public ImageUploadFloodChecker(long userId)
		: base($"ImageUploadFloodChecker_UserId:{userId}", Settings.Default.ImageUploadFloodCheckLimit, Settings.Default.ImageUploadFloodCheckExpiry)
	{
	}

	/// <inheritdoc cref="T:Roblox.FloodCheckers.Core.IRetryAfterFloodChecker" />
	public int? RetryAfter()
	{
		return RetryAfterInternal();
	}
}
