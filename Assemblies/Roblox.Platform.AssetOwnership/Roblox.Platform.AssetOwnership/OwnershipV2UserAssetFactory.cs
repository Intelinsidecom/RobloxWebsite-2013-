using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.AssetInstances.Client;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.OwnershipV2.Client.Models;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AssetOwnership;

internal class OwnershipV2UserAssetFactory : UserAssetOwnershipAuthority, IOwnershipV2UserAssetFactory, IDualCompatibleOwnershipFactory
{
	private static readonly IReadOnlyCollection<int> _AllowedPageSizes = (IReadOnlyCollection<int>)(object)new int[4] { 10, 25, 50, 100 };

	public IReadOnlyCollection<int> AllowedPageSizes { get; } = _AllowedPageSizes;


	public int MaxAllowedPageSize { get; } = _AllowedPageSizes.Max();


	public int MinAllowedPageSize { get; } = _AllowedPageSizes.Min();


	private Func<long, int> _AssetTypeGetter { get; }

	public OwnershipV2UserAssetFactory(Func<long, int> assetTypeGetter, ILogger logger)
		: base(assetTypeGetter, logger)
	{
		_AssetTypeGetter = assetTypeGetter ?? throw new ArgumentNullException("assetTypeGetter");
	}

	/// <returns>Whether the asset was actually awarded</returns>
	public bool AwardAssetSpecifyingUserAssetId(long assetId, long userAssetId, long userId)
	{
		if (AgentOwnsAsset(userId, assetId))
		{
			return false;
		}
		UserIdentifier user = new UserIdentifier(userId);
		GetOrCreateAssetInstance(assetId, userAssetId);
		UserAssetModel userAssetModel = new UserAssetModel(userAssetId, assetId, DateTime.UtcNow, userId);
		Grant(user, userAssetModel);
		return true;
	}

	public void AwardAssetSpecifyingUserAssetIdAllowingDuplicates(long assetId, long userAssetId, long userId)
	{
		UserIdentifier user = new UserIdentifier(userId);
		UserAssetModel userAssetModel = new UserAssetModel(userAssetId, assetId, DateTime.UtcNow, userId);
		Grant(user, userAssetModel);
	}

	public long AwardAsset(long assetId, long userId, out bool awardedNewAsset)
	{
		if (AgentOwnsAsset(userId, assetId))
		{
			awardedNewAsset = false;
			return (GetOwnedUserAssetsByAssetId(userId, assetId)?.FirstOrDefault() ?? throw new UserAssetDisappearedException("User lost ownership of item just as we were attempting to return its id.")).Id;
		}
		AssetInstanceModel assetInstance = AssetInstancesClient.Create(assetId);
		UserAssetModel userAssetModel = new UserAssetModel(assetInstance.Id, assetId, assetInstance.Created, userId);
		UserIdentifier user = new UserIdentifier(userId);
		Grant(user, userAssetModel);
		awardedNewAsset = true;
		return assetInstance.Id;
	}

	public long AwardAsset(long assetId, long userId)
	{
		bool awardedNewAsset;
		return AwardAsset(assetId, userId, out awardedNewAsset);
	}

	public long AwardAssetAllowingDuplicates(long assetId, long userId)
	{
		UserIdentifier user = new UserIdentifier(userId);
		AssetInstanceModel assetInstance = AssetInstancesClient.Create(assetId);
		UserAssetModel userAssetModel = new UserAssetModel(assetInstance.Id, assetId, assetInstance.Created, userId);
		Grant(user, userAssetModel);
		return assetInstance.Id;
	}

	public void AwardAssets(IReadOnlyCollection<long> assetIds, long userId)
	{
		foreach (long assetId in assetIds)
		{
			AwardAsset(assetId, userId);
		}
	}

	public void AwardAssets(IReadOnlyCollection<long> assetIds, long userId, out bool awardedNewAsset)
	{
		awardedNewAsset = false;
		foreach (long assetId in assetIds)
		{
			AwardAsset(assetId, userId, out var awarded);
			awardedNewAsset |= awarded;
		}
	}

