using System;
using System.Linq;

namespace Roblox.Platform.Core.ExclusiveStartPaging;

public static class PlatformPageResponseExtensions
{
	/// <summary>
	/// Converts items in a <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /> from <typeparamref name="TPagedItem" />
	/// to <typeparamref name="TNewPagedItem" /> in a new <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" />.
	/// </summary>
	/// <typeparam name="TExclusiveStartKey">The exclusive start key type.</typeparam>
	/// <typeparam name="TPagedItem">The original type of the items.</typeparam>
	/// <typeparam name="TNewPagedItem">The new type of the paged items.</typeparam>
	/// <param name="platformPageResponse">The original <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" />.</param>
	/// <param name="convertFunc">The convert function.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /></returns>
	public static IPlatformPageResponse<TExclusiveStartKey, TNewPagedItem> Convert<TExclusiveStartKey, TPagedItem, TNewPagedItem>(this IPlatformPageResponse<TExclusiveStartKey, TPagedItem> platformPageResponse, Func<TPagedItem, TNewPagedItem> convertFunc)
	{
		TExclusiveStartKey nextPageExclusiveStartKey;
		ExclusiveStartKeyContainer<TExclusiveStartKey> nextPageExclusiveStartKeyContainer = (platformPageResponse.TryGetNextPageExclusiveStartKey(out nextPageExclusiveStartKey) ? new ExclusiveStartKeyContainer<TExclusiveStartKey>(nextPageExclusiveStartKey) : null);
		TExclusiveStartKey previousPageExclusiveStartKey;
		ExclusiveStartKeyContainer<TExclusiveStartKey> previousPageContainer = (platformPageResponse.TryGetPreviousPageExclusiveStartKey(out previousPageExclusiveStartKey) ? new ExclusiveStartKeyContainer<TExclusiveStartKey>(previousPageExclusiveStartKey) : null);
		return new PlatformPageResponse<TExclusiveStartKey, TNewPagedItem>(nextPageExclusiveStartKeyContainer, previousPageContainer)
		{
			Count = platformPageResponse.Count,
			Items = platformPageResponse.Items.Select(convertFunc).ToArray(),
			SortOrder = platformPageResponse.SortOrder
		};
	}
}
