using System;
using System.Collections.Generic;

namespace Roblox.OwnershipV2.Client.Models
{
    public enum OwnershipV2OperationResult
    {
        Success = 0,
        Failure = 1
    }

    public sealed class OwnershipV2Result
    {
        public OwnershipV2OperationResult Result { get; set; } = OwnershipV2OperationResult.Success;
        public string Message { get; set; }
        public static OwnershipV2Result Ok() => new OwnershipV2Result { Result = OwnershipV2OperationResult.Success };
        public static OwnershipV2Result Fail(string message = null) => new OwnershipV2Result { Result = OwnershipV2OperationResult.Failure, Message = message };
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