	/// <summary>
	/// This is correct now.  Having userAssetId makes things so much easier!!!!!
	/// </summary>
	public IAssetOwnershipResult RevokeWithExistingLock(Guid guid, long userAssetId, long userId, long assetId)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		UserIdentifier user = new UserIdentifier(userId);
		UserAssetModel userAssetModel = new UserAssetModel(userAssetId, assetId, DateTime.UtcNow, userId);
		if (!AgentOwnsAsset(userId, assetId))
		{
			throw new RevokeFailedDueToNotOwnedException(string.Format("OwnershipV2 service could not verify UserAssetID={0} is owned by {1}={2}. Revoke aborted.", userAssetId, "userId", userId));
		}
		OwnershipV2Result revokeResult = Revoke(user, userAssetModel);
		if ((int)revokeResult.Result != 0)
		{
			throw new ApplicationException(string.Format("OwnershipV2 service could not revoke UserAsset {0}={1}", "userAssetId", userAssetId));
		}
		OwnershipV2OperationResult result = revokeResult.Result;
		return new AssetOwnershipResult(isSuccess: true, ((object)(OwnershipV2OperationResult)(ref result)).ToString());
	}

	public bool TransferWithExistingLock(long assetId, long userAssetId, long oldOwnerId, long newOwnerId, Guid token, out string message)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		message = string.Empty;
		UserAssetModel userAssetModel = new UserAssetModel(userAssetId, assetId, DateTime.UtcNow, oldOwnerId);
		return (int)Transfer(new UserIdentifier(oldOwnerId), userAssetModel, new UserIdentifier(newOwnerId)).Result == 0;
	}

	public bool AgentOwnsAsset(long agentId, long assetId)
	{
		UserIdentifier user = new UserIdentifier(agentId);
		return GetUserAssetsByUserAndAssetId(user, assetId)?.FirstOrDefault() != null;
	}

	public bool AgentOwnsUserAsset(long agentId, long assetId, long userAssetId)
	{
		UserIdentifier user = new UserIdentifier(agentId);
		UserAssetModel item = new UserAssetModel(userAssetId, assetId, DateTime.Now, agentId);
		return Get(user, item).OwnedItem != null;
	}

	public IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId)
	{
		UserIdentifier user = new UserIdentifier(userId);
		IReadOnlyCollection<UserAssetModel> userAssetsByUserAndAssetId = GetUserAssetsByUserAndAssetId(user, assetId);
		int assetTypeId = _AssetTypeGetter(assetId);
		return (IReadOnlyCollection<IUserAsset>)(object)userAssetsByUserAndAssetId.Select((UserAssetModel el) => new UserAsset(el.Id, assetId, assetTypeId, el.Created, userId)).ToArray();
	}

	public IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		throw new NotImplementedException();
	}

	public IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserId(long userId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		throw new NotImplementedException();
	}

	public IUserAsset GetUserAssetByUserAssetId(long userAssetId)
	{
		throw new NotImplementedException();
	}

	public IDictionary<long, IUserAsset> MultiGetUserAssetsByIds(ISet<long> userAssetIds)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetId(long userId, long assetId)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, long assetId)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, int startRowIndex, int maximumRows)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder)
	{
		throw new NotImplementedException();
	}

	public IReadOnlyCollection<long> GetUserAssetIDsByUserIdAndAssetId(long userId, long assetId)
	{
		throw new NotImplementedException();
	}

	public IPlatformPageResponse<long, IUserAsset> GetUserAssetsByUserIdAndAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		throw new NotImplementedException();
	}

	public IPlatformPageResponse<long, IUserAsset> GetUserAssetsByAssetIdPaged(long assetId, IExclusiveStartKeyInfo<long> exclusiveStartDetails)
	{
		throw new NotImplementedException();
	}

	public int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword = "")
	{
		throw new NotImplementedException();
	}

	private void GetOrCreateAssetInstance(long assetId, long assetInstanceId)
	{
		if (AssetInstancesClient.Get(assetInstanceId) == null)
		{
			AssetInstancesClient.CreateWithId(assetId, assetInstanceId);
		}
	}
}
