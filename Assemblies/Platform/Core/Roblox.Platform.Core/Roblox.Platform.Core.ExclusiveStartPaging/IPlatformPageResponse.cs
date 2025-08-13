using Roblox.DataV2.Core;

namespace Roblox.Platform.Core.ExclusiveStartPaging;

/// <summary>
/// A model to hold information about paged results that can be returned by platform.
/// </summary>
/// <typeparam name="TExclusiveStartKey">The type of the exclusive start key.</typeparam>
/// <typeparam name="TPagedItem">The type of the paged items.</typeparam>
public interface IPlatformPageResponse<TExclusiveStartKey, TPagedItem>
{
	/// <summary>
	/// The max expected results.
	/// </summary>
	int Count { get; set; }

	/// <summary>
	/// The array of <typeparamref name="TPagedItem" /> results.
	/// </summary>
	TPagedItem[] Items { get; set; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.SortOrder" /> of the <see cref="P:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2.Items" />
	/// </summary>
	SortOrder SortOrder { get; set; }

	/// <summary>
	/// Tries to get previous page exclusive start key.
	/// </summary>
	/// <param name="previousPageExclusiveStartKey">The previous page exclusive start key <typeparamref name="TExclusiveStartKey" />.</param>
	/// <returns>True if ExclusiveStartKey specified, otherwise false</returns>
	bool TryGetPreviousPageExclusiveStartKey(out TExclusiveStartKey previousPageExclusiveStartKey);

	/// <summary>
	/// Tries to get previous page exclusive start key.
	/// </summary>
	/// <param name="nextPageExclusiveStartKey">The next page exclusive start key <typeparamref name="TExclusiveStartKey" />.</param>
	/// <returns>True if ExclusiveStartKey specified, otherwise false</returns>
	bool TryGetNextPageExclusiveStartKey(out TExclusiveStartKey nextPageExclusiveStartKey);
}
