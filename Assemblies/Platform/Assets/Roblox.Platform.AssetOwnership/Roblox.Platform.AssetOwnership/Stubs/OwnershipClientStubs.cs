// Minimal stubs to satisfy compile-time dependencies when Roblox.Ownership.Client is unavailable.
// NOTE: Runtime behavior is not implemented; methods return defaults.

using System;
using System.Collections.Generic;
using Roblox.Caching.Interfaces;
using Roblox.DataV2.Core;

namespace Roblox.Ownership.Client
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

    // DTOs used by AssetOwnership
    public class UserAssetDTO
    {
        public long Id { get; set; }
        public DateTime? Updated { get; set; }
    }

    public class UserAssetOptionDTO
    {
        public long Id { get; set; }
        public long UserAssetId { get; set; }
        public long ProductId { get; set; }
        public long? SerialNumber { get; set; }
        public long? PriceInRobux { get; set; }
    }

    public class UserAssetExpirationDTO
    {
        public long Id { get; set; }
        public long UserAssetId { get; set; }
        public DateTime? Expiration { get; set; }
        public bool IsProcessed { get; set; }
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
    }

    public sealed class OwnershipAuthorityFactory
    {
        public static readonly OwnershipAuthorityFactory Singleton = new OwnershipAuthorityFactory();

        public IOwnershipAuthority GetOwnershipAuthority(string apiKey, IRequestCache cache)
        {
            return new DummyOwnershipAuthority();
        }
    }

    // Dummy implementations to satisfy compile-time; return safe defaults
    internal class DummyOwnershipAuthority : IOwnershipAuthority
    {
        public bool AgentOwnsAsset(long agentId, long assetId) => false;
        public bool AgentOwnsUnexpiredAsset(long agentId, long assetId) => false;
        public bool VerifyOwnership(long agentId, long userAssetId) => false;

        public IEnumerable<UserAssetDTO> GetOwnedUserAssetsByAssetId(long userId, long assetId) => Array.Empty<UserAssetDTO>();
        public IEnumerable<long> GetUserAssetIds(long userId, long assetId) => Array.Empty<long>();
        public IEnumerable<UserAssetDTO> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder) => Array.Empty<UserAssetDTO>();
        public IEnumerable<UserAssetDTO> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows) => Array.Empty<UserAssetDTO>();
        public IEnumerable<UserAssetDTO> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder) => Array.Empty<UserAssetDTO>();
        public int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword) => 0;

        public IEnumerable<UserAssetOptionDTO> GetUserAssetOptionCopiesForSaleByProductIdSortedAndPaged(long productId, long startRowIndex, long maximumRows) => Array.Empty<UserAssetOptionDTO>();
        public int GetTotalNumberUserAssetOptionForSaleByProductId(long productId) => 0;

        public IOwnershipResult Revoke(Guid guid) => new DummyResult();
        public IOwnershipResult Unlock(Guid token) => new DummyResult();
        public void DeleteLock(Guid token) { }
        public IOwnershipResult Transfer(long newOwnerId, Guid token) => new DummyResult();
        public ILockResult Lock(long userAssetId) => new DummyLockResult();

        public UserAssetExpirationDTO GetUserAssetExpiration(long id) => null;
        public IEnumerable<long> GetUserAssetExpirationItemIdsToExpire(int maxResults) => Array.Empty<long>();
        public void SaveUserAssetExpiration(long userAssetId, DateTime? expiration, bool isProcessed, long id) { }

        public UserAssetOptionDTO GetUserAssetOptionByUserAssetId(long userAssetId) => null;
        public UserAssetOptionDTO GetUserAssetOption(long id) => null;
        public UserAssetOptionDTO SaveUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux, long id) => new UserAssetOptionDTO { Id = id, UserAssetId = userAssetId, ProductId = productId, SerialNumber = serialNumber, PriceInRobux = priceInRobux };
        public void DeleteUserAssetOption(long id) { }

        public UserAssetDTO GetUserAsset(long userAssetId) => null;
        public UserAssetDTO GetCollectibleUserAssetByUserAssetId(long userAssetId) => null;
        public IEnumerable<UserAssetDTO> GetCollectibleUserAssetsByOwnerTypeIdOwnerTargetIdAndAssetTypeId(int ownerTypeId, long ownerTargetId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder) => Array.Empty<UserAssetDTO>();
        public IEnumerable<UserAssetDTO> GetCollectibleUserAssetsByOwnerTypeIdAndOwnerTargetId(int ownerTypeId, long ownerTargetId, long? exclusiveStartId, int count, SortOrder sortOrder) => Array.Empty<UserAssetDTO>();

        public IGrantResult Grant(long userId, long assetId, bool preventDuplicates) => new DummyGrantResult();
    }

    internal class DummyResult : IOwnershipResult
    {
        public bool IsSuccess { get; set; } = true;
        public string FailureMessage { get; set; } = string.Empty;
    }

    internal class DummyLockResult : DummyResult, ILockResult
    {
        public Guid Token { get; set; } = Guid.NewGuid();
    }

    internal class DummyGrantResult : DummyResult, IGrantResult
    {
        public long UserAssetID { get; set; } = 0;
    }
}
