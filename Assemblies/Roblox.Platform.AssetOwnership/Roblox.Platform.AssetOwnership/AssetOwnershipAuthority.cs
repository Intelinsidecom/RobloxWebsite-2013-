using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.Caching.Interfaces;
using Roblox.Configuration;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Ownership.Client;
using Roblox.Platform.AssetOwnership.Implementation;
using Roblox.Platform.AssetOwnership.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// All Ownership-related queries and changes should go through here. 
/// Do not directly use the ov1 or ov2 client, or UserAssetFactory, or UserAsset methods.
/// However, this does not cover collectible stuff.
/// This is where managing the ov1/ov2 transition happens.
/// This should only contain methods that can exist for ov1 and ov2 simultaneously.
/// Anything which can't and needs to be transitioned, should use the Legacy classes
/// </summary>
public class AssetOwnershipAuthority : IAssetOwnershipAuthority
{
	private static readonly IReadOnlyCollection<int> _AllowedPageSizes = (IReadOnlyCollection<int>)(object)new int[4] { 10, 25, 50, 100 };

	public IReadOnlyCollection<int> AllowedPageSizes { get; } = _AllowedPageSizes;


	public int MaxAllowedPageSize { get; } = _AllowedPageSizes.Max();


	public int MinAllowedPageSize { get; } = _AllowedPageSizes.Min();


	private OwnershipV1UserAssetFactory _NonDualCompatibleOv1Actions { get; }

	/// <summary>
	/// These two should be used interchangably.  This forces us to notice when ov1 is doing something which claims to be dual-compatible, but ov2 doesn't have support for it yet.
	/// </summary>
	private IDualCompatibleOwnershipFactory _Ov1UserAssetOwnershipFactory { get; }

	private OwnershipV2UserAssetFactory _Ov2UserAssetOwnershipAuthority { get; }

	private Func<long, int> _AssetTypeLookupProvider { get; }

	/// <summary>
	/// This will be used for telemetry. It should be of two forms:
	/// 1. For non-static instances, it should be the proper component name (according to the code organization and component naming rules spreadsheet, regardless of what's in infra).
	/// 2. For static, it should be the base namespace of the csproj which loads it statically, or "ServerClassLibrary" for SCL.
	/// </summary>
	private string _ComponentName { get; }

	/// <summary>
	/// Note: in static AOAs, this is generally a dummy log.
	/// </summary>
	private ILogger _Logger { get; }

	private Ov2RolloutLogicHandler _Ov2RolloutLogicHandler { get; set; }

