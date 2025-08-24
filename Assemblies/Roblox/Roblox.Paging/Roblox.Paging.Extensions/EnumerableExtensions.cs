using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Paging.Extensions;

/// <summary>
/// Paging extensions for IEnumerables
/// </summary>
public static class EnumerableExtensions
{
	/// <summary>
	/// Produces a Keyed Page Result from a collection of items by skipping and taking.
	/// </summary>
	public static KeyedPagedResult<TPageItem, int> PageBySkipTake<TPageItem>(this ICollection<TPageItem> items, int skip, int take)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		int count = items.Count;
		TPageItem[] itemsInPage = items.Skip(skip).Take(take).ToArray();
		PageKeyInfo<int> nextStartKey = ((count < skip + take) ? PageKeyInfo<int>.NoPage() : new PageKeyInfo<int>(skip + take));
		return new KeyedPagedResult<TPageItem, int>((IReadOnlyCollection<TPageItem>)(object)itemsInPage, nextStartKey);
	}

	/// <summary>
	/// Produces a Keyed Page Result from a enumerable of items by skipping and taking.
	/// </summary>
	public static KeyedPagedResult<TPageItem, int> PageBySkipTake<TPageItem>(this IEnumerable<TPageItem> items, int skip, int take)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		TPageItem[] array = items.Skip(skip).Take(take).ToArray();
		PageKeyInfo<int> nextStartKey = ((array.Length < take) ? PageKeyInfo<int>.NoPage() : new PageKeyInfo<int>(skip + take));
		return new KeyedPagedResult<TPageItem, int>((IReadOnlyCollection<TPageItem>)(object)array, nextStartKey);
	}
}
