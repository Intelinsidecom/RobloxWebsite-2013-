using System;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Properties;
using Roblox.Platform.Assets.Implementation;
using Roblox.Platform.Assets.Interface;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets;

public class UploadFloodcheckerFactory : IUploadFloodcheckerFactory
{
	private readonly TimeSpan _OneYear = new TimeSpan(365, 0, 0, 0);

	private readonly TimeSpan _TwoYears = new TimeSpan(730, 0, 0, 0);

	internal virtual bool _FeatureEnabled => Settings.Default.ImageUploadFloodchecksByAccountAgeEnabled;

	public IRetryAfterFloodChecker GetImageUploadFloodchecker(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		TimeSpan accountAge = GetAccountAge(user);
		if (_FeatureEnabled && accountAge > _TwoYears)
		{
			return new ImageUploadAccountAgeTwoYearsFloodChecker(user.Id);
		}
		if (_FeatureEnabled && accountAge > _OneYear)
		{
			return new ImageUploadAccountAgeOneYearFloodChecker(user.Id);
		}
		return new ImageUploadFloodChecker(user.Id);
	}

	public IFloodChecker GetFreeThumbnailImageUploadFloodChecker(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		return new FreeThumbnailImageUploadFloodChecker(user.Id);
	}

	public IRetryAfterFloodChecker GetCreatorAssetTypeUploadFloodChecker(CreatorType creatorType, long creatorTargetId, AssetType assetType)
	{
		return new CreatorAssetTypeUploadFloodChecker(creatorType, creatorTargetId, assetType);
	}

	internal virtual TimeSpan GetAccountAge(IUser user)
	{
		return DateTime.Now - user.Created;
	}
}
