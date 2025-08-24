using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Interfaces;
using Roblox.DataV2.Core;

namespace Roblox.Ownership.Client
{
    public sealed class OwnershipAuthorityFactory
    {
        public static OwnershipAuthorityFactory Singleton { get; } = new OwnershipAuthorityFactory();
        private OwnershipAuthorityFactory() { }
        public IOwnershipAuthority GetOwnershipAuthority(string apiKey, IRequestCache cache) => new InMemoryOwnershipAuthority();
    }

    internal sealed class InMemoryOwnershipAuthority : IOwnershipAuthority
    {
        private long _nextUserAssetId = 1;
        private readonly object _gate = new object();
        private readonly HashSet<Guid> _locks = new HashSet<Guid>();
        private readonly Dictionary<long, UserAssetDTO> _userAssets = new Dictionary<long, UserAssetDTO>(); // key = userAssetId
        private readonly Dictionary<long, List<long>> _byOwnerAsset = new Dictionary<long, List<long>>(); // key = ownerId<<32 | assetId -> list of userAssetIds

        private static long Key(long ownerId, long assetId) => (ownerId << 32) ^ assetId;

        public bool AgentOwnsAsset(long agentId, long assetId)
        {
            lock (_gate)
            {
                return _byOwnerAsset.TryGetValue(Key(agentId, assetId), out var list) && list.Count > 0;
            }
        }

        public bool AgentOwnsUnexpiredAsset(long agentId, long assetId)
        {
            // No expiration logic simulated; treat same as owns
            return AgentOwnsAsset(agentId, assetId);
        }

        public bool VerifyOwnership(long agentId, long userAssetId)
        {
            lock (_gate)
            {
                return _userAssets.TryGetValue(userAssetId, out var ua) && ua.OwnerId == agentId;
            }
        }

        public IEnumerable<UserAssetDTO> GetOwnedUserAssetsByAssetId(long userId, long assetId)
        {
            return GetUserAssetIds(userId, assetId).Select(id => _userAssets[id]);
        }

        public IEnumerable<long> GetUserAssetIds(long userId, long assetId)
        {
            lock (_gate)
            {
                return _byOwnerAsset.TryGetValue(Key(userId, assetId), out var list) ? list.ToArray() : Array.Empty<long>();
            }
        }

        public IEnumerable<UserAssetDTO> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder)
        {
            lock (_gate)
            {
                var items = _userAssets.Values.Where(x => x.OwnerId == userId).Where(x => true); // no type mapping available here
                var ordered = sortOrder == SortOrder.Asc ? items.OrderBy(x => x.Id) : items.OrderByDescending(x => x.Id);
                if (exclusiveStartId > 0)
                {
                    ordered = ordered.Where(x => sortOrder == SortOrder.Asc ? x.Id > exclusiveStartId : x.Id < exclusiveStartId)
                                     .OrderBy(x => x.Id);
                }
                return ordered.Take(count).ToArray();
            }
        }

