using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Given the input, this class determines:
/// - which items should be incremented on the Avatar Change graphs
/// - which items should be bumped to the top of recent avatar items
/// </summary>
internal class AssetChangeDiff
{
	public List<long> AssetIdsBefore;

	public List<long> AssetIdsToWear;

	public List<long> AssetIdsAfter;

	public bool IsWearingOutfit;

	public bool ResetAppearance;

	public long? PackageAssetId;

	private static readonly List<long> _EmptyList = new List<long>(0);

	private readonly AvatarDomainFactories _AvatarDomainFactories;

	public AssetChangeDiff(AvatarDomainFactories avatarDomainFactories, List<long> assetIdsBefore, List<long> assetIdsToWear, List<long> assetIdsAfter, bool isWearingOutfit, long? packageAssetId, bool resetAppearance)
	{
		_AvatarDomainFactories = avatarDomainFactories;
		AssetIdsBefore = assetIdsBefore;
		AssetIdsToWear = assetIdsToWear;
		AssetIdsAfter = assetIdsAfter;
		IsWearingOutfit = isWearingOutfit;
		PackageAssetId = packageAssetId;
		ResetAppearance = resetAppearance;
	}

	/// <summary>
	/// If wearing an outfit, don't fire avatarChange for any of the assets
	/// If wearing a package, only fire avatarChange for the package asset
	/// </summary>
	/// <returns></returns>
	public List<long> GetAssetsAddedByUser()
	{
		if (IsWearingOutfit)
		{
			return _EmptyList;
		}
		if (PackageAssetId.HasValue)
		{
			return new List<long> { PackageAssetId.Value };
		}
		return AssetIdsToWear.Where((long i) => !AssetIdsBefore.Contains(i) && AssetIdsAfter.Contains(i)).ToList();
	}

	/// <summary>
	/// If adding one item and removing one item and they are both the same type, don't count it as a removal
	/// It's probably a bump (e.g. when you wear a head, it bumps your other head)
	/// This intentionally does not cover the case of wearing 10 accessories and then using the web view to wear another one, resulting in a bunch being removed
	/// </summary>
	/// <param name="addedAssets"></param>
	/// <param name="removedAssets"></param>
	/// <returns></returns>
	private bool WasAssetSwappedWithAssetOfSameType(List<long> addedAssets, List<long> removedAssets)
	{
		if (addedAssets.Count == 1 && removedAssets.Count == 1)
		{
			Roblox.Platform.Assets.IAsset asset = _AvatarDomainFactories.AssetFactory.GetAsset(addedAssets.First());
			Roblox.Platform.Assets.IAsset removedAsset = _AvatarDomainFactories.AssetFactory.GetAsset(removedAssets.First());
			if (asset.TypeId == removedAsset.TypeId)
			{
				return true;
			}
		}
		return false;
	}

	public List<long> GetAssetsUnwornByUser()
	{
		if (ResetAppearance)
		{
			List<long> addedAssets = AssetIdsAfter.Where((long i) => !AssetIdsBefore.Contains(i)).ToList();
			List<long> unwornAssets = AssetIdsBefore.Where((long i) => !AssetIdsAfter.Contains(i)).ToList();
			if (!WasAssetSwappedWithAssetOfSameType(addedAssets, unwornAssets))
			{
				return unwornAssets;
			}
		}
		return _EmptyList;
	}

	/// <summary>
	/// If the user is wearing an outfit, we don't add the individual parts to recent
	/// If the user is wearing a package, add the individual parts
	/// </summary>
	/// <returns></returns>
	public List<long> GetRecentItemsAdded()
	{
		if (IsWearingOutfit)
		{
			return _EmptyList;
		}
		return AssetIdsAfter.Where((long i) => !AssetIdsBefore.Contains(i)).ToList();
	}

	public List<long> GetRecentItemsUnworn()
	{
		return AssetIdsBefore.Where((long i) => !AssetIdsAfter.Contains(i)).ToList();
	}
}
