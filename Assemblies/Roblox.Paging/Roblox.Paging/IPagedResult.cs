using System.Collections.Generic;

namespace Roblox.Paging;

/// <summary>
/// A interface that represents a page of results that supports count of items in the page.
/// </summary>
/// <typeparam name="TCount">The type of the result count in a page</typeparam>
/// <typeparam name="TPageItem">The type of item being returned in the page result.</typeparam>
public interface IPagedResult<TCount, TPageItem>
{
	/// <summary>
	/// Number of items in the resulting page
	/// </summary>
	TCount Count { get; set; }

	/// <summary>
	/// The items in the resulting page
	/// </summary>
	IEnumerable<TPageItem> PageItems { get; set; }
}
/// <summary>
/// A interface that represents a page of results that supports count of items in the page, as well as count of total pages.
/// </summary>
/// <typeparam name="TCount">The type of the result count in a page</typeparam>
/// <typeparam name="TPageItem">The type of item being returned in the page result.</typeparam>
/// <typeparam name="TPageCount">The type of the page count</typeparam>
public interface IPagedResult<TCount, TPageCount, TPageItem> : IPagedResult<TCount, TPageItem>
{
	/// <summary>
	/// Total number of pages available
	/// </summary>
	TPageCount PageCount { get; set; }
}
