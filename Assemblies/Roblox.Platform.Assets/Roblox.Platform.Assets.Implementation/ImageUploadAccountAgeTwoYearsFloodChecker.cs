using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Properties;

namespace Roblox.Platform.Assets.Implementation;

internal class ImageUploadAccountAgeTwoYearsFloodChecker : FloodChecker, IRetryAfterFloodChecker, IFloodChecker, IBasicFloodChecker
{
	public ImageUploadAccountAgeTwoYearsFloodChecker(long userId)
		: base($"ImageUploadFloodChecker_AccountAgeTwoYears_UserId:{userId}", Settings.Default.ImageUploadAccountAgeTwoYearsLimit, Settings.Default.ImageUploadAccountAgeTwoYearsExpiry)
	{
	}

	/// <inheritdoc cref="T:Roblox.FloodCheckers.Core.IRetryAfterFloodChecker" />
	public int? RetryAfter()
	{
		return RetryAfterInternal();
	}
}
