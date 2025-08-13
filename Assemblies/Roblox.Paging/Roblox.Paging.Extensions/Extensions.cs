namespace Roblox.Paging.Extensions;

public static class Extensions
{
	/// <summary>
	/// Converts the PageKey type from the original numeric type to long
	/// </summary>
	public static PageKeyInfo<long> ToLongKey(this PageKeyInfo<int> pageKeyInfo)
	{
		if (!pageKeyInfo.HasPage)
		{
			return PageKeyInfo<long>.NoPage();
		}
		return new PageKeyInfo<long>(pageKeyInfo.PageKey);
	}

	/// <summary>
	/// Converts the PageKey type from the original numeric type to long
	/// </summary>
	public static KeyedPagedResult<TPageItem, long> ToLongKey<TPageItem>(this IKeyedPagedResult<TPageItem, int> pagedResult)
	{
		return new KeyedPagedResult<TPageItem, long>(pagedResult.PageItems, pagedResult.NextPageKey.ToLongKey());
	}
}
