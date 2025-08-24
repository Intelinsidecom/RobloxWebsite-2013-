using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AssetsCore;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Web.Games;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeAwardAssetsReader" />
public class BadgeAwardAssetsReader : IBadgeAwardAssetsReader
{
	private readonly IBadgeIdentifierFactory _BadgeIdentifierFactory;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeAwardAssetsReader" />.
	/// </summary>
	/// <param name="badgeIdentifierFactory">An <see cref="T:Roblox.Platform.Badges.IBadgeIdentifierFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badgeIdentifierFactory" /></exception>
	public BadgeAwardAssetsReader(IBadgeIdentifierFactory badgeIdentifierFactory)
	{
		_BadgeIdentifierFactory = badgeIdentifierFactory ?? throw new ArgumentNullException("badgeIdentifierFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeAwardAssetsReader.GetBadgeAwardAssetsByBadge(Roblox.Platform.Badges.IBadgeIdentifier)" />
	public ICollection<IBadgeAwardAsset> GetBadgeAwardAssetsByBadge(IBadgeIdentifier badge)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		return BadgeAssetAward.GetBadgeAssetAwardsByBadgeID(badge.Id).Select(ConvertEntityToBadgeAwardAsset).ToArray();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeAwardAssetsReader.GetBadgeAwardAssets(Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo{System.Int32})" />
	public IPlatformPageResponse<int, IBadgeAwardAsset> GetBadgeAwardAssets(IExclusiveStartKeyInfo<int> exclusiveStartKey)
	{
		if (exclusiveStartKey == null)
		{
			throw new ArgumentNullException("exclusiveStartKey");
		}
		if (exclusiveStartKey.Count <= 0)
		{
			throw new ArgumentException(string.Format("{0}.{1} cannot be zero or negative.", "exclusiveStartKey", "Count"), "exclusiveStartKey");
		}
		if (!exclusiveStartKey.TryGetExclusiveStartKey(out var startRowIndex))
		{
			startRowIndex = 0;
		}
		if (startRowIndex < 0)
		{
			throw new ArgumentException(string.Format("{0} cannot be negative.", "startRowIndex"), "exclusiveStartKey");
		}
		ICollection<BadgeAssetAward> badgeAssetAwardsPaged = BadgeAssetAward.GetBadgeAssetAwardsPaged(startRowIndex, exclusiveStartKey.Count + 1);
		IBadgeAwardAsset[] badgeAwardAssets = badgeAssetAwardsPaged.Take(exclusiveStartKey.Count).Select(ConvertEntityToBadgeAwardAsset).ToArray();
		ExclusiveStartKeyContainer<int> previousPageExclusiveStartKey = ((startRowIndex > 0) ? new ExclusiveStartKeyContainer<int>(Math.Max(0, startRowIndex - exclusiveStartKey.Count)) : null);
		ExclusiveStartKeyContainer<int> nextPageExclusiveStartKey = ((badgeAssetAwardsPaged.Count > exclusiveStartKey.Count) ? new ExclusiveStartKeyContainer<int>(startRowIndex + exclusiveStartKey.Count) : null);
		return new PlatformPageResponse<int, IBadgeAwardAsset>(badgeAwardAssets, exclusiveStartKey, previousPageExclusiveStartKey, nextPageExclusiveStartKey);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeAwardAssetsReader.GetTotalNumberOfBadgeAwardAssets" />
	public long GetTotalNumberOfBadgeAwardAssets()
	{
		return BadgeAssetAward.GetTotalNumberOfBadgeAssetAwards();
	}

	private IBadgeAwardAsset ConvertEntityToBadgeAwardAsset(BadgeAssetAward entity)
	{
		return new BadgeAwardAsset
		{
			Asset = AssetIdentifierFactory.GetAssetIdentifier(entity.AssetAwardID),
			Badge = _BadgeIdentifierFactory.Get(entity.BadgeID),
			Description = entity.Description,
			Created = entity.Created,
			Updated = entity.Updated
		};
	}
}
