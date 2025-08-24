using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Ownership.Client;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.AssetOwnership;

internal class OwnershipV1UserAssetFactory : IDualCompatibleOwnershipFactory
{
	private static readonly IReadOnlyCollection<int> _AllowedPageSizes = (IReadOnlyCollection<int>)(object)new int[4] { 10, 25, 50, 100 };

	private ILogger _Logger;

	public IReadOnlyCollection<int> AllowedPageSizes { get; } = _AllowedPageSizes;


	public int MaxAllowedPageSize { get; } = _AllowedPageSizes.Max();


	public int MinAllowedPageSize { get; } = _AllowedPageSizes.Min();


	private ClientGetter _ClientGetter { get; }

	private IOwnershipAuthority _Client => _ClientGetter.Client;

	public OwnershipV1UserAssetFactory(ClientGetter clientGetter, ILogger logger)
	{
		_ClientGetter = clientGetter ?? throw new ArgumentNullException("clientGetter");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public bool AgentOwnsAsset(long agentId, long assetId)
	{
		return _Client.AgentOwnsAsset(agentId, assetId);
	}

	public bool AgentOwnsUnexpiredAsset(long agentId, long assetId)
	{
		return _Client.AgentOwnsUnexpiredAsset(agentId, assetId);
	}

	public bool AgentOwnsUserAsset(long agentId, long assetId, long userAssetId)
	{
		return _Client.VerifyOwnership(agentId, userAssetId);
	}

	public IPlatformPageResponse<long, IUserAsset> GetUserAssetsByUserIdAndAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		SortOrder sortOrder = exclusiveStartKeyInfo.GetDatabaseRequestSortOrder();
		return new PlatformPageResponse<long, IUserAsset>(GetUserAssetsByUserIdAndAssetTypeId(userId, assetTypeId, exclusiveStartId, exclusiveStartKeyInfo.Count + 1, sortOrder).ToArray(), exclusiveStartKeyInfo, (IUserAsset userAsset) => userAsset.Id);
	}

	public IPlatformPageResponse<long, IUserAsset> GetUserAssetsByAssetIdPaged(long assetId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		SortOrder sortOrder = exclusiveStartKeyInfo.GetDatabaseRequestSortOrder();
		return new PlatformPageResponse<long, IUserAsset>(GetUserAssetsByAssetId(assetId, exclusiveStartId, exclusiveStartKeyInfo.Count + 1, sortOrder).ToArray(), exclusiveStartKeyInfo, (IUserAsset userAsset) => userAsset.Id);
	}

	public IDictionary<long, IUserAsset> MultiGetUserAssetsByIds(ISet<long> userAssetIds)
	{
		return ((IEnumerable<UserAssetDTO>)_Client.MultiGetUserAssetsByIds(userAssetIds)).Select((Func<UserAssetDTO, IUserAsset>)((UserAssetDTO u) => new UserAsset(u))).ToDictionary((IUserAsset u) => u.Id, (IUserAsset u) => u);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetId(long userId, long assetId)
	{
		return (IReadOnlyCollection<IUserAsset>)(object)_Client.GetOwnedUserAssetsByAssetId(userId, assetId)?.Select((UserAssetDTO el) => new UserAsset(el)).ToArray();
	}

	public IReadOnlyCollection<long> GetUserAssetIDsByUserIdAndAssetId(long userId, long assetId)
	{
		return (IReadOnlyCollection<long>)(object)_Client.GetUserAssetIds(userId, assetId)?.ToArray();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder = SortOrder.Asc)
	{
		return (IReadOnlyCollection<IUserAsset>)(object)_Client.GetUserAssetsByUserIdAndAssetTypeId(userId, assetTypeId, exclusiveStartId, count, sortOrder)?.Select((UserAssetDTO el) => new UserAsset(el)).ToArray();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, long assetId)
	{
		return (IReadOnlyCollection<IUserAsset>)(object)_Client.GetOwnedUserAssetsByAssetId(userId, assetId)?.Select((UserAssetDTO el) => new UserAsset(el)).ToArray();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows)
	{
		return (IReadOnlyCollection<IUserAsset>)(object)_Client.GetUserAssets(userId, assetTypeId, keyword, sortExpression, startRowIndex, maximumRows)?.Select((UserAssetDTO el) => new UserAsset(el)).ToArray();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, int startRowIndex, int maximumRows)
	{
		return GetUserAssets(userId, assetTypeId, null, null, startRowIndex, maximumRows);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder = SortOrder.Asc)
	{
		return (IReadOnlyCollection<IUserAsset>)(object)_Client.GetUserAssetsByAssetId(assetId, exclusiveStartId, count, sortOrder)?.Select((UserAssetDTO el) => new UserAsset(el)).ToArray();
	}

	public int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword = "")
	{
		return _Client.GetTotalNumberOfUserAssets(userId, assetTypeId, keyword);
	}

