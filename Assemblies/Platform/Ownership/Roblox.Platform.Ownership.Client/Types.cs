using System;
using System.Collections.Generic;
using Roblox.DataV2.Core; // for SortOrder

namespace Roblox.Platform.Ownership.Client
{
    public interface IOwnershipResult
    {
        bool IsSuccess { get; }
        string FailureMessage { get; }
    }

    public interface ILockResult : IOwnershipResult
    {
        Guid Token { get; }
    }

    public interface IGrantResult : IOwnershipResult
    {
        long UserAssetID { get; }
    }

    public sealed class OwnershipResult : IOwnershipResult
    {
        public bool IsSuccess { get; set; }
        public string FailureMessage { get; set; }
        public static OwnershipResult Ok() => new OwnershipResult { IsSuccess = true };
        public static OwnershipResult Fail(string message) => new OwnershipResult { IsSuccess = false, FailureMessage = message };
    }

    public sealed class LockResult : ILockResult
    {
        public bool IsSuccess { get; set; }
        public string FailureMessage { get; set; }
        public Guid Token { get; set; }
        public static LockResult Ok(Guid token) => new LockResult { IsSuccess = true, Token = token };
        public static LockResult Fail(string message) => new LockResult { IsSuccess = false, FailureMessage = message, Token = Guid.Empty };
    }

    public sealed class GrantResult : IGrantResult
    {
        public bool IsSuccess { get; set; }
        public string FailureMessage { get; set; }
        public long UserAssetID { get; set; }
        public static GrantResult Ok(long id) => new GrantResult { IsSuccess = true, UserAssetID = id };
        public static GrantResult Fail(string message) => new GrantResult { IsSuccess = false, FailureMessage = message, UserAssetID = 0 };
    }

    public sealed class UserAssetDTO
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public long OwnerId { get; set; }
        public int AssetTypeId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public long UserId { get; set; }
    }

    public sealed class UserAssetOptionDTO
    {
        public long Id { get; set; }
        public long UserAssetId { get; set; }
        public long? SerialNumber { get; set; }
        public long? PriceInRobux { get; set; }
        public long ProductId { get; set; }
    }

    public sealed class UserAssetExpirationDTO
    {
        public long Id { get; set; }
        public long UserAssetId { get; set; }
        public DateTime? Expiration { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }

    public interface IOwnershipAuthority
    {
        bool AgentOwnsAsset(long agentId, long assetId);
        bool AgentOwnsUnexpiredAsset(long agentId, long assetId);
        bool VerifyOwnership(long agentId, long userAssetId);

        IEnumerable<UserAssetDTO> GetOwnedUserAssetsByAssetId(long userId, long assetId);
        IEnumerable<long> GetUserAssetIds(long userId, long assetId);
        IEnumerable<UserAssetDTO> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder);
        IEnumerable<UserAssetDTO> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows);
        IEnumerable<UserAssetDTO> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder);
        int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword);

        IEnumerable<UserAssetOptionDTO> GetUserAssetOptionCopiesForSaleByProductIdSortedAndPaged(long productId, long startRowIndex, long maximumRows);
        int GetTotalNumberUserAssetOptionForSaleByProductId(long productId);

        IOwnershipResult Revoke(Guid guid);
        IOwnershipResult Unlock(Guid token);
        void DeleteLock(Guid token);
        IOwnershipResult Transfer(long newOwnerId, Guid token);
        ILockResult Lock(long userAssetId);

        UserAssetExpirationDTO GetUserAssetExpiration(long id);
        UserAssetExpirationDTO GetUserAssetExpirationByUserAssetId(long userAssetId);
        IEnumerable<long> GetUserAssetExpirationItemIdsToExpire(int maxResults);
        void SaveUserAssetExpiration(long userAssetId, DateTime? expiration, bool isProcessed, long id);

        UserAssetOptionDTO GetUserAssetOptionByUserAssetId(long userAssetId);
        UserAssetOptionDTO GetUserAssetOption(long id);
        UserAssetOptionDTO SaveUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux, long id);
        void DeleteUserAssetOption(long id);

        UserAssetDTO GetUserAsset(long userAssetId);
        UserAssetDTO GetCollectibleUserAssetByUserAssetId(long userAssetId);
        IEnumerable<UserAssetDTO> GetCollectibleUserAssetsByOwnerTypeIdOwnerTargetIdAndAssetTypeId(int ownerTypeId, long ownerTargetId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder);
        IEnumerable<UserAssetDTO> GetCollectibleUserAssetsByOwnerTypeIdAndOwnerTargetId(int ownerTypeId, long ownerTargetId, long? exclusiveStartId, int count, SortOrder sortOrder);

        IGrantResult Grant(long userId, long assetId, bool preventDuplicates);

        IEnumerable<UserAssetDTO> MultiGetUserAssetsByIds(ISet<long> userAssetIds);
    }

    // Minimal exception to satisfy callers that expect LockException in this namespace
    public class LockException : Exception
    {
        public LockException() { }
        public LockException(string message) : base(message) { }
    }
}
