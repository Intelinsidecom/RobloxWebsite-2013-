using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.UniverseDisplayInformation.Properties;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class ImageApprovalStatusGetter : IImageApprovalStatusGetter
{
	private readonly IAssetFactory _AssetFactory;

	private readonly IAssetTypeFactory _AssetTypeFactory;

	private readonly IRawContentFactory _RawContentFactory;

	private readonly Func<int> _RolloutPercentageGetter;

	private readonly ILogger _Logger;

	[ExcludeFromCodeCoverage]
	public ImageApprovalStatusGetter(IAssetFactory assetFactory, IAssetTypeFactory assetTypeFactory, IRawContentFactory rawContentFactory, ILogger logger)
		: this(assetFactory, assetTypeFactory, rawContentFactory, () => Settings.Default.ImageApprovalStatusGetterRolloutPercentage, logger)
	{
	}

	internal ImageApprovalStatusGetter(IAssetFactory assetFactory, IAssetTypeFactory assetTypeFactory, IRawContentFactory rawContentFactory, Func<int> rolloutPercentageGetter, ILogger logger)
	{
		_AssetFactory = assetFactory ?? throw new PlatformArgumentNullException("assetFactory");
		_AssetTypeFactory = assetTypeFactory ?? throw new PlatformArgumentNullException("assetTypeFactory");
		_RawContentFactory = rawContentFactory ?? throw new PlatformArgumentNullException("rawContentFactory");
		_RolloutPercentageGetter = rolloutPercentageGetter ?? throw new PlatformArgumentNullException("rolloutPercentageGetter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public IDictionary<long, bool> GetApprovalStatusForImages(IReadOnlyCollection<long> imageIds)
	{
		imageIds = imageIds.Distinct().ToList();
		Dictionary<long, bool> resultDictionary = imageIds.ToDictionary((long id) => id, (long id) => false);
		List<long> imageIdsToCheck = imageIds.Where((long id) => id % 100 < _RolloutPercentageGetter()).ToList();
		if (!imageIdsToCheck.Any())
		{
			return resultDictionary;
		}
		try
		{
			foreach (IAsset asset in _AssetFactory.GetAssets(imageIdsToCheck))
			{
				resultDictionary[asset.Id] = GetStatusForAsset(asset);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return resultDictionary;
	}

	[ExcludeFromCodeCoverage]
	internal virtual long GetAssetHashId(IAsset asset)
	{
		return asset.GetAssetHashId();
	}

	private bool GetStatusForAsset(IAsset asset)
	{
		try
		{
			AssetType? assetType = _AssetTypeFactory.GetAssetType(asset.TypeId);
			if (!assetType.HasValue)
			{
				return false;
			}
			if (!_AssetTypeFactory.DoesAssetTypeRequireReview(assetType.Value))
			{
				return true;
			}
			IRawContent rawContent = _RawContentFactory.Get(GetAssetHashId(asset));
			if (rawContent != null)
			{
				return rawContent.IsApproved && rawContent.IsReviewed;
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return false;
	}
}
