// Minimal stubs to satisfy compile-time dependencies when Roblox.OwnershipV2.Client is unavailable.
// NOTE: Runtime behavior is not implemented; methods may throw.

using System;
using System.Collections.Generic;

namespace Roblox.Platform.OwnershipV2.Client.Models
{
    public enum OwnershipV2OperationResult
    {
        Success = 0,
        Failure = 1
    }

    public sealed class OwnershipV2Result
    {
        public OwnershipV2OperationResult Result { get; set; } = OwnershipV2OperationResult.Success;
    }

    public sealed class Owner
    {
        public string Type { get; }
        public long TargetId { get; }
        public Owner(string type, long targetId)
        {
            Type = type;
            TargetId = targetId;
        }
    }

    public sealed class Item
    {
        public string Type { get; }
        public long TargetId { get; }
        public Item(string type, long targetId)
        {
            Type = type;
            TargetId = targetId;
        }
    }

    public sealed class OwnedItem
    {
        public Owner Owner { get; }
        public Item Item { get; }
        public string Subtype { get; }
        public DateTime? Created { get; }
        public OwnedItem(Owner owner, Item item, string subtype, DateTime? created)
        {
            Owner = owner;
            Item = item;
            Subtype = subtype;
            Created = created;
        }
    }

    public sealed class GetOwnedItemsResult
    {
        public IReadOnlyCollection<OwnedItem> OwnedItems { get; set; }
    }

    public sealed class GetResult
    {
        public OwnedItem OwnedItem { get; set; }
    }

    public sealed class GetIdResult
    {
        public long Id { get; set; }
    }
}

namespace Roblox.Platform.OwnershipV2.Client
{
    using Roblox.Platform.OwnershipV2.Client.Models;
    using Roblox.ApiClientBase;

    public enum SortOrder { Asc, Desc }

    public interface IOwnershipV2Client
    {
        OwnershipV2Result Grant(OwnedItem item);
        OwnershipV2Result Revoke(OwnedItem item);
        OwnershipV2Result Transfer(OwnedItem item, Owner newOwner);
        OwnershipV2Result Update(OwnedItem item);
        GetResult Get(Owner owner, Item item);
        GetOwnedItemsResult GetOwnedItemsByOwnerAndItemType(Owner owner, string itemType, int count, OwnedItem exclusiveStartItem, SortOrder sortOrder);
        GetOwnedItemsResult GetOwnedItemsByOwnerAndItemTypeAndSubtype(Owner owner, string itemType, string subtype, int count, OwnedItem exclusiveStartItem, SortOrder sortOrder);
        GetIdResult GetOwnedItemIdByOwnerTypeAndItem(string ownerType, Item item);
    }

    // Dummy client that returns default successes to keep code paths operational in dev.
    public sealed class OwnershipV2Client : IOwnershipV2Client
    {
        public OwnershipV2Client(Func<string> apiKeyGetter) { }

        public OwnershipV2Result Grant(OwnedItem item) => new OwnershipV2Result { Result = OwnershipV2OperationResult.Success };
        public OwnershipV2Result Revoke(OwnedItem item) => new OwnershipV2Result { Result = OwnershipV2OperationResult.Success };
        public OwnershipV2Result Transfer(OwnedItem item, Owner newOwner) => new OwnershipV2Result { Result = OwnershipV2OperationResult.Success };
        public OwnershipV2Result Update(OwnedItem item) => new OwnershipV2Result { Result = OwnershipV2OperationResult.Success };
        public GetResult Get(Owner owner, Item item) => new GetResult { OwnedItem = new OwnedItem(owner, item, subtype: null, created: DateTime.UtcNow) };
        public GetOwnedItemsResult GetOwnedItemsByOwnerAndItemType(Owner owner, string itemType, int count, OwnedItem exclusiveStartItem, SortOrder sortOrder)
            => new GetOwnedItemsResult { OwnedItems = Array.Empty<OwnedItem>() };
        public GetOwnedItemsResult GetOwnedItemsByOwnerAndItemTypeAndSubtype(Owner owner, string itemType, string subtype, int count, OwnedItem exclusiveStartItem, SortOrder sortOrder)
            => new GetOwnedItemsResult { OwnedItems = Array.Empty<OwnedItem>() };
        public GetIdResult GetOwnedItemIdByOwnerTypeAndItem(string ownerType, Item item) => new GetIdResult { Id = 0 };
    }
}
