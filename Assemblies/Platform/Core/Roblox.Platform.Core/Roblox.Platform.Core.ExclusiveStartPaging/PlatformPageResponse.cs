using System;
using System.Linq;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Core.ExclusiveStartPaging;

/// <summary>
/// A model to hold information about paged results that can be returned by platform.
/// </summary>
/// <typeparam name="TExclusiveStartKey">The type of the exclusive start key.</typeparam>
/// <typeparam name="TPagedItem">The type of the paged items.</typeparam>
public class PlatformPageResponse<TExclusiveStartKey, TPagedItem> : IPlatformPageResponse<TExclusiveStartKey, TPagedItem>
{
	/// <inheritdoc cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.Count" />
	public int Count { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.Items" />
	public TPagedItem[] Items { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.SortOrder" />
	public SortOrder SortOrder { get; set; }

	internal ExclusiveStartKeyContainer<TExclusiveStartKey> PreviousPageExclusiveStartKeyContainer { get; }

	internal ExclusiveStartKeyContainer<TExclusiveStartKey> NextPageExclusiveStartKeyContainer { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> model.
	/// </summary>
	public PlatformPageResponse(TPagedItem[] originalItems, IExclusiveStartKeyInfo<TExclusiveStartKey> exclusiveStartKeyInfo, Func<TPagedItem, TExclusiveStartKey> getExclusiveStartKey, bool? hasMoreItems = null)
	{
		if (originalItems == null)
		{
			throw new PlatformArgumentNullException("originalItems");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (getExclusiveStartKey == null)
		{
			throw new PlatformArgumentNullException("getExclusiveStartKey");
		}
		Count = exclusiveStartKeyInfo.Count;
		Items = originalItems.Take(Count).ToArray();
		SortOrder = exclusiveStartKeyInfo.SortOrder;
		if (Items.Any())
		{
			ExclusiveStartKeyContainer<TExclusiveStartKey> previousPageExclusiveStartKeyContainer = null;
			ExclusiveStartKeyContainer<TExclusiveStartKey> nextPageExclusiveStartKeyContainer = null;
			if (exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var exclusiveStartKey) && exclusiveStartKey != null && !exclusiveStartKey.Equals(default(TExclusiveStartKey)))
			{
				previousPageExclusiveStartKeyContainer = new ExclusiveStartKeyContainer<TExclusiveStartKey>(getExclusiveStartKey(Items.First()));
			}
			if (originalItems.Length > Items.Length || hasMoreItems == true)
			{
				nextPageExclusiveStartKeyContainer = new ExclusiveStartKeyContainer<TExclusiveStartKey>(getExclusiveStartKey(Items.Last()));
			}
			if (exclusiveStartKeyInfo.PagingDirection.Equals(PagingDirection.Backward))
			{
				PreviousPageExclusiveStartKeyContainer = nextPageExclusiveStartKeyContainer;
				NextPageExclusiveStartKeyContainer = previousPageExclusiveStartKeyContainer;
				Items = Items.Reverse().ToArray();
			}
			else
			{
				PreviousPageExclusiveStartKeyContainer = previousPageExclusiveStartKeyContainer;
				NextPageExclusiveStartKeyContainer = nextPageExclusiveStartKeyContainer;
			}
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> model.
	/// Use it only if you know what you are doing. Created for inclusive start/prev ES paging workaround.
	/// </summary>
	public PlatformPageResponse(TPagedItem[] originalItems, IExclusiveStartKeyInfo<TExclusiveStartKey> exclusiveStartKeyInfo, ExclusiveStartKeyContainer<TExclusiveStartKey> previousKeyContainer, ExclusiveStartKeyContainer<TExclusiveStartKey> nextKeyContainer)
	{
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		Count = exclusiveStartKeyInfo.Count;
		Items = originalItems?.Take(Count).ToArray() ?? throw new PlatformArgumentNullException("originalItems");
		SortOrder = exclusiveStartKeyInfo.SortOrder;
		PreviousPageExclusiveStartKeyContainer = previousKeyContainer;
		NextPageExclusiveStartKeyContainer = nextKeyContainer;
	}

	/// <summary>
	/// Initializes a new PlatformPageResponse with specific start keys.
	/// This constructor is not meant to be public, and should only be used for converting internally.
	/// </summary>
	/// <param name="nextPageExclusiveStartKeyContainer">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.ExclusiveStartKeyContainer`1" /> for the next page start key.</param>
	/// <param name="previousPageExclusiveStartKeyContainer">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.ExclusiveStartKeyContainer`1" /> for the previous page start key.</param>
	internal PlatformPageResponse(ExclusiveStartKeyContainer<TExclusiveStartKey> nextPageExclusiveStartKeyContainer, ExclusiveStartKeyContainer<TExclusiveStartKey> previousPageExclusiveStartKeyContainer)
	{
		NextPageExclusiveStartKeyContainer = nextPageExclusiveStartKeyContainer;
		PreviousPageExclusiveStartKeyContainer = previousPageExclusiveStartKeyContainer;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.TryGetPreviousPageExclusiveStartKey(`0@)" />
	public bool TryGetPreviousPageExclusiveStartKey(out TExclusiveStartKey previousPageExclusiveStartKey)
	{
		if (PreviousPageExclusiveStartKeyContainer != null)
		{
			previousPageExclusiveStartKey = PreviousPageExclusiveStartKeyContainer.ExclusiveStartKey;
			return true;
		}
		previousPageExclusiveStartKey = default(TExclusiveStartKey);
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.TryGetNextPageExclusiveStartKey(`0@)" />
	public bool TryGetNextPageExclusiveStartKey(out TExclusiveStartKey nextPageExclusiveStartKey)
	{
		if (NextPageExclusiveStartKeyContainer != null)
		{
			nextPageExclusiveStartKey = NextPageExclusiveStartKeyContainer.ExclusiveStartKey;
			return true;
		}
		nextPageExclusiveStartKey = default(TExclusiveStartKey);
		return false;
	}
}