	public IReadOnlyCollection<IUserAssetOption> GetCopiesForSaleByProductIDSorted(long productId, long startRowIndex, long maximumRows)
	{
		return (IReadOnlyCollection<IUserAssetOption>)(object)(from el in _Client.GetUserAssetOptionCopiesForSaleByProductIdSortedAndPaged(productId, startRowIndex, maximumRows)
			select new UserAssetOption(el)).ToArray();
	}

	public int GetTotalNumberForSaleByProductID(long productId)
	{
		return _Client.GetTotalNumberUserAssetOptionForSaleByProductId(productId);
	}

	public void AwardAssets(IReadOnlyCollection<long> assetIds, long userId)
	{
		AwardAssets(assetIds, userId, out var _);
	}

	/// <summary>
	/// Defaults to "prevent duplicates"
	/// </summary>
	/// <param name="awardedNewAsset">Was any asset actually awarded to the user (or were they all duplicates?)</param>
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
	/// userId and assetId are not needed here but all calls to revoke must provide them for when we are in ov2.
	/// </summary>
	public IAssetOwnershipResult RevokeWithExistingLock(Guid guid, long userAssetId, long userId, long assetId)
	{
		if (!_Client.VerifyOwnership(userId, userAssetId))
		{
			throw new RevokeFailedDueToNotOwnedException(string.Format("OwnershipV1 service could not verify UserAssetID={0} is owned by {1}={2}. Revoke aborted.", userAssetId, "userId", userId));
		}
		IOwnershipResult revokeResult = _Client.Revoke(guid);
		if (!revokeResult.IsSuccess)
		{
			throw new ApplicationException(string.Format("OwnershipV1 service could not revoke UserAsset {0}={1}", "userAssetId", userAssetId));
		}
		return new AssetOwnershipResult(revokeResult.IsSuccess, revokeResult.FailureMessage);
	}

	public bool TransferWithExistingLock(long assetId, long userAssetId, long oldOwnerId, long newOwnerId, Guid token, out string message)
	{
		message = string.Empty;
		bool transferred = false;
		if (_Client.VerifyOwnership(oldOwnerId, userAssetId))
		{
			IOwnershipResult transferResult = _Client.Transfer(newOwnerId, token);
			message = transferResult.FailureMessage;
			if (transferResult.IsSuccess)
			{
				transferred = true;
			}
		}
		_Client.Unlock(token);
		return transferred;
	}

	public ILockResult Lock(long userAssetId)
	{
		return _Client.Lock(userAssetId);
	}

	public bool Unlock(Guid token)
	{
		return _Client.Unlock(token).IsSuccess;
	}

	public bool DeleteLock(Guid token)
	{
		_Client.DeleteLock(token);
		return true;
	}

	public IUserAssetExpiration GetUserAssetExpirationById(long id)
	{
		UserAssetExpirationDTO res = _Client.GetUserAssetExpiration(id);
		if (res == null)
		{
			return null;
		}
		return new UserAssetExpiration(res);
	}

	public IReadOnlyCollection<long> GetUserAssetExpirationItemIdsToExpire(int maxResults)
	{
		return _Client.GetUserAssetExpirationItemIdsToExpire(maxResults).ToList();
	}

