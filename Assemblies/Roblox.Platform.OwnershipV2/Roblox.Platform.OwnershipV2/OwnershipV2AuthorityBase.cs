using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;
using Roblox.DataV2.Core;
using Roblox.OwnershipV2.Client;
using Roblox.OwnershipV2.Client.Models;
using Roblox.Platform.Core;

namespace Roblox.Platform.OwnershipV2;

public abstract class OwnershipV2AuthorityBase<TOwner, TItem>
{
	private static readonly IReadOnlyCollection<TItem> _EmptyGetResponse = (IReadOnlyCollection<TItem>)(object)new TItem[0];

	private readonly IOwnershipV2Client _Client;

	protected OwnershipV2AuthorityBase(IOwnershipV2Client client)
	{
		_Client = client ?? throw new PlatformArgumentNullException("client");
	}

	protected OwnershipV2Result Grant(TOwner owner, TItem item)
	{
		OwnedItem ownedItem = BuildOwnedItem(owner, item);
		return _Client.Grant(ownedItem);
	}

	protected OwnershipV2Result Revoke(TOwner owner, TItem item)
	{
		OwnedItem ownedItem = BuildOwnedItem(owner, item);
		return _Client.Revoke(ownedItem);
	}

	protected OwnershipV2Result Transfer(TOwner owner, TItem item, TOwner newOwner)
	{
		OwnedItem ownedItem = BuildOwnedItem(owner, item);
		return _Client.Transfer(ownedItem, BuildOwner(newOwner));
	}

	protected OwnershipV2Result Update(TOwner owner, TItem item)
	{
		OwnedItem ownedItem = BuildOwnedItem(owner, item);
		return _Client.Update(ownedItem);
	}

	protected GetResult Get(TOwner owner, TItem item)
	{
		Owner clientOwner = BuildOwner(owner);
		Item clientItem = BuildItem(item);
		return _Client.Get(clientOwner, clientItem);
	}

	protected IReadOnlyCollection<TItem> GetItemsByOwnerAndItemType(TOwner owner, string itemType, int count, TItem exclusiveStartItem, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		OwnedItem exclusiveStartOwnedItem = ((exclusiveStartItem == null) ? null : BuildOwnedItem(owner, exclusiveStartItem));
		Roblox.ApiClientBase.SortOrder clientSortOrder = ((sortOrder != Roblox.DataV2.Core.SortOrder.Desc) ? Roblox.ApiClientBase.SortOrder.Asc : Roblox.ApiClientBase.SortOrder.Desc);
		Owner builtOwner = BuildOwner(owner);
		GetOwnedItemsResult result = _Client.GetOwnedItemsByOwnerAndItemType(builtOwner, itemType, count, exclusiveStartOwnedItem, clientSortOrder);
		return Translate(result);
	}

	protected IReadOnlyCollection<TItem> GetItemsByOwnerAndTypeAndSubtype(TOwner owner, string itemType, string subtype, int count, TItem exclusiveStartItem, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		OwnedItem exclusiveStartOwnedItem = ((exclusiveStartItem == null) ? null : BuildOwnedItem(owner, exclusiveStartItem));
		Roblox.ApiClientBase.SortOrder clientSortOrder = ((sortOrder != Roblox.DataV2.Core.SortOrder.Desc) ? Roblox.ApiClientBase.SortOrder.Asc : Roblox.ApiClientBase.SortOrder.Desc);
		Owner builtOwner = BuildOwner(owner);
		GetOwnedItemsResult result = _Client.GetOwnedItemsByOwnerAndItemTypeAndSubtype(builtOwner, itemType, subtype, count, exclusiveStartOwnedItem, clientSortOrder);
		return Translate(result);
	}

	protected GetIdResult GetByOwnerTypeAndItem(string ownerType, Item item)
	{
		return _Client.GetOwnedItemIdByOwnerTypeAndItem(ownerType, item);
	}

	protected abstract Owner BuildOwner(TOwner owner);

	protected abstract Item BuildItem(TItem item);

	protected abstract string BuildSubtype(TOwner owner, TItem item);

	protected abstract DateTime? BuildExpiration(TOwner owner, TItem item);

	protected abstract TItem Translate(OwnedItem ownedItem);

	protected abstract IReadOnlyCollection<TItem> Translate(IReadOnlyCollection<OwnedItem> ownedItems);

	protected virtual IReadOnlyCollection<TItem> Translate(GetOwnedItemsResult result)
	{
		if (((result != null) ? result.OwnedItems : null) == null)
		{
			return _EmptyGetResponse;
		}
		return Translate(result.OwnedItems);
	}

	protected virtual OwnedItem BuildOwnedItem(TOwner owner, TItem item)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if (owner == null)
		{
			throw new PlatformArgumentNullException("owner");
		}
		if (item == null)
		{
			throw new PlatformArgumentNullException("item");
		}
		return new OwnedItem(BuildOwner(owner), BuildItem(item), BuildSubtype(owner, item), BuildExpiration(owner, item));
	}
}
