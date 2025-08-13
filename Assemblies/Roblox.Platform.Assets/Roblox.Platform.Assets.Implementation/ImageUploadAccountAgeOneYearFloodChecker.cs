using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Properties;

namespace Roblox.Platform.Assets.Implementation;

internal class ImageUploadAccountAgeOneYearFloodChecker : FloodChecker, IRetryAfterFloodChecker, IFloodChecker, IBasicFloodChecker
{
	public ImageUploadAccountAgeOneYearFloodChecker(long userId)
		: base($"ImageUploadFloodChecker_AccountAgeOneYear_UserId:{userId}", Settings.Default.ImageUploadAccountAgeOneYearLimit, Settings.Default.ImageUploadAccountAgeOneYearExpiry)
	{
	}

	/// <inheritdoc cref="T:Roblox.FloodCheckers.Core.IRetryAfterFloodChecker" />
	public int? RetryAfter()
	{
		return RetryAfterInternal();
	}
}
