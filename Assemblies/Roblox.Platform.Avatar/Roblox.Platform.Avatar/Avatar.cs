using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Roblox.Common;
using Roblox.DataV2.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.Platform.Outfits;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Manages rules for wearing/removing userAssets
/// </summary>
internal class Avatar : IAvatar
{
	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly HashSet<Roblox.Platform.Assets.AssetType> _FullyQualifiedOutfitAssetTypeIds;

	/// <summary>
	/// When making changes to the avatar, we only want to mark it as ready for a new thumbnail when all the accoutrements/changes have occurred
	/// </summary>
	private bool _ThumbnailDirty;

	private bool _Loaded;

	private ICollection<IAccoutrement> _Accoutrements;

	private OutfitDomainFactories OutfitDomainFactories => _AvatarDomainFactories.OutfitDomainFactories;

	private DefaultClothingEnforcer DefaultClothingEnforcer => _AvatarDomainFactories.DefaultClothingEnforcer;

	private IAccoutrementFactory AccoutrementFactory => _AvatarDomainFactories.AccoutrementFactory;

	private IAccoutrementBuilder AccoutrementBuilder => _AvatarDomainFactories.AccoutrementBuilder;

	private IUserAvatarFactory UserAvatarFactory => _AvatarDomainFactories.UserAvatarFactory;

	private AccoutrementRulesAuthority AccoutrementRulesAuthority => _AvatarDomainFactories.AccoutrementRulesAuthority;

	private IAvatarOwnershipFactory AvatarOwnershipFactory => _AvatarDomainFactories.AvatarOwnershipFactory;

	private IAssetFactory AssetFactory => _AvatarDomainFactories.AssetFactory;

	private ISettings Settings => _AvatarDomainFactories.Settings;

	private IAvatarChangeIdentifier AvatarChangeIdentifier => _AvatarDomainFactories.AvatarChangeIdentifier;

	private IAssetTypeFactory AssetTypeFactory => _AvatarDomainFactories.AssetTypeFactory;

	public IUser User { get; }

	public long UserId => User.Id;

	private IReadOnlyCollection<IAccoutrement> Accoutrements
	{
		get
		{
			if (!_Loaded)
			{
				LoadAccoutrements(mustCheckWearingRules: false);
			}
			return (IReadOnlyCollection<IAccoutrement>)_Accoutrements;
		}
	}

	/// <summary>
	/// Avatar being changed
	/// Asset IDs being worn
	/// Asset IDs being unworn
	/// </summary>
	public static event Action<IAvatar, List<long>, List<long>> AssetsChangedEvent;

	public static event Action<IAvatar, IUserOutfit> OutfitWornEvent;

	private void RefreshThumbnailIfDirty()
	{
		if (_ThumbnailDirty)
		{
			UserAvatarFactory.GetOrCreate(User.Id).ClearThumbnail();
			_ThumbnailDirty = false;
		}
	}

	/// <summary>
	/// This is called once for each "avatar change" action the user does.
	/// This should (only) be called at the end of every public method which changes the avatar - no intermediate states.
	///
	/// It triggers regeneration of thumbnail, if anything actually changed about the user's appearance.
	/// </summary>
	private void AvatarChanged(AvatarChangedEventArgs args)
	{
		RefreshThumbnailIfDirty();
		_AvatarDomainFactories.AvatarFactory.InvokeAppearanceChangeEvent(args);
	}

	/// <summary>
	/// Overload of <see cref="M:Roblox.Platform.Avatar.Avatar.AvatarChanged(Roblox.Platform.EventStream.WebEvents.AvatarChangedEventArgs)"></see>
	/// </summary>
	/// <param name="avatarChangeType"></param>
	private void AvatarChanged(AvatarChangeTypeEnum avatarChangeType)
	{
		AvatarChanged(new AvatarChangedEventArgs(UserId, avatarChangeType));
	}

	private void AvatarChangedWithAssets(IEnumerable<Roblox.Platform.Assets.IAsset> wornAssets, bool wearing)
	{
		RefreshThumbnailIfDirty();
		foreach (Roblox.Platform.Assets.IAsset asset in wornAssets)
		{
			AvatarChangeTypeEnum changeType = AvatarChangeIdentifier.GetChangeType(asset.TypeId, wearing);
			AvatarAssetGroupsEnum? avatarAssetGroup = AvatarChangeIdentifier.GetAssetGroup(asset.TypeId);
			AvatarChangedEventArgs args = new AvatarChangedEventArgs(UserId, changeType, avatarAssetGroup, asset.Id, asset.TypeId, wearing);
			AvatarChanged(args);
		}
	}