        public IEnumerable<UserAssetDTO> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows)
        {
            // Minimal: ignore keyword/sortExpression/assetTypeId and page by index
            lock (_gate)
            {
                return _userAssets.Values.Where(x => x.OwnerId == userId)
                    .OrderBy(x => x.Id)
                    .Skip(startRowIndex)
                    .Take(maximumRows)
                    .ToArray();
            }
        }

        public IEnumerable<UserAssetDTO> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder)
        {
            lock (_gate)
            {
                var items = _userAssets.Values.Where(x => x.AssetId == assetId);
                var ordered = sortOrder == SortOrder.Asc ? items.OrderBy(x => x.Id) : items.OrderByDescending(x => x.Id);
                if (exclusiveStartId > 0)
                {
                    ordered = ordered.Where(x => sortOrder == SortOrder.Asc ? x.Id > exclusiveStartId : x.Id < exclusiveStartId)
                                     .OrderBy(x => x.Id);
                }
                return ordered.Take(count).ToArray();
            }
        }

        public int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword)
        {
            lock (_gate)
            {
                return _userAssets.Values.Count(x => x.OwnerId == userId);
            }
        }

        public IEnumerable<UserAssetOptionDTO> GetUserAssetOptionCopiesForSaleByProductIdSortedAndPaged(long productId, long startRowIndex, long maximumRows)
        {
            return Array.Empty<UserAssetOptionDTO>();
        }

        public int GetTotalNumberUserAssetOptionForSaleByProductId(long productId) => 0;

        public IOwnershipResult Revoke(Guid guid)
        {
            // For our minimal implementation, guid is not tracked; treat as success
            return OwnershipResult.Ok();
        }

        public IOwnershipResult Unlock(Guid token)
        {
            lock (_gate)
            {
                _locks.Remove(token);
                return OwnershipResult.Ok();
            }
        }

        public void DeleteLock(Guid token)
        {
            lock (_gate) { _locks.Remove(token); }
        }

        public IOwnershipResult Transfer(long newOwnerId, Guid token)
        {
            // Minimal: cannot infer which item; treat as success
            return OwnershipResult.Ok();
        }

        public ILockResult Lock(long userAssetId)
        {
            lock (_gate)
            {
                var t = Guid.NewGuid();
                _locks.Add(t);
                return LockResult.Ok(t);
            }
        }

        public UserAssetExpirationDTO GetUserAssetExpiration(long id) => new UserAssetExpirationDTO { Id = id };
        public UserAssetExpirationDTO GetUserAssetExpirationByUserAssetId(long userAssetId) => new UserAssetExpirationDTO { UserAssetId = userAssetId };
        public IEnumerable<long> GetUserAssetExpirationItemIdsToExpire(int maxResults) => Array.Empty<long>();
        public void SaveUserAssetExpiration(long userAssetId, DateTime? expiration, bool isProcessed, long id) { }

        public UserAssetOptionDTO GetUserAssetOptionByUserAssetId(long userAssetId) => null;
        public UserAssetOptionDTO GetUserAssetOption(long id) => null;
        public UserAssetOptionDTO SaveUserAssetOption(long userAssetId, long productId, long? serialNumber, long? priceInRobux, long id) => null;
        public void DeleteUserAssetOption(long id) { }

        public UserAssetDTO GetUserAsset(long userAssetId)
        {
            lock (_gate) { return _userAssets.TryGetValue(userAssetId, out var ua) ? ua : null; }
        }

        public UserAssetDTO GetCollectibleUserAssetByUserAssetId(long userAssetId) => GetUserAsset(userAssetId);

        public IEnumerable<UserAssetDTO> GetCollectibleUserAssetsByOwnerTypeIdOwnerTargetIdAndAssetTypeId(int ownerTypeId, long ownerTargetId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder)
        {
            // Not modeling collectibles; return empty
            return Array.Empty<UserAssetDTO>();
        }

        public IEnumerable<UserAssetDTO> GetCollectibleUserAssetsByOwnerTypeIdAndOwnerTargetId(int ownerTypeId, long ownerTargetId, long? exclusiveStartId, int count, SortOrder sortOrder)
        {
            return Array.Empty<UserAssetDTO>();
        }

        public IGrantResult Grant(long userId, long assetId, bool preventDuplicates)
        {
            lock (_gate)
            {
                if (preventDuplicates && AgentOwnsAsset(userId, assetId))
                {
                    return GrantResult.Ok(0);
                }
                var id = _nextUserAssetId++;
                var dto = new UserAssetDTO
                {
                    Id = id,
                    AssetId = assetId,
                    OwnerId = userId,
                    Created = DateTime.UtcNow,
                };
                _userAssets[id] = dto;
                var k = Key(userId, assetId);
                if (!_byOwnerAsset.TryGetValue(k, out var list))
                {
                    list = new List<long>();
                    _byOwnerAsset[k] = list;
                }
                list.Add(id);
                return GrantResult.Ok(id);
            }
        }

        public IEnumerable<UserAssetDTO> MultiGetUserAssetsByIds(ISet<long> userAssetIds)
        {
            if (userAssetIds == null || userAssetIds.Count == 0) return Array.Empty<UserAssetDTO>();
            lock (_gate)
            {
                var results = new List<UserAssetDTO>(userAssetIds.Count);
                foreach (var id in userAssetIds)
                {
                    if (_userAssets.TryGetValue(id, out var dto))
                    {
                        results.Add(dto);
                    }
                }
                return results;
            }
        }
    }
}
