using System.Collections.Generic;

namespace Roblox.Paging;

/// <summary>
/// A default implementation of <see cref="T:Roblox.Paging.IKeyedPagedResult`2" />
/// </summary>
public class KeyedPagedResult<TPageItem, TPageKey> : IKeyedPagedResult<TPageItem, TPageKey> where TPageKey : struct
{
	/// <inheritdoc cref="P:Roblox.Paging.IKeyedPagedResult`2.PageItems" />
	public IReadOnlyCollection<TPageItem> PageItems { get; }

	/// <inheritdoc cref="P:Roblox.Paging.IKeyedPagedResult`2.NextPageKey" />
	public PageKeyInfo<TPageKey> NextPageKey { get; }

	/// <summary>
	/// Instantiates a new <see cref="T:Roblox.Paging.KeyedPagedResult`2" /> .
	/// </summary>
	public KeyedPagedResult(IReadOnlyCollection<TPageItem> pageItems, PageKeyInfo<TPageKey> nextPageKey)
	{
		PageItems = (IReadOnlyCollection<TPageItem>)(((object)pageItems) ?? ((object)new TPageItem[0]));
		NextPageKey = nextPageKey;
	}

	/// <summary>
	/// A static factory method to return a KeyedPagedResult representing an empty result with no next page.
	/// </summary>
	public static KeyedPagedResult<TPageItem, TPageKey> EmptyLastPage()
	{
		PageKeyInfo<TPageKey> pageKey = PageKeyInfo<TPageKey>.NoPage();
		return new KeyedPagedResult<TPageItem, TPageKey>(null, pageKey);
	}
}