	public AssetOwnershipAuthority(Func<long, int> assetTypeLookupProvider, string componentName, ILogger logger, IRequestCache requestCache = null)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AssetTypeLookupProvider = assetTypeLookupProvider ?? throw new ArgumentNullException("assetTypeLookupProvider");
		ClientGetter clientGetter = new ClientGetter((ISettings s) => s.UserAssetShimClientApiKey, _Logger, requestCache);
		_Ov1UserAssetOwnershipFactory = (_NonDualCompatibleOv1Actions = new OwnershipV1UserAssetFactory(clientGetter, _Logger));
		_Ov2UserAssetOwnershipAuthority = new OwnershipV2UserAssetFactory(_AssetTypeLookupProvider, _Logger);
		RemediationRequestRecorder recorder = new RemediationRequestRecorder(_Logger);
		if (string.IsNullOrWhiteSpace(componentName))
		{
			throw new ArgumentNullException("componentName");
		}
		_ComponentName = componentName;
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.IsAssetOwnershipTelemetryEnabled, delegate(bool val)
		{
			HandleTelemetrySettingChange(val, recorder);
		});
	}

	private void HandleTelemetrySettingChange(bool isAssetOwnershipTelemetryEnabled, RemediationRequestRecorder recorder)
	{
		_Ov2RolloutLogicHandler = new Ov2RolloutLogicHandler(observer: (!isAssetOwnershipTelemetryEnabled) ? ((IAssetOwnershipObserver)new DoNothingAssetOwnershipObserver()) : ((IAssetOwnershipObserver)new AssetOwnershipObserver(_Logger)), assetTypeGetter: _AssetTypeLookupProvider, locker: new Locker(_NonDualCompatibleOv1Actions), unlocker: new Unlocker(_NonDualCompatibleOv1Actions), ov1UserAssetFactory: _Ov1UserAssetOwnershipFactory, ov2UserAssetFactory: _Ov2UserAssetOwnershipAuthority, settings: Settings.Default, remediationRequestRecorder: recorder, logger: _Logger);
	}

	public IUserAsset GetUserAssetByUserAssetId(long userAssetId)
	{
		Helpers.ThrowIfDefault(userAssetId, "userAssetId");
		return _Ov1UserAssetOwnershipFactory.GetUserAssetByUserAssetId(userAssetId);
	}

	public IDictionary<long, IUserAsset> MultiGetUserAssetsByIds(ISet<long> userAssetIds)
	{
		if (userAssetIds == null)
		{
			throw new ArgumentNullException("userAssetIds");
		}
		return _Ov1UserAssetOwnershipFactory.MultiGetUserAssetsByIds(userAssetIds);
	}

	public int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword = "")
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetTypeId, "assetTypeId");
		return _Ov1UserAssetOwnershipFactory.GetTotalNumberOfUserAssets(userId, assetTypeId, keyword);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetId(long userId, long assetId)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetId, "assetId");
		return _Ov1UserAssetOwnershipFactory.GetUserAssetsByUserIdAndAssetId(userId, assetId);
	}

	public IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetId, "assetId");
		return _Ov1UserAssetOwnershipFactory.GetOwnedUserAssetsByAssetId(userId, assetId);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder = SortOrder.Asc)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetTypeId, "assetTypeId");
		Helpers.ThrowIfDefault(count, "count");
		Helpers.ThrowIfDefault(sortOrder, "sortOrder");
		return _Ov1UserAssetOwnershipFactory.GetUserAssetsByUserIdAndAssetTypeId(userId, assetTypeId, exclusiveStartId, count, sortOrder);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, long assetId)
	{
		Helpers.ThrowIfDefault(assetId, "assetId");
		Helpers.ThrowIfDefault(userId, "userId");
		return _Ov1UserAssetOwnershipFactory.GetUserAssets(userId, assetId);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetTypeId, "assetTypeId");
		if (keyword == null || keyword.Trim().Length == 0)
		{
			keyword = string.Empty;
		}
		return _Ov1UserAssetOwnershipFactory.GetUserAssets(userId, assetTypeId, keyword, sortExpression, startRowIndex, maximumRows);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, int startRowIndex, int maximumRows)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetTypeId, "assetTypeId");
		Helpers.ThrowIfDefault(maximumRows, "maximumRows");
		return _Ov1UserAssetOwnershipFactory.GetUserAssets(userId, assetTypeId, startRowIndex, maximumRows);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder = SortOrder.Asc)
	{
		Helpers.ThrowIfDefault(assetId, "assetId");
		Helpers.ThrowIfDefault(count, "count");
		return _Ov1UserAssetOwnershipFactory.GetUserAssetsByAssetId(assetId, exclusiveStartId, count, sortOrder);
	}

	public bool AgentOwnsAsset(long agentId, long assetId)
	{
		Helpers.ThrowIfDefault(agentId, "agentId");
		Helpers.ThrowIfDefault(assetId, "assetId");
		return _Ov1UserAssetOwnershipFactory.AgentOwnsAsset(agentId, assetId);
	}

	public bool AgentOwnsUnexpiredAsset(long userId, long assetId)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetId, "assetId");
		return _NonDualCompatibleOv1Actions.AgentOwnsUnexpiredAsset(userId, assetId);
	}

	public bool AgentOwnsUserAsset(long agentId, long assetId, long userAssetId)
	{
		Helpers.ThrowIfDefault(agentId, "agentId");
		Helpers.ThrowIfDefault(assetId, "assetId");
		Helpers.ThrowIfDefault(userAssetId, "userAssetId");
		return _Ov1UserAssetOwnershipFactory.AgentOwnsUserAsset(agentId, assetId, userAssetId);
	}

	public IPlatformPageResponse<long, IUserAsset> GetUserAssetsByAssetIdPaged(long assetId, IExclusiveStartKeyInfo<long> exclusiveStartDetails)
	{
		Helpers.CheckExclusiveStartKeyValidity(exclusiveStartDetails, AllowedPageSizes);
		Helpers.ThrowIfDefault(assetId, "assetId");
		return _Ov1UserAssetOwnershipFactory.GetUserAssetsByAssetIdPaged(assetId, exclusiveStartDetails);
	}

	public IReadOnlyCollection<long> GetUserAssetIDsByUserIdAndAssetId(long userId, long assetId)
	{
		return _Ov1UserAssetOwnershipFactory.GetUserAssetIDsByUserIdAndAssetId(userId, assetId);
	}

	public IPlatformPageResponse<long, IUserAsset> GetUserAssetsByUserIdAndAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		Helpers.CheckExclusiveStartKeyValidity(exclusiveStartKeyInfo, AllowedPageSizes);
		Helpers.ThrowIfDefault(assetTypeId, "assetTypeId");
		Helpers.ThrowIfDefault(userId, "userId");
		return _Ov1UserAssetOwnershipFactory.GetUserAssetsByUserIdAndAssetTypeIdPaged(userId, assetTypeId, exclusiveStartKeyInfo);
	}

	/// <summary>
	/// UserAssets are never updated, except collectibles. Ones which might be collectible have their Updated date loaded from inside ov1.
	/// </summary>
	public DateTime? GetCollectibleUpdatedDateByUserAssetId(long userAssetId)
	{
		Helpers.ThrowIfDefault(userAssetId, "userAssetId");
		return _NonDualCompatibleOv1Actions.GetCollectibleUpdatedDateByUserAssetId(userAssetId);
	}

	public IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		Helpers.ThrowIfDefault(assetTypeId, "assetTypeId");
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (!AllowedPageSizes.Contains(exclusiveStartKeyInfo.Count))
		{
			throw new PlatformArgumentException(string.Format("{0} has invalid count! Must be in {1}", "exclusiveStartKeyInfo", "AllowedPageSizes"));
		}
		return _Ov1UserAssetOwnershipFactory.GetCollectibleUserAssetsByUserIdAndAssetTypeId(userId, assetTypeId, exclusiveStartKeyInfo);
	}

	public IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserId(long userId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		Helpers.ThrowIfDefault(userId, "userId");
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (!AllowedPageSizes.Contains(exclusiveStartKeyInfo.Count))
		{
			throw new PlatformArgumentException(string.Format("{0} has invalid count! Must be in {1}", "exclusiveStartKeyInfo", "AllowedPageSizes"));
		}
		return _Ov1UserAssetOwnershipFactory.GetCollectibleUserAssetsByUserId(userId, exclusiveStartKeyInfo);
	}

	/// <summary>
	/// By default, awardAssets does not allow duplicates.
	/// </summary>
	public long AwardAsset(long assetId, long userId, out bool awardedNewAsset)
	{
		DualAwardResult awardResult = _Ov2RolloutLogicHandler.DoPossibleDualAward("AwardAsset", assetId, userId, allowDuplicates: false);
		awardedNewAsset = awardResult.AwardedInOv1;
		return awardResult.UserAssetId;
	}

	public long AwardAsset(long assetId, long userId)
	{
		return _Ov2RolloutLogicHandler.DoPossibleDualAward("AwardAsset", assetId, userId, allowDuplicates: false).UserAssetId;
	}

	public void AwardAssets(IReadOnlyCollection<long> assetIds, long userId)
	{
		foreach (long assetId in assetIds)
		{
			AwardAsset(assetId, userId, out var _);
		}
	}

	/// <summary>
	/// Defaults to "prevent duplicates"
	/// </summary>
	/// <param name="awardedNewAsset"> Was any asset actually awarded to the user (or were they all duplicates?) </param>
	public void AwardAssets(IReadOnlyCollection<long> assetIds, long userId, out bool awardedNewAsset)
	{
		awardedNewAsset = false;
		foreach (long assetId in assetIds)
		{
			AwardAsset(assetId, userId, out var subAward);
			awardedNewAsset |= subAward;
		}
	}

	/// <summary>
	/// Attempts to award asset allowing a given userId to own multiple of the same assetId.
	/// Returns the UserAssetId of the newly created item.
	/// </summary>
	/// <returns>The UserAssetId of the awarded asset.</returns>
	public long AwardAssetAllowingDuplicates(long assetId, long userId)
	{
		return _Ov2RolloutLogicHandler.DoPossibleDualAward("AwardAssetAllowingDuplicates", assetId, userId, allowDuplicates: true).UserAssetId;
	}

	/// <summary>
	/// Clients who are doing single item transfers should use this method so they don't have to lock/unlock/do transactions themselves.
	/// </summary>
	public bool Transfer(long userAssetId, long oldOwnerId, long newOwnerId, out string message)
	{
		IUserAsset userAsset = GetUserAssetByUserAssetId(userAssetId);
		ILockResult lockResult = _NonDualCompatibleOv1Actions.Lock(userAssetId);
		if (!((IOwnershipResult)lockResult).IsSuccess)
		{
			throw new PlatformException($"Failed to lock.  userAssetId={userAssetId}, oldOwnerId={oldOwnerId}, newOwnerId={newOwnerId}.  \r\n{new StackTrace()}");
		}
		TransferResult transferResult = _Ov2RolloutLogicHandler.DoPossibleDualTransferWithLock("Transfer", userAssetId, userAsset?.AssetId ?? 0, oldOwnerId, newOwnerId, lockResult.Token);
		message = transferResult.Message;
		return true;
	}

	/// <summary>
	/// Trade system needs to do mass locking, then transferring.  Internal calls should NOT unlock it!
	/// </summary>
	public bool TransferWithExistingLock(long userAssetId, long oldOwnerId, long newOwnerId, Guid token)
	{
		IUserAsset userAsset = GetUserAssetByUserAssetId(userAssetId);
		_Ov2RolloutLogicHandler.DoPossibleDualTransferWithLock("TransferWithExistingLock", userAssetId, userAsset?.AssetId ?? 0, oldOwnerId, newOwnerId, token);
		return true;
	}

	/// <summary>
	/// Delete a userasset.  The caller has responsibility to delete accoutrement if user was wearing it. (and clear thumbnail if so)
	/// We provide userId so that ov1 can look up and delete the record.
	/// </summary>
	public IAssetOwnershipResult DeleteUserAsset(long userAssetId, long assetId, long userId)
	{
		return new AssetOwnershipResult(isSuccess: true, _Ov2RolloutLogicHandler.DoPossibleDualRevoke("DeleteUserAsset", userAssetId, assetId, userId).ToString());
	}

	public ILockResult Lock(long userAssetId)
	{
		return _NonDualCompatibleOv1Actions.Lock(userAssetId);
	}

	public bool Unlock(Guid guid)
	{
		return _NonDualCompatibleOv1Actions.Unlock(guid);
	}
}
