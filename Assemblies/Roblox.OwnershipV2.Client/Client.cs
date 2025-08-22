using System;
using System.Collections.Generic;
using Roblox.OwnershipV2.Client.Models;
using Roblox.DataV2.Core;

namespace Roblox.OwnershipV2.Client
{
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

    // Minimal behavior: keep an in-memory set per process so tests/dev have deterministic behavior
    public sealed class OwnershipV2Client : IOwnershipV2Client
    {
        private readonly HashSet<string> _owned = new HashSet<string>(StringComparer.Ordinal);
        public OwnershipV2Client(Func<string> apiKeyGetter) { _ = apiKeyGetter; }

        private static string Key(Owner o, Item i) => $"{o?.Type}:{o?.TargetId}|{i?.Type}:{i?.TargetId}";

        public OwnershipV2Result Grant(OwnedItem item)
        {
            if (item == null) return OwnershipV2Result.Fail("null item");
            _owned.Add(Key(item.Owner, item.Item));
            return OwnershipV2Result.Ok();
        }

        public OwnershipV2Result Revoke(OwnedItem item)
        {
            if (item == null) return OwnershipV2Result.Fail("null item");
            _owned.Remove(Key(item.Owner, item.Item));
            return OwnershipV2Result.Ok();
        }

        public OwnershipV2Result Transfer(OwnedItem item, Owner newOwner)
        {
            if (item == null || newOwner == null) return OwnershipV2Result.Fail("null args");
            _owned.Remove(Key(item.Owner, item.Item));
            var moved = new OwnedItem(newOwner, item.Item, item.Subtype, item.Created);
            _owned.Add(Key(moved.Owner, moved.Item));
            return OwnershipV2Result.Ok();
        }

        public OwnershipV2Result Update(OwnedItem item)
        {
            // No state besides presence; treat as success
            return item == null ? OwnershipV2Result.Fail("null item") : OwnershipV2Result.Ok();
        }

        public GetResult Get(Owner owner, Item item)
        {
            var exists = _owned.Contains(Key(owner, item));
            return new GetResult { OwnedItem = exists ? new OwnedItem(owner, item, null, DateTime.UtcNow) : null };
        }

        public GetOwnedItemsResult GetOwnedItemsByOwnerAndItemType(Owner owner, string itemType, int count, OwnedItem exclusiveStartItem, SortOrder sortOrder)
            => new GetOwnedItemsResult { OwnedItems = Array.Empty<OwnedItem>() };

        public GetOwnedItemsResult GetOwnedItemsByOwnerAndItemTypeAndSubtype(Owner owner, string itemType, string subtype, int count, OwnedItem exclusiveStartItem, SortOrder sortOrder)
            => new GetOwnedItemsResult { OwnedItems = Array.Empty<OwnedItem>() };

        public GetIdResult GetOwnedItemIdByOwnerTypeAndItem(string ownerType, Item item)
        {
            // Not tracking ids; return 0 to indicate not found
            return new GetIdResult { Id = 0 };
        }
    }
}