	internal Avatar(IUser user, HashSet<Roblox.Platform.Assets.AssetType> fullyQualifiedOutfitAssetTypeIds, AvatarDomainFactories avatarDomainFactories)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_FullyQualifiedOutfitAssetTypeIds = fullyQualifiedOutfitAssetTypeIds ?? throw new PlatformArgumentNullException("fullyQualifiedOutfitAssetTypeIds");
		User = user;
	}

	/// <summary>
	/// Update cached Accoutrements from the db.
	/// </summary>
	/// <param name="mustCheckWearingRules">whether to force check wearing rules (for important cases, like game join).</param>
	/// <param name="accessoryLimitMode"></param>
	private void LoadAccoutrements(bool mustCheckWearingRules, AccessoryLimitModeEnum accessoryLimitMode = AccessoryLimitModeEnum.TenTotalAccessories)
	{
		_Accoutrements = AccoutrementFactory.GetUserAccoutrementsNoFilter(User.Id).ToList();
		AccoutrementSetBuilder accoutrementSetBuilder = new AccoutrementSetBuilder(User, _AvatarDomainFactories);
		accoutrementSetBuilder.LoadAccoutrements();
		if (mustCheckWearingRules)
		{
			accoutrementSetBuilder.EnforceWearingLimits(accessoryLimitMode);
		}
		if (accoutrementSetBuilder.HasPendingChanges())
		{
			PersistAccoutrementDeletions(_Accoutrements.ToList().AsReadOnly(), accoutrementSetBuilder);
		}
		_Loaded = true;
	}

	private void PersistAccoutrementDeletions(IReadOnlyCollection<IAccoutrement> accoutrements, AccoutrementSetBuilder accoutrementSetBuilder)
	{
		HashSet<IAccoutrement> accoutrementsToRemove = new HashSet<IAccoutrement>();
		HashSet<long> accoutrementAssetIdsLookup = new HashSet<long>();
		IDictionary<long, IUserAsset> userAssetsDict = new Dictionary<long, IUserAsset>();
		if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
		{
			HashSet<long> accoutrementUserAssetIds = new HashSet<long>(accoutrements.Select((IAccoutrement a) => a.UserAssetID));
			userAssetsDict = AvatarOwnershipFactory.GetUserAssetsByUserAssetIds(accoutrementUserAssetIds);
		}
		foreach (IAccoutrement accoutrement in accoutrements)
		{
			IUserAsset userAsset;
			if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
			{
				userAssetsDict.TryGetValue(accoutrement.UserAssetID, out userAsset);
			}
			else
			{
				userAsset = AvatarOwnershipFactory.GetUserAssetByUserAssetId(accoutrement.UserAssetID);
			}
			if (userAsset == null)
			{
				accoutrementsToRemove.Add(accoutrement);
				continue;
			}
			Roblox.Platform.Assets.IAsset asset = AssetFactory.GetAsset(userAsset.AssetId);
			if (!accoutrementSetBuilder.Contains(asset))
			{
				accoutrementsToRemove.Add(accoutrement);
			}
			else if (accoutrementAssetIdsLookup.Contains(asset.Id))
			{
				accoutrementsToRemove.Add(accoutrement);
			}
			accoutrementAssetIdsLookup.Add(asset.Id);
		}
		DoRemove(accoutrementsToRemove);
	}

	private void CheckIfAccoutrementTiedToOtherUser(IUserAsset userAsset, ref bool addedAccoutrements)
	{
		IAccoutrement accoutrement = AccoutrementFactory.GetByUserAssetID(userAsset.Id);
		if (accoutrement != null && accoutrement.UserID != UserId)
		{
			_AvatarDomainFactories.Logger.Verbose(() => $"Accoutrement for UserAssetID={userAsset.Id} was tied previous owner userID={accoutrement.UserID} but it is owned by userID={UserId}");
			accoutrement.Delete();
			try
			{
				AccoutrementBuilder.CreateNew(User.Id, userAsset.Id);
				addedAccoutrements = true;
			}
			catch (DuplicateAccoutrementInsertException ex)
			{
				_AvatarDomainFactories.Logger.Error($"Tried to wear accoutrement but it was tied to another userId. Deleting and creating threw this exception: {ex}");
			}
		}
	}

	private void PersistAccoutrementAdditions(AccoutrementSetBuilder accoutrementSetBuilder, ICollection<long> alreadyWornAssetIds, out bool addedAccoutrements)
	{
		List<IUserAsset> list = (from a in (from a in accoutrementSetBuilder.GetAssets()
				where !alreadyWornAssetIds.Contains(a.Id)
				select a).ToList()
			select AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(User.Id, a.Id).FirstOrDefault()).ToList();
		addedAccoutrements = false;
		foreach (IUserAsset userAsset in list)
		{
			if (userAsset != null)
			{
				try
				{
					AccoutrementBuilder.CreateNew(User.Id, userAsset.Id);
					addedAccoutrements = true;
				}
				catch (DuplicateAccoutrementInsertException)
				{
					CheckIfAccoutrementTiedToOtherUser(userAsset, ref addedAccoutrements);
				}
			}
		}
	}

	private void DoWearV2(ICollection<Roblox.Platform.Assets.IAsset> assets, bool resetCurrentAppearance, AccessoryLimitModeEnum accessoryLimitMode, bool isWearingOutfit = false)
	{
		assets = assets.Where((Roblox.Platform.Assets.IAsset a) => a != null).ToList();
		AccoutrementRulesAuthority.ValidateWearRequest(assets);
		AccoutrementSetBuilder accoutrementSetBuilder = new AccoutrementSetBuilder(User, _AvatarDomainFactories);
		accoutrementSetBuilder.LoadAccoutrements();
		List<long> alreadyWornAssetIds = (from a in accoutrementSetBuilder.GetAssets()
			select a.Id).ToList();
		if (resetCurrentAppearance)
		{
			accoutrementSetBuilder.Reset();
		}
		foreach (Roblox.Platform.Assets.IAsset asset in assets)
		{
			accoutrementSetBuilder.Add(asset);
		}
		accoutrementSetBuilder.EnforceWearingLimits(accessoryLimitMode);
		IReadOnlyCollection<IAccoutrement> accoutrements = GetAccoutrements();
		PersistAccoutrementDeletions(accoutrements, accoutrementSetBuilder);
		PersistAccoutrementAdditions(accoutrementSetBuilder, alreadyWornAssetIds, out var addedAccoutrements);
		if (addedAccoutrements || resetCurrentAppearance)
		{
			_ThumbnailDirty = true;
		}
		LoadAccoutrements(addedAccoutrements, accessoryLimitMode);
		List<long> assetIdsToWear = assets.Select((Roblox.Platform.Assets.IAsset a) => a.Id).ToList();
		IEnumerable<long> assetIdsWornAfter = from el in GetWornAssets(checkIfDefaultClothingNeeded: false)
			select el.AssetId;
		List<Roblox.Platform.Assets.IAsset> wearingPackages = assets.Where((Roblox.Platform.Assets.IAsset a) => AccoutrementRulesAuthority.IsPackage(a.TypeId)).ToList();
		long? packageAssetId = (wearingPackages.Any() ? new long?(wearingPackages.First().Id) : null);
		AssetChangeDiff diff = new AssetChangeDiff(_AvatarDomainFactories, alreadyWornAssetIds.ToList(), assetIdsToWear, assetIdsWornAfter.ToList(), isWearingOutfit, packageAssetId, resetCurrentAppearance);
		FireAssetChangedEvents(diff);
	}

	private void FireAssetChangedEvents(AssetChangeDiff diff)
	{
		List<long> recentWornItems = diff.GetRecentItemsAdded();
		List<long> recentUnwornItems = diff.GetRecentItemsUnworn();
		if (recentWornItems.Any() || recentUnwornItems.Any())
		{
			Avatar.AssetsChangedEvent?.Invoke(this, recentWornItems, recentUnwornItems);
		}
		List<Roblox.Platform.Assets.IAsset> addedAssets = (from i in diff.GetAssetsAddedByUser()
			select AssetFactory.GetAsset(i)).ToList();
		List<Roblox.Platform.Assets.IAsset> removedAssets = (from i in diff.GetAssetsUnwornByUser()
			select AssetFactory.GetAsset(i)).ToList();
		if (addedAssets.Any())
		{
			AvatarChangedWithAssets(addedAssets, wearing: true);
		}
		if (removedAssets.Any())
		{
			AvatarChangedWithAssets(removedAssets, wearing: false);
		}
	}

	/// <summary>
	/// Delete accoutrement from the db, and delete it from this avatar's cache.
	/// </summary>
	private bool DoRemove(IEnumerable<IAccoutrement> accoutrements)
	{
		accoutrements = accoutrements.ToList();
		bool removed = false;
		if (accoutrements.Any())
		{
			foreach (IAccoutrement accoutrement in accoutrements)
			{
				if (accoutrement != null)
				{
					_ThumbnailDirty = true;
					accoutrement.Delete();
					removed = true;
				}
				if (_Loaded && _Accoutrements.Contains(accoutrement))
				{
					_Accoutrements.Remove(accoutrement);
				}
			}
		}
		return removed;
	}

	private IBrickBodyColorSet Translate(IBodyColorSet bodyColorSet)
	{
		return OutfitDomainFactories.BrickBodyColorSetFactory.FromBodyColorSet(bodyColorSet);
	}

	private IBodyColorSet GetDefaultBodyColors()
	{
		BrickColor headAndArmsColor = BrickColor.GetRandomHeadColor();
		BrickColor legsColor = BrickColor.Get(102);
		BrickColor torsoColor = BrickColor.GetRandom();
		IBrickBodyColorSet brickBodyColorSet = OutfitDomainFactories.BrickBodyColorSetFactory.Create(headAndArmsColor.ID, headAndArmsColor.ID, legsColor.ID, headAndArmsColor.ID, legsColor.ID, torsoColor.ID);
		return OutfitDomainFactories.BodyColorSetFactory.GetOrCreate(brickBodyColorSet);
	}

	private void EnsureBodyColorsAreCreated(IUserAvatar userAvatar)
	{
		if (!userAvatar.BodyColorSetID.HasValue)
		{
			OutfitDomainFactories.BodyColorsPerformanceCounter?.SetupDefaultBodyColorSetID.Increment();
			IBodyColorSet bodyColorSet = GetDefaultBodyColors();
			userAvatar.BodyColorSetID = bodyColorSet.ID;
			userAvatar.Save();
		}
	}

	public long? GetBodyColorSetId()
	{
		IUserAvatar userAvatar = UserAvatarFactory.GetOrCreate(User.Id);
		EnsureBodyColorsAreCreated(userAvatar);
		return userAvatar.BodyColorSetID;
	}

	public IBrickBodyColorSet GetBodyColors()
	{
		IUserAvatar userAvatar = UserAvatarFactory.GetOrCreate(User.Id);
		if (userAvatar == null)
		{
			throw new PlatformDataIntegrityException($"UserAvatar does not exist for User ID {User.Id}");
		}
		EnsureBodyColorsAreCreated(userAvatar);
		if (!userAvatar.BodyColorSetID.HasValue)
		{
			throw new PlatformDataIntegrityException(string.Format("BodyColorSetID still not initialized for UserAvatar ID {0} in {1}", userAvatar.ID, "GetBodyColors"));
		}
		OutfitDomainFactories.BodyColorsPerformanceCounter?.ReadBodyColorSetID.Increment();
		IBodyColorSet bodyColorSet = OutfitDomainFactories.BodyColorSetFactory.GetById(userAvatar.BodyColorSetID.Value);
		return Translate(bodyColorSet);
	}

	public void SetBodyColors(IBrickBodyColorSet brickBodyColorSet)
	{
		IUserAvatar userAvatar = UserAvatarFactory.GetOrCreate(User.Id);
		string oldAvatarHash = userAvatar.AvatarHash;
		long? oldBodyColorSetId = userAvatar.BodyColorSetID;
		bool bodyColorSetIdChanged = false;
		IBodyColorSet bodyColorSet = OutfitDomainFactories.BodyColorSetFactory.GetOrCreate(brickBodyColorSet);
		if (bodyColorSet.ID != oldBodyColorSetId)
		{
			userAvatar.BodyColorSetID = bodyColorSet.ID;
			userAvatar.Save();
			OutfitDomainFactories.BodyColorsPerformanceCounter?.WriteBodyColorSetID.Increment();
			if (!string.IsNullOrEmpty(oldAvatarHash) || bodyColorSet.BodyColorSetHash != oldAvatarHash)
			{
				bodyColorSetIdChanged = true;
			}
		}
		if (!Settings.StopWritingBodyColorsToAvatarHash)
		{
			string avatarHash;
			XmlDocument avatarXml = OutfitDomainFactories.BodyColorsXmlSerializer.GetBodyColorsXmlDocumentFromUserAvatar(userAvatar, out avatarHash);
			IBodyColorsXmlSerializer bodyColorsXmlSerializer = OutfitDomainFactories.BodyColorsXmlSerializer;
			bodyColorsXmlSerializer.SetBodyColor("HeadColor", BrickColor.Get(brickBodyColorSet.HeadBrickColorId), avatarXml);
			bodyColorsXmlSerializer.SetBodyColor("LeftArmColor", BrickColor.Get(brickBodyColorSet.LeftArmBrickColorId), avatarXml);
			bodyColorsXmlSerializer.SetBodyColor("LeftLegColor", BrickColor.Get(brickBodyColorSet.LeftLegBrickColorId), avatarXml);
			bodyColorsXmlSerializer.SetBodyColor("RightArmColor", BrickColor.Get(brickBodyColorSet.RightArmBrickColorId), avatarXml);
			bodyColorsXmlSerializer.SetBodyColor("RightLegColor", BrickColor.Get(brickBodyColorSet.RightLegBrickColorId), avatarXml);
			bodyColorsXmlSerializer.SetBodyColor("TorsoColor", BrickColor.Get(brickBodyColorSet.TorsoBrickColorId), avatarXml);
			bodyColorsXmlSerializer.PersistAvatar(userAvatar, avatarXml);
			OutfitDomainFactories.BodyColorsPerformanceCounter?.WriteAvatarHash.Increment();
		}
		if (UserAvatarFactory.GetOrCreate(User.Id).AvatarHash != oldAvatarHash || bodyColorSetIdChanged)
		{
			_ThumbnailDirty = true;
			AvatarChanged(AvatarChangeTypeEnum.SetBodyColors);
		}
	}

	public IReadOnlyDictionary<int, int> GetWornAssetTypeIdCounts()
	{
		IReadOnlyCollection<IAccoutrement> accoutrements = GetAccoutrements();
		IEnumerable<IUserAsset> userAssets;
		if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
		{
			HashSet<long> accoutrementUserAssetIds = new HashSet<long>(accoutrements.Select((IAccoutrement a) => a.UserAssetID));
			userAssets = (from ua in AvatarOwnershipFactory.GetUserAssetsByUserAssetIds(accoutrementUserAssetIds)
				select ua.Value).ToList();
		}
		else
		{
			userAssets = from acc in accoutrements
				select AvatarOwnershipFactory.GetUserAssetByUserAssetId(acc.UserAssetID) into ua
				where ua != null
				select ua;
		}
		return (from ua in userAssets
			select ua.AssetTypeId into ua
			group ua by ua).ToDictionary((IGrouping<int, int> kvp) => kvp.Key, (IGrouping<int, int> kvp) => kvp.Count());
	}

	/// <summary>
	/// For default clothing; is the user wearing an (approved) item of the given assetType?
	/// </summary>
	public bool IsWearingApprovedAssetType(int assetTypeId, out bool wearingUnapprovedAsset)
	{
		wearingUnapprovedAsset = false;
		IDictionary<long, IUserAsset> userAssets = new Dictionary<long, IUserAsset>();
		if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
		{
			HashSet<long> accoutrementUserAssetIds = new HashSet<long>(Accoutrements.Select((IAccoutrement a) => a.UserAssetID));
			userAssets = AvatarOwnershipFactory.GetUserAssetsByUserAssetIds(accoutrementUserAssetIds);
		}
		foreach (IAccoutrement acc in Accoutrements)
		{
			IUserAsset userAsset;
			if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
			{
				userAssets.TryGetValue(acc.UserAssetID, out userAsset);
			}
			else
			{
				userAsset = AvatarOwnershipFactory.GetUserAssetByUserAssetId(acc.UserAssetID);
			}
			if (userAsset != null && userAsset.AssetTypeId == assetTypeId)
			{
				Asset asset = Asset.Get(userAsset.AssetId);
				if (asset != null && asset.IsApproved)
				{
					return true;
				}
				wearingUnapprovedAsset = true;
				return false;
			}
		}
		return false;
	}

	public PlayerAvatarType GetDefaultPlayerAvatarType()
	{
		return AvatarPlaceSettingsResolver.InterpretPlayerAvatarTypeSetting(Roblox.Platform.Avatar.Properties.Settings.Default.DefaultPlayerAvatarType) ?? PlayerAvatarType.R6;
	}

	public PlayerAvatarType GetPlayerAvatarType()
	{
		PlayerAvatarType? playerAvatarTypeOverride = AvatarPlaceSettingsResolver.InterpretPlayerAvatarTypeSetting(Roblox.Platform.Avatar.Properties.Settings.Default.OverridePlayerAvatarType);
		if (playerAvatarTypeOverride.HasValue)
		{
			return playerAvatarTypeOverride.Value;
		}
		PlayerAvatarType? playerAvatarType = EnumUtils.StrictTryParseEnum<PlayerAvatarType>(UserAvatarFactory.GetOrCreate(User.Id).PlayerAvatarTypeID?.ToString() ?? string.Empty);
		if (playerAvatarType.HasValue)
		{
			return playerAvatarType.Value;
		}
		return GetDefaultPlayerAvatarType();
	}

	public void SetPlayerAvatarType(PlayerAvatarType playerAvatarType)
	{
		if (!EnumUtils.StrictTryParseEnum<PlayerAvatarType>(playerAvatarType.ToString()).HasValue)
		{
			throw new PlatformInvalidEnumArgumentException("Invalid player avatar type");
		}
		bool playerAvatarTypeChanged = false;
		IUserAvatar userAvatar = null;
		userAvatar = UserAvatarFactory.GetOrCreate(User.Id);
		PlayerAvatarType? currentPlayerAvatarType = EnumUtils.StrictTryParseEnum<PlayerAvatarType>(userAvatar.PlayerAvatarTypeID.ToString());
		if (!currentPlayerAvatarType.HasValue || currentPlayerAvatarType.Value != playerAvatarType)
		{
			playerAvatarTypeChanged = true;
			userAvatar.PlayerAvatarTypeID = (byte)playerAvatarType;
			userAvatar.Save();
		}
		if (playerAvatarTypeChanged)
		{
			_ThumbnailDirty = true;
			AvatarChanged(new AvatarChangedEventArgs(UserId, AvatarChangeTypeEnum.SetPlayerAvatarType, playerAvatarType));
		}
	}

	/// <summary>
	/// Returns the user's gear in userAsset Creation order.  We have to read all of them to be sure to get it in the right order.
	/// </summary>
	public IReadOnlyCollection<Asset> GetGear(int startRowIndex, int maximumRows)
	{
		List<IUserAsset> userAssets = new List<IUserAsset>();
		ExclusiveStartKeyInfo<long> exclusiveStartKeyInfo = new ExclusiveStartKeyInfo<long>(long.MaxValue, SortOrder.Desc, PagingDirection.Forward, _AvatarDomainFactories.AvatarOwnershipFactory.MaxAllowedPageSize);
		do
		{
			IPlatformPageResponse<long, IUserAsset> userAssetsPageResponse = _AvatarDomainFactories.AvatarOwnershipFactory.GetOwnedUserAssetsByAssetTypeIdPaged(User.Id, AssetType.GearID, exclusiveStartKeyInfo);
			userAssets.AddRange(userAssetsPageResponse.Items);
			exclusiveStartKeyInfo = (userAssetsPageResponse.TryGetNextPageExclusiveStartKey(out var exclusiveStartId) ? new ExclusiveStartKeyInfo<long>(exclusiveStartId, SortOrder.Desc, PagingDirection.Forward, _AvatarDomainFactories.AvatarOwnershipFactory.MaxAllowedPageSize) : null);
		}
		while (exclusiveStartKeyInfo != null);
		return (from ua in userAssets.OrderByDescending((IUserAsset ua) => ua.Created).Skip(startRowIndex).Take(maximumRows)
			select Asset.Get(ua.AssetId)).ToList();
	}

	public void WearAsset(long assetId, bool resetCurrentAppearance = false)
	{
		Roblox.Platform.Assets.IAsset asset = AssetFactory.GetAsset(assetId);
		List<Roblox.Platform.Assets.IAsset> assets = new List<Roblox.Platform.Assets.IAsset> { asset };
		AccessoryLimitModeEnum accessoryLimitMode = AccessoryLimitModeEnum.TenTotalAccessories;
		if (AccoutrementRulesAuthority.IsPackage(asset.TypeId) || AccoutrementRulesAuthority.IsAccessory(asset.TypeId))
		{
			accessoryLimitMode = AccessoryLimitModeEnum.ThreeHats;
		}
		DoWearV2(assets, resetCurrentAppearance, accessoryLimitMode);
	}

	public void WearAssets(IEnumerable<long> assetIds, bool resetCurrentAppearance = false, AccessoryLimitModeEnum accessoryLimitMode = AccessoryLimitModeEnum.TenTotalAccessories)
	{
		List<Roblox.Platform.Assets.IAsset> assets = assetIds.Select((long id) => AssetFactory.GetAsset(id)).ToList();
		DoWearV2(assets, resetCurrentAppearance, accessoryLimitMode);
	}

	private void RemoveUserAsset(IUserAsset userAsset)
	{
		if (AccoutrementRulesAuthority.UserMayRemoveUserAsset(User.Id, userAsset))
		{
			IAccoutrement accoutrement = AccoutrementFactory.GetByUserAssetID(userAsset.Id);
			if (DoRemove(new List<IAccoutrement> { accoutrement }))
			{
				Roblox.Platform.Assets.IAsset asset = AssetFactory.GetAsset(userAsset.AssetId);
				AvatarChangedWithAssets(new List<Roblox.Platform.Assets.IAsset> { asset }, wearing: false);
				List<long> assetIdsBeingWorn = new List<long>(0);
				List<long> assetIdsBeingUnworn = new List<long> { userAsset.AssetId };
				Avatar.AssetsChangedEvent?.Invoke(this, assetIdsBeingWorn, assetIdsBeingUnworn);
			}
		}
	}

	public void RemoveAsset(long assetId)
	{
		IUserAsset userAsset = AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(UserId, assetId).FirstOrDefault();
		RemoveUserAsset(userAsset);
	}

	public bool IsWearingUserAsset(long userAssetId)
	{
		return Accoutrements.Any((IAccoutrement acc) => acc.UserAssetID == userAssetId);
	}

	/// <param name="mustCheckWearingRules">optionally, also check wearing business rules.</param>
	private IReadOnlyCollection<IAccoutrement> GetAccoutrements(bool mustCheckWearingRules = false)
	{
		LoadAccoutrements(mustCheckWearingRules);
		return Accoutrements.Where((IAccoutrement acc) => acc != null).ToList();
	}

	/// <summary>
	/// Single point of access for worn items on an avatar.
	/// </summary>
	/// <param name="mustCheckWearingRules">Should we revalidate the business rules about wearing slots &amp; accessories</param>
	/// <param name="checkIfDefaultClothingNeeded">If default clothing is released, then check the user for the necessity of including it.</param>
	/// <returns></returns>
	public IReadOnlyCollection<IWornAsset> GetWornAssets(bool checkIfDefaultClothingNeeded, bool mustCheckWearingRules = false)
	{
		IReadOnlyCollection<IAccoutrement> accoutrements = GetAccoutrements(mustCheckWearingRules);
		List<WornAsset> wornAssets = new List<WornAsset>();
		IDictionary<long, IUserAsset> userAssets = new Dictionary<long, IUserAsset>();
		if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
		{
			HashSet<long> accoutrementUserAssetIds = new HashSet<long>(Accoutrements.Select((IAccoutrement a) => a.UserAssetID));
			userAssets = AvatarOwnershipFactory.GetUserAssetsByUserAssetIds(accoutrementUserAssetIds);
		}
		foreach (IAccoutrement acc in accoutrements)
		{
			if (acc != null)
			{
				IUserAsset userAsset;
				if (UserId % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
				{
					userAssets.TryGetValue(acc.UserAssetID, out userAsset);
				}
				else
				{
					userAsset = AvatarOwnershipFactory.GetUserAssetByUserAssetId(acc.UserAssetID);
				}
				if (userAsset != null)
				{
					bool isGear = userAsset.AssetTypeId == Roblox.Platform.Assets.AssetType.Gear.ToId(AssetTypeFactory);
					bool isAnimation = AccoutrementRulesAuthority.IsAnimation(userAsset.AssetTypeId);
					long assetId = userAsset.AssetId;
					WornAsset wa = new WornAsset(userAsset.AssetTypeId, assetId, isGear, isGear, isAnimation);
					wornAssets.Add(wa);
				}
			}
		}
		if (checkIfDefaultClothingNeeded)
		{
			DefaultClothingEnforcer.TryAddDefaultClothing(wornAssets, this);
		}
		return (IReadOnlyCollection<IWornAsset>)(object)wornAssets.ToArray();
	}

	public IUserOutfit CreateUserOutfit(IOutfit outfit, ITextFilterClientV2 textFilterClientV2, string outfitName = null)
	{
		IUserOutfit userOutfit = OutfitDomainFactories.UserOutfitFactory.CreateFromOutfit(User, outfit);
		if (OutfitDomainFactories.OutfitRulesManager.IsValidName(outfitName))
		{
			userOutfit.Rename(outfitName, User.ToClientTextAuthor(), textFilterClientV2);
		}
		AvatarChanged(AvatarChangeTypeEnum.CreateOutfit);
		return userOutfit;
	}

	public void UpdateUserOutfit(IUserOutfit userOutfit, IOutfit outfit)
	{
		userOutfit.UpdateFromOutfit(outfit);
		AvatarChanged(AvatarChangeTypeEnum.UpdateOutfit);
	}

	/// <summary>
	/// Wears a user outfit
	/// </summary>
	public ICollection<long> WearOutfit(IUserOutfit userOutfit)
	{
		if (userOutfit == null)
		{
			throw new PlatformArgumentNullException("userOutfit");
		}
		IOutfit outfit = OutfitDomainFactories.OutfitFactory.GetOutfit(userOutfit.OutfitId);
		List<long> assetIdsUnableToWear = new List<long>();
		if (outfit == null)
		{
			return assetIdsUnableToWear;
		}
		if (userOutfit.IsEditable)
		{
			IBrickBodyColorSet brickBodyColorSet = outfit.GetBodyColors();
			SetBodyColors(brickBodyColorSet);
		}
		List<IOutfitAccoutrementEntity> outfitAccoutrements = OutfitDomainFactories.OutfitAccoutrementFactory.GetAllOutfitAccoutrements(outfit.ID).ToList();
		List<IUserAsset> userAssetsToWear = new List<IUserAsset>();
		Dictionary<Roblox.Platform.Assets.AssetType, bool> fullyQualifiedOutfitDict = _FullyQualifiedOutfitAssetTypeIds.ToDictionary((Roblox.Platform.Assets.AssetType h) => h, (Roblox.Platform.Assets.AssetType h) => false);
		long userId = User.Id;
		foreach (IOutfitAccoutrementEntity item in outfitAccoutrements.ToList())
		{
			long assetId = item.AssetID;
			IUserAsset userAsset = AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(User.Id, assetId).FirstOrDefault();
			if (AccoutrementRulesAuthority.UserMayWearUserAsset(userId, userAsset))
			{
				userAssetsToWear.Add(userAsset);
				if (!userOutfit.IsEditable)
				{
					Roblox.Platform.Assets.AssetType? assetType = EnumUtils.StrictTryParseEnum<Roblox.Platform.Assets.AssetType>(userAsset.AssetTypeId.ToString());
					if (assetType.HasValue && fullyQualifiedOutfitDict.ContainsKey(assetType.Value))
					{
						fullyQualifiedOutfitDict[assetType.Value] = true;
					}
				}
			}
			else
			{
				assetIdsUnableToWear.Add(assetId);
			}
		}
		bool resetCurrentAppearance = userOutfit.IsEditable;
		bool setScaleAndAvatarType = true;
		if (!userOutfit.IsEditable)
		{
			resetCurrentAppearance = fullyQualifiedOutfitDict.Values.All((bool el) => el);
			setScaleAndAvatarType = !outfitAccoutrements.All((IOutfitAccoutrementEntity outfitAccoutrement) => AssetTypeFactory.GetAssetType(AssetFactory.GetAsset(outfitAccoutrement.AssetID).TypeId).ToString().ToLower()
				.Contains("animation"));
		}
		List<Roblox.Platform.Assets.IAsset> assets = (from id in outfitAccoutrements.Select((IOutfitAccoutrementEntity o) => o.AssetID).ToList()
			select AssetFactory.GetAsset(id)).ToList();
		DoWearV2(assets, resetCurrentAppearance, AccessoryLimitModeEnum.TenTotalAccessories, isWearingOutfit: true);
		if (setScaleAndAvatarType)
		{
			int scaleId = outfit.ScaleId;
			PlayerAvatarType? playerAvatarType = EnumUtils.StrictTryParseEnum<PlayerAvatarType>(outfit.PlayerAvatarTypeId.ToString());
			SetPlayerAvatarType(playerAvatarType ?? GetDefaultPlayerAvatarType());
			if (playerAvatarType.HasValue && playerAvatarType != PlayerAvatarType.R6)
			{
				Scale scale = OutfitDomainFactories.ScaleFactory.Get(scaleId);
				SetScale(scale.Height, scale.Width, scale.Head, scale.Proportion, scale.BodyType);
			}
		}
		AvatarChanged(AvatarChangeTypeEnum.WearOutfit);
		Avatar.OutfitWornEvent?.Invoke(this, userOutfit);
		return assetIdsUnableToWear;
	}

	private IAvatarScale HealScale(IUserAvatar userAvatar, Scale scale)
	{
		decimal? headValue = scale.Head;
		decimal? proportionValue = scale.Proportion;
		decimal? bodyTypeValue = scale.BodyType;
		decimal height = ScaleRules.Height.ClampAndRound(scale.Height);
		decimal width = ScaleRules.Width.ClampAndRound(scale.Width);
		decimal head = ScaleRules.Head.ClampAndRound(headValue.Value);
		decimal proportion = ScaleRules.Proportion.ClampAndRound(proportionValue.Value);
		decimal bodyType = ScaleRules.BodyType.ClampAndRound(bodyTypeValue.Value);
		Scale healedScale = OutfitDomainFactories.ScaleFactory.GetOrCreate(height, width, head, proportion, bodyType);
		if (userAvatar.ScaleID != healedScale.Id)
		{
			userAvatar.ScaleID = healedScale.Id;
			userAvatar.Save();
			_ThumbnailDirty = true;
			AvatarChangedEventArgs args = new AvatarChangedEventArgs(UserId, AvatarChangeTypeEnum.SetScale, this.GetScaleDescription(), healedScale.Head.Value, healedScale.Height, healedScale.Width, healedScale.Proportion.Value, healedScale.BodyType.Value);
			AvatarChanged(args);
		}
		return Translate(healedScale);
	}

	public IAvatarScale GetScale()
	{
		IUserAvatar userAvatar = UserAvatarFactory.GetOrCreate(User.Id);
		int? scaleId = userAvatar.ScaleID;
		if (Settings.OverrideAvatarScaleWithDefaults || !scaleId.HasValue)
		{
			return GetDefaultScale();
		}
		Scale scale = OutfitDomainFactories.ScaleFactory.Get(scaleId.Value);
		if (scale == null)
		{
			throw new PlatformDataIntegrityException($"Scale with ID {scaleId} for user ID {User.Id} not found in database");
		}
		if (!ScaleRules.Valid(scale.Height, scale.Width, scale.Head.Value, scale.Proportion.Value, scale.BodyType.Value))
		{
			return HealScale(userAvatar, scale);
		}
		return Translate(scale);
	}

	public IAvatarScale GetDefaultScale()
	{
		Scale defaultScale = OutfitDomainFactories.ScaleFactory.GetDefault();
		return Translate(defaultScale);
	}

	/// <summary>
	/// Updates the avatar scale
	/// If any of the scale dimensions are outside of the range of valid values, clamps to the valid range.
	/// If any of the values are zero, use defaults.
	/// </summary>
	/// <returns>False if any of the scales are outside the valid range</returns>
	public bool SetScale(decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType)
	{
		IUserAvatar userAvatar = UserAvatarFactory.GetOrCreate(User.Id);
		Scale existingScale = null;
		if (!head.HasValue || !proportion.HasValue || !bodyType.HasValue)
		{
			existingScale = (userAvatar.ScaleID.HasValue ? OutfitDomainFactories.ScaleFactory.Get(userAvatar.ScaleID.Value) : null);
		}
		bool valid;
		Scale clampedScale = OutfitDomainFactories.ScaleAuthority.GetClampedScale(out valid, height, width, head, proportion, bodyType, existingScale);
		height = clampedScale.Height;
		width = clampedScale.Width;
		head = clampedScale.Head;
		bodyType = clampedScale.BodyType;
		proportion = clampedScale.Proportion;
		Scale scale = OutfitDomainFactories.ScaleFactory.GetOrCreate(height, width, head.Value, proportion.Value, bodyType.Value);
		if (scale.Id != userAvatar.ScaleID)
		{
			userAvatar.ScaleID = scale.Id;
			userAvatar.Save();
			_ThumbnailDirty = true;
			AvatarChangedEventArgs args = new AvatarChangedEventArgs(UserId, AvatarChangeTypeEnum.SetScale, this.GetScaleDescription(), heightScale: scale.Height, widthScale: scale.Width, headScale: scale.Head.Value, proportionScale: scale.Proportion.Value, bodyTypeScale: scale.BodyType.Value);
			AvatarChanged(args);
		}
		return valid;
	}

	public IList<ScaleRules> CheckScale(decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType)
	{
		List<ScaleRules> scaleRulesViolated = new List<ScaleRules>();
		if (!ScaleRules.Height.InRange(height))
		{
			scaleRulesViolated.Add(ScaleRules.Height);
		}
		if (!ScaleRules.Width.InRange(width))
		{
			scaleRulesViolated.Add(ScaleRules.Width);
		}
		if (head.HasValue && !ScaleRules.Head.InRange(head.Value))
		{
			scaleRulesViolated.Add(ScaleRules.Head);
		}
		if (proportion.HasValue && !ScaleRules.Proportion.InRange(proportion.Value))
		{
			scaleRulesViolated.Add(ScaleRules.Proportion);
		}
		if (bodyType.HasValue && !ScaleRules.BodyType.InRange(bodyType.Value))
		{
			scaleRulesViolated.Add(ScaleRules.BodyType);
		}
		return scaleRulesViolated;
	}

	private IAvatarScale Translate(Scale scale)
	{
		return new AvatarScale(scale.Height, scale.Width, scale.Head.Value, ScaleRules.Depth.CalculateDepth(scale.Width), scale.Proportion.Value, scale.BodyType.Value);
	}

	/// <summary>
	/// Handle pagination of the backpack for a place, which consists of allowed gear like this:
	/// [equippedGear], [otherBackPackGear]+
	/// Where otherBackPackGear are in most recently updated UserAsset first order
	/// </summary>
	public IReadOnlyCollection<long> GetGearForPlacePaged(Asset placeAsset, int startIndex, int maximumRows, IReadOnlyCollection<long> equippedGearVersionIds)
	{
		if (maximumRows <= 0 || startIndex < 0)
		{
			return new List<long>();
		}
		if (placeAsset == null)
		{
			return new List<long>();
		}
		int targetBackpackGearCount = startIndex + maximumRows;
		List<long> backpackGearVersionIds = new List<long>();
		backpackGearVersionIds.AddRange(equippedGearVersionIds);
		int allGearIndex = 0;
		while (backpackGearVersionIds.Count < targetBackpackGearCount)
		{
			IReadOnlyCollection<Asset> backpackGearChunk = GetGear(allGearIndex, maximumRows);
			allGearIndex += maximumRows;
			if (backpackGearChunk.Count == 0)
			{
				break;
			}
			foreach (Asset gearAsset in backpackGearChunk)
			{
				if (!equippedGearVersionIds.Contains(gearAsset.CurrentVersionID))
				{
					if (Asset.PlaceAllowsGear(placeAsset, gearAsset))
					{
						backpackGearVersionIds.Add(gearAsset.CurrentVersionID);
					}
					if (backpackGearVersionIds.Count >= targetBackpackGearCount)
					{
						break;
					}
				}
			}
		}
		return backpackGearVersionIds.Skip(startIndex).Take(maximumRows).ToList();
	}
}