	public void SaveUserAssetExpiration(IUserAssetExpiration userAssetExpiration)
	{
		_Client.SaveUserAssetExpiration(userAssetExpiration.UserAssetId, userAssetExpiration.Expiration, userAssetExpiration.IsProcessed, userAssetExpiration.Id);
	}

	public IUserAssetOption GetUserAssetOptionByUserAssetId(long userAssetId)
	{
		UserAssetOptionDTO res = _Client.GetUserAssetOptionByUserAssetId(userAssetId);
		if (res == null)
		{
			return null;
		}
		return new UserAssetOption(res);
	}

	public IUserAssetOption GetUserAssetOptionById(long id)
	{
		return new UserAssetOption(_Client.GetUserAssetOption(id));
	}

	public IUserAssetOption SaveUserAssetOption(IUserAssetOption uao)
	{
		return SaveUserAssetOption(uao.UserAssetId, uao.ProductId, uao.SerialNumber, uao.PriceInRobux, uao.Id);
	}

	public IUserAssetOption SaveUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux, long id)
	{
		UserAssetOptionDTO userAssetOptionDTO = _Client.SaveUserAssetOption(userAssetId, productId, serialNumber, priceInRobux, id);
		UserAssetOption res = new UserAssetOption(userAssetOptionDTO);
		if (id == 0L)
		{
			res.Id = userAssetOptionDTO.Id;
			AssetOptionEvents.OnAssetOptionCreated(res);
		}
		else
		{
			AssetOptionEvents.OnAssetOptionUpdated(res);
		}
		return res;
	}

	public void DeleteUserAssetOption(IUserAssetOption uao)
	{
		_Client.DeleteUserAssetOption(uao.Id);
	}

	public IUserAssetOption CreateNewUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux)
	{
		return SaveUserAssetOption(userAssetId, productId, serialNumber, priceInRobux, 0L);
	}

	public IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId)
	{
		return (IReadOnlyCollection<IUserAsset>)(object)_Client.GetOwnedUserAssetsByAssetId(userId, assetId)?.Select((UserAssetDTO el) => new UserAsset(el)).ToArray();
	}

	public IUserAsset GetUserAssetByUserAssetId(long userAssetId)
	{
		UserAssetDTO res = _Client.GetUserAsset(userAssetId);
		if (res == null)
		{
			return null;
		}
		return new UserAsset(res);
	}

	/// <summary>
	/// no "awardedNewAsset" version, because it always either is true or throws.
	/// </summary>
	public long AwardAssetAllowingDuplicates(long assetId, long userId)
	{
		IGrantResult grantResult = _Client.Grant(userId, assetId, false);
		if (((IOwnershipResult)grantResult).IsSuccess)
		{
			return grantResult.UserAssetID;
		}
		throw GetAwardFailureException(assetId, userId, grantResult);
	}

	public long AwardAsset(long assetId, long userId)
	{
		bool awardedNewAsset;
		return AwardAsset(assetId, userId, out awardedNewAsset);
	}

	/// <summary>
	/// If the user already owns this assetId, then just return the existing userAssetId.
	/// </summary>
	public long AwardAsset(long assetId, long userId, out bool awardedNewAsset)
	{
		if (AgentOwnsAsset(userId, assetId))
		{
			awardedNewAsset = false;
			return (_Client.GetOwnedUserAssetsByAssetId(userId, assetId).FirstOrDefault() ?? throw new UserAssetDisappearedException("User lost ownership of item just as we were attempting to return its id.")).Id;
		}
		IGrantResult grantResult = _Client.Grant(userId, assetId, true);
		if (((IOwnershipResult)grantResult).IsSuccess)
		{
			awardedNewAsset = true;
			return grantResult.UserAssetID;
		}
		throw GetAwardFailureException(assetId, userId, grantResult);
	}

	public IUserAssetExpiration GetUserAssetExpirationByUserAssetId(long userAssetId)
	{
		UserAssetExpirationDTO res = _Client.GetUserAssetExpirationByUserAssetId(userAssetId);
		if (res == null)
		{
			return null;
		}
		return new UserAssetExpiration(res);
	}

	public TimeSpan? GetUserAssetExpireTimeSpan(IUserAsset ua)
	{
		IUserAssetExpiration userAssetExpiration = GetUserAssetExpirationByUserAssetId(ua.Id);
		if (userAssetExpiration == null || !userAssetExpiration.Expiration.HasValue)
		{
			return null;
		}
		return new TimeSpan(userAssetExpiration.Expiration.Value.Ticks - DateTime.Now.Ticks);
	}

	public TimeSpan? GetUserAssetExpireTimeSpan(Lazy<IUserAssetExpiration> userAssetExpiration)
	{
		return new TimeSpan(userAssetExpiration.Value.Expiration.Value.Ticks - DateTime.Now.Ticks);
	}

	public bool UserAssetIsExpired(IUserAsset ua)
	{
		IUserAssetExpiration userAssetExpiration = GetUserAssetExpirationByUserAssetId(ua.Id);
		if (userAssetExpiration == null || !userAssetExpiration.Expiration.HasValue)
		{
			return false;
		}
		return userAssetExpiration?.Expiration.Value <= DateTime.Now;
	}

	public bool UserAssetIsExpired(Lazy<IUserAssetExpiration> userAssetExpiration)
	{
		return userAssetExpiration.Value?.Expiration.Value <= DateTime.Now;
	}

	public DateTime? GetCollectibleUpdatedDateByUserAssetId(long userAssetId)
	{
		UserAssetDTO collectibleUserAssetByUserAssetId = _Client.GetCollectibleUserAssetByUserAssetId(userAssetId);
		if (collectibleUserAssetByUserAssetId == null)
		{
			return null;
		}
		return collectibleUserAssetByUserAssetId.Updated;
	}

	/// <inheritdoc cref="!:ICollectibleUserAssetFactory.GetCollectibleUserAssetsByUserIdAndAssetTypeId" />
	public IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		SortOrder sortOrder = exclusiveStartKeyInfo.GetDatabaseRequestSortOrder();
		int count = exclusiveStartKeyInfo.Count + 1;
		IUserAsset[] originalItems = (from userAssetDTO in _Client.GetCollectibleUserAssetsByOwnerTypeIdOwnerTargetIdAndAssetTypeId(GetOwnerTypeId(OwnerType.User), userId, assetTypeId, exclusiveStartId, count, sortOrder)
			select new UserAsset(userAssetDTO)).ToArray();
		return new PlatformPageResponse<long, IUserAsset>(originalItems, exclusiveStartKeyInfo, (IUserAsset userAsset) => userAsset.Id);
	}

	/// <inheritdoc cref="!:ICollectibleUserAssetFactory.GetCollectibleUserAssetsByUserId" />
	public IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserId(long userId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		SortOrder sortOrder = exclusiveStartKeyInfo.GetDatabaseRequestSortOrder();
		int count = exclusiveStartKeyInfo.Count + 1;
		IUserAsset[] originalItems = (from userAssetDTO in _Client.GetCollectibleUserAssetsByOwnerTypeIdAndOwnerTargetId(GetOwnerTypeId(OwnerType.User), userId, (long?)exclusiveStartId, count, sortOrder)
			select new UserAsset(userAssetDTO)).ToArray();
		return new PlatformPageResponse<long, IUserAsset>(originalItems, exclusiveStartKeyInfo, (IUserAsset userAsset) => userAsset.Id);
	}

	private ApplicationException GetAwardFailureException(long assetId, long userId, IGrantResult grantResult)
	{
		if (((IOwnershipResult)grantResult).FailureMessage == "Recipient already owns Asset")
		{
			return new DuplicateAssetAwardFailedException("Duplicate asset awarding failed.");
		}
		return new ApplicationException(string.Format("Ownership service failed to grant {0}={1} to {2}={3}: {4}", "assetId", assetId, "userId", userId, ((IOwnershipResult)grantResult).FailureMessage));
	}

	private int GetOwnerTypeId(OwnerType ownerType)
	{
		return (int)ownerType;
	}
}
