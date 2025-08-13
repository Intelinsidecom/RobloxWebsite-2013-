using System;
using System.Linq;
using Roblox.Platform.AssetsCore;
using Roblox.Web.Games;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeAwardAssetWriter" />
public class BadgeAwardAssetWriter : IBadgeAwardAssetWriter
{
	private readonly IBadgeAwardAssetsReader _BadgeAwardAssetsReader;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.IBadgeAwardAssetWriter" />.
	/// </summary>
	/// <param name="badgeAwardAssetsReader">An <see cref="T:Roblox.Platform.Badges.IBadgeAwardAssetsReader" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badgeAwardAssetsReader" /></exception>
	public BadgeAwardAssetWriter(IBadgeAwardAssetsReader badgeAwardAssetsReader)
	{
		_BadgeAwardAssetsReader = badgeAwardAssetsReader ?? throw new ArgumentNullException("badgeAwardAssetsReader");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeAwardAssetWriter.CreateBadgeAward(Roblox.Platform.Badges.IBadgeIdentifier,Roblox.Platform.AssetsCore.IAssetIdentifier,System.String)" />
	public void CreateBadgeAward(IBadgeIdentifier badge, IAssetIdentifier asset, string description)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (_BadgeAwardAssetsReader.GetBadgeAwardAssetsByBadge(badge).Any((IBadgeAwardAsset ba) => ba.Asset.Id == asset.Id))
		{
			throw new ArgumentException(string.Format("{0} already has asset ({1})", "badge", asset.Id), "asset");
		}
		BadgeAssetAward.CreateNew(badge.Id, asset.Id, description ?? string.Empty);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeAwardAssetWriter.DeleteBadgeAward(Roblox.Platform.Badges.IBadgeIdentifier,Roblox.Platform.AssetsCore.IAssetIdentifier)" />
	public void DeleteBadgeAward(IBadgeIdentifier badge, IAssetIdentifier asset)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		(BadgeAssetAward.GetBadgeAssetAwardsByBadgeID(badge.Id).FirstOrDefault((BadgeAssetAward ba) => ba.AssetAwardID == asset.Id) ?? throw new ArgumentException(string.Format("{0} doesn't have awarding asset ({1})", "badge", asset.Id), "asset")).Delete();
	}
}
