using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// We keep track of items that a user has recently interacted with
/// This will be displayed on the avatar page
/// Note: we don't check whether the user actually owns the item; we just put it on their avatar page anyway.  This should be fine.
/// </summary>
public class RecentAvatarItems
{
	private readonly IUser _User;

	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly Dictionary<byte, RecentListDataProvider> _RecentItemLists = new Dictionary<byte, RecentListDataProvider>();

	private IAvatarOwnershipFactory AvatarOwnershipFactory => _AvatarDomainFactories.AvatarOwnershipFactory;

	public RecentAvatarItems(IUser user, AvatarDomainFactories avatarDomainFactories)
	{
		_User = user ?? throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "user"));
		_AvatarDomainFactories = avatarDomainFactories;
	}

	public bool QualifiesAsRecentAvatarItem(Roblox.Platform.Assets.IAsset asset)
	{
		if (asset == null)
		{
			return false;
		}
		RecentItem recentItem = FromAsset(asset, DateTime.Now);
		return GetListType(recentItem) != null;
	}

	public bool QualifiesAsRecentAvatarItem(IUserOutfit userOutfit)
	{
		RecentItem recentItem = FromUserOutfit(userOutfit, DateTime.Now);
		return GetListType(recentItem) != null;
	}

	private RecentItem FromAsset(Roblox.Platform.Assets.IAsset asset, DateTime date)
	{
		return new RecentItem(asset.Id, _AvatarDomainFactories.RecentItemTypeEntityFactory.Asset, date);
	}

	private RecentItem FromUserOutfit(IUserOutfit userOutfit, DateTime date)
	{
		return new RecentItem(userOutfit.Id, _AvatarDomainFactories.RecentItemTypeEntityFactory.Outfit, date);
	}

	public void Remove(Roblox.Platform.Assets.IAsset asset)
	{
		if (asset != null)
		{
			RecentItem recentItem = FromAsset(asset, DateTime.Now);
			IRecentItemListTypeEntity listType = GetListType(recentItem);
			if (listType != null)
			{
				GetList(listType, retrievingBeforeSave: true).Remove(recentItem);
			}
		}
	}

	public void Remove(IUserOutfit userOutfit)
	{
		RecentItem recentItem = FromUserOutfit(userOutfit, DateTime.Now);
		IRecentItemListTypeEntity listType = GetListType(recentItem);
		if (listType != null)
		{
			GetList(listType, retrievingBeforeSave: true).Remove(recentItem);
		}
	}

	/// <summary>
	/// Adds the asset to the appropriate list of recent avatar items
	/// Call <see cref="M:Roblox.Platform.Avatar.RecentAvatarItems.Save" /> to persist the change to the database
	/// </summary>
	public void Add(Roblox.Platform.Assets.IAsset asset, DateTime? date = null)
	{
		if (asset != null)
		{
			RecentItem recentItem = FromAsset(asset, date ?? DateTime.Now);
			IRecentItemListTypeEntity listType = GetListType(recentItem);
			if (listType != null)
			{
				GetList(listType, retrievingBeforeSave: true).Add(recentItem);
			}
		}
	}

	/// <summary>
	/// Adds the userOutfit to the appropriate list of recent avatar items
	/// Call <see cref="M:Roblox.Platform.Avatar.RecentAvatarItems.Save" /> to persist the change to the database
	/// </summary>
	public void Add(IUserOutfit userOutfit, DateTime? date = null)
	{
		RecentItem recentItem = FromUserOutfit(userOutfit, date ?? DateTime.Now);
		IRecentItemListTypeEntity listType = GetListType(recentItem);
		if (listType != null)
		{
			GetList(listType, retrievingBeforeSave: true).Add(recentItem);
		}
	}

	/// <summary>
	/// Saves each list of recent avatar items
	/// </summary>
	public void Save()
	{
		foreach (RecentListDataProvider value in _RecentItemLists.Values)
		{
			value.Save();
		}
	}

	/// <summary>
	/// Gets a list of recent avatar items of the given type
	/// </summary>
	/// <param name="recentItemListTypeEnum"></param>
	/// <returns></returns>
	public ICollection<RecentAvatarItem> GetRecentItems(RecentItemListTypeEnum recentItemListTypeEnum)
	{
		if (recentItemListTypeEnum == RecentItemListTypeEnum.All)
		{
			return GetAll();
		}
		IRecentItemListTypeEntity listType = GetListType(recentItemListTypeEnum);
		RecentListDataProvider itemList = GetList(listType, retrievingBeforeSave: false);
		ICollection<RecentItem> recentItems = itemList.GetItems();
		bool listNeedsSave = false;
		foreach (RecentItem item in recentItems.ToList())
		{
			if (!IsValidRecentItem(item))
			{
				listNeedsSave = true;
				itemList.Remove(item);
				recentItems.Remove(item);
			}
		}
		if (listNeedsSave)
		{
			itemList.Save();
		}
		return recentItems.Select(Translate).ToList();
	}

	private RecentAvatarItem Translate(RecentItem recentItem)
	{
		RecentItemTypeEnum recentItemType = (RecentItemTypeEnum)recentItem.TypeId;
		return new RecentAvatarItem(recentItem.TargetId, recentItemType, recentItem.Date);
	}

	/// <summary>
	/// Gets a list of recent avatar items of all the types
	/// </summary>
	/// <returns></returns>
	private ICollection<RecentAvatarItem> GetAll()
	{
		List<RecentAvatarItem> combinedList = new List<RecentAvatarItem>();
		foreach (RecentItemListTypeEnum listTypeEnum in Enum.GetValues(typeof(RecentItemListTypeEnum)))
		{
			if (listTypeEnum != 0)
			{
				ICollection<RecentAvatarItem> items = GetRecentItems(listTypeEnum);
				combinedList.AddRange(items);
			}
		}
		return combinedList.OrderByDescending((RecentAvatarItem r) => r.Date).DistinctBy((RecentAvatarItem r) => r.GetUniqueCode()).Take(RecentListDataProvider.MaxRecentItems())
			.ToList();
	}

	private RecentListDataProvider GetList(IRecentItemListTypeEntity itemListType, bool retrievingBeforeSave)
	{
		if (!_RecentItemLists.TryGetValue(itemListType.Id, out var recentList))
		{
			recentList = new RecentListDataProvider(_User, itemListType, _AvatarDomainFactories);
			if (!recentList.IsPopulated())
			{
				PopulateList(recentList, retrievingBeforeSave);
			}
			_RecentItemLists.Add(itemListType.Id, recentList);
		}
		return recentList;
	}

	/// <summary>
	///             invalid if null, or (asset is expireable and userasset is expired)
	/// </summary>
	private bool IsUserAssetValidForRecentItems(IUserAsset userAsset)
	{
		if (userAsset != null)
		{
			return !AvatarOwnershipFactory.IsExpired(userAsset);
		}
		return false;
	}

	private bool IsUserOutfitValidForRecentItems(IUserOutfit userOutfit)
	{
		return userOutfit != null;
	}

	private bool IsAssetValidForRecentItems(long assetId)
	{
		if (_User.Id % 100 < _AvatarDomainFactories.Settings.UserOwnsUnexpiredAssetCheckRolloutPercentage)
		{
			return AvatarOwnershipFactory.UserOwnsUnexpiredAsset(_User.Id, assetId);
		}
		IUserAsset userAsset = AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(_User.Id, assetId).FirstOrDefault();
		return IsUserAssetValidForRecentItems(userAsset);
	}

	private bool IsValidRecentItem(RecentItem item)
	{
		if (item.TypeId == _AvatarDomainFactories.RecentItemTypeEntityFactory.Asset.Id)
		{
			return IsAssetValidForRecentItems(item.TargetId);
		}
		if (item.TypeId == _AvatarDomainFactories.RecentItemTypeEntityFactory.Outfit.Id)
		{
			IUserOutfit userOutfit = _AvatarDomainFactories.OutfitDomainFactories.UserOutfitFactory.GetUserOutfit(item.TargetId);
			return IsUserOutfitValidForRecentItems(userOutfit);
		}
		throw new PlatformArgumentException(string.Format("ListTypeId {0} is not being handled in method {1}", item.TypeId, "PopulateList"));
	}

	private IRecentItemListTypeEntity GetListType(AvatarAssetGroupsEnum? avatarAssetGroupsEnum)
	{
		if (!avatarAssetGroupsEnum.HasValue)
		{
			return null;
		}
		return avatarAssetGroupsEnum switch
		{
			AvatarAssetGroupsEnum.Accessories => _AvatarDomainFactories.RecentItemListTypeEntityFactory.Accessories, 
			AvatarAssetGroupsEnum.AvatarAnimations => _AvatarDomainFactories.RecentItemListTypeEntityFactory.AvatarAnimations, 
			AvatarAssetGroupsEnum.BodyParts => _AvatarDomainFactories.RecentItemListTypeEntityFactory.BodyParts, 
			AvatarAssetGroupsEnum.Clothing => _AvatarDomainFactories.RecentItemListTypeEntityFactory.Clothing, 
			AvatarAssetGroupsEnum.Gear => _AvatarDomainFactories.RecentItemListTypeEntityFactory.Gear, 
			_ => null, 
		};
	}

	private IRecentItemListTypeEntity GetListType(RecentItemListTypeEnum itemListTypeEnum)
	{
		byte listTypeId = (byte)itemListTypeEnum;
		return _AvatarDomainFactories.RecentItemListTypeEntityFactory.Get(listTypeId) ?? throw new PlatformArgumentNullException(string.Format("Could not retrieve a ListType corresponding to {0} enum {1}", "RecentItemListTypeEnum", itemListTypeEnum));
	}

	private IRecentItemListTypeEntity GetListType(RecentItem item)
	{
		if (item.TypeId == _AvatarDomainFactories.RecentItemTypeEntityFactory.Asset.Id)
		{
			Roblox.Platform.Assets.IAsset asset = _AvatarDomainFactories.AssetFactory.GetAsset(item.TargetId);
			Roblox.Platform.Assets.AssetType? assetType = _AvatarDomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
			AvatarAssetGroupsEnum? assetGroup = _AvatarDomainFactories.AvatarAssetGroupFactory.GetAssetGroup(assetType);
			if (!assetGroup.HasValue)
			{
				return null;
			}
			return GetListType(assetGroup);
		}
		if (item.TypeId == _AvatarDomainFactories.RecentItemTypeEntityFactory.Outfit.Id)
		{
			return _AvatarDomainFactories.RecentItemListTypeEntityFactory.Outfits;
		}
		return null;
	}

	private ICollection<IUserAsset> GetLatestPageOfUserAssets(Roblox.Platform.Assets.AssetType assetType)
	{
		int maxAllowed = _AvatarDomainFactories.AvatarOwnershipFactory.MaxAllowedPageSize;
		ExclusiveStartKeyInfo<long> exclusiveStartKeyInfo = new ExclusiveStartKeyInfo<long>(SortOrder.Desc, PagingDirection.Forward, maxAllowed);
		int assetTypeId = assetType.ToId(_AvatarDomainFactories.AssetTypeFactory);
		long userId = _User.Id;
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (assetTypeId <= 0)
		{
			throw new PlatformArgumentException("assetTypeId");
		}
		if (userId <= 0)
		{
			throw new PlatformArgumentException("userId");
		}
		if (!_AvatarDomainFactories.AvatarOwnershipFactory.AllowedPageSizes.Contains(exclusiveStartKeyInfo.Count))
		{
			throw new PlatformArgumentException(string.Format("{0} has invalid count! Must be in AllowedPageSizes", "exclusiveStartKeyInfo"));
		}
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		SortOrder sortOrder = (exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(SortOrder.Asc) ? SortOrder.Asc : SortOrder.Desc);
		return new PlatformPageResponse<long, IUserAsset>(AvatarOwnershipFactory.GetUserAssetsByUserIdAndAssetTypeId(userId, assetTypeId, exclusiveStartId, exclusiveStartKeyInfo.Count + 1, sortOrder).ToArray(), exclusiveStartKeyInfo, (IUserAsset userAsset) => userAsset.Id).Items;
	}

	private ICollection<RecentItem> GetRecentItemsFromExistingUserAssets(ICollection<Roblox.Platform.Assets.AssetType> assetTypes)
	{
		List<RecentItem> recentItems = new List<RecentItem>();
		foreach (Roblox.Platform.Assets.AssetType assetType2 in assetTypes)
		{
			foreach (IUserAsset userAsset in GetLatestPageOfUserAssets(assetType2))
			{
				if (IsUserAssetValidForRecentItems(userAsset))
				{
					RecentItem recentItem2 = new RecentItem(userAsset.AssetId, _AvatarDomainFactories.RecentItemTypeEntityFactory.Asset, userAsset.Created);
					recentItems.Add(recentItem2);
				}
			}
		}
		IEnumerable<long> enumerable = from wa in _AvatarDomainFactories.AvatarFactory.GetAvatar(_User.Id).GetWornAssets(checkIfDefaultClothingNeeded: false)
			select wa.AssetId;
		DateTime date = DateTime.Now;
		foreach (long assetId in enumerable)
		{
			Roblox.Platform.Assets.IAsset asset = _AvatarDomainFactories.AssetFactory.GetAsset(assetId);
			Roblox.Platform.Assets.AssetType? assetType = asset.GetAssetType(_AvatarDomainFactories.AssetTypeFactory);
			if (assetType.HasValue && assetTypes.Contains(assetType.Value))
			{
				RecentItem recentItem = new RecentItem(asset.Id, _AvatarDomainFactories.RecentItemTypeEntityFactory.Asset, date);
				recentItems.Add(recentItem);
			}
		}
		return recentItems;
	}

	private ICollection<RecentItem> GetRecentItemsFromExistingUserOutfits()
	{
		List<RecentItem> recentItems = new List<RecentItem>();
		foreach (IUserOutfit userOutfit in _AvatarDomainFactories.OutfitDomainFactories.UserOutfitFactory.GetUserOutfitsPagedResult(_User, 0, RecentListDataProvider.MaxRecentItems()).PageItems)
		{
			if (IsUserOutfitValidForRecentItems(userOutfit))
			{
				RecentItem recentItem = new RecentItem(userOutfit.Id, _AvatarDomainFactories.RecentItemTypeEntityFactory.Outfit, userOutfit.Updated);
				recentItems.Add(recentItem);
			}
		}
		return recentItems;
	}

	private void PopulateList(RecentListDataProvider list, bool retrievingBeforeSave)
	{
		List<RecentItem> recentItems = new List<RecentItem>();
		AvatarAssetGroupsEnum? avatarAssetGroup = null;
		if (list.ItemListType.Id == _AvatarDomainFactories.RecentItemListTypeEntityFactory.Clothing.Id)
		{
			avatarAssetGroup = AvatarAssetGroupsEnum.Clothing;
		}
		else if (list.ItemListType.Id == _AvatarDomainFactories.RecentItemListTypeEntityFactory.BodyParts.Id)
		{
			avatarAssetGroup = AvatarAssetGroupsEnum.BodyParts;
		}
		else if (list.ItemListType.Id == _AvatarDomainFactories.RecentItemListTypeEntityFactory.AvatarAnimations.Id)
		{
			avatarAssetGroup = AvatarAssetGroupsEnum.AvatarAnimations;
		}
		else if (list.ItemListType.Id == _AvatarDomainFactories.RecentItemListTypeEntityFactory.Accessories.Id)
		{
			avatarAssetGroup = AvatarAssetGroupsEnum.Accessories;
		}
		else if (list.ItemListType.Id == _AvatarDomainFactories.RecentItemListTypeEntityFactory.Gear.Id)
		{
			avatarAssetGroup = AvatarAssetGroupsEnum.Gear;
		}
		if (avatarAssetGroup.HasValue)
		{
			ICollection<Roblox.Platform.Assets.AssetType> assetTypes = _AvatarDomainFactories.AvatarAssetGroupFactory.GetAssetTypes(avatarAssetGroup.Value);
			ICollection<RecentItem> items2 = GetRecentItemsFromExistingUserAssets(assetTypes);
			recentItems.AddRange(items2);
		}
		else
		{
			if (list.ItemListType.Id != _AvatarDomainFactories.RecentItemListTypeEntityFactory.Outfits.Id)
			{
				throw new PlatformArgumentException(string.Format("ListType {0} is not being handled in method {1}", list.ItemListType.Value, "PopulateList"));
			}
			ICollection<RecentItem> items = GetRecentItemsFromExistingUserOutfits();
			recentItems.AddRange(items);
		}
		foreach (RecentItem recentItem in recentItems)
		{
			list.Add(recentItem);
		}
		if (!retrievingBeforeSave)
		{
			list.Save();
		}
	}
}
