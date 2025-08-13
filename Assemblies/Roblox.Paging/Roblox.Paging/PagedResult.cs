using System.Collections.Generic;

namespace Roblox.Paging;

public class PagedResult<TCount, TPageItem> : IPagedResult<TCount, TPageItem>
{
	public TCount Count { get; set; }

	public IEnumerable<TPageItem> PageItems { get; set; }
}
public class PagedResult<TCount, TPageCount, TPageItem> : IPagedResult<TCount, TPageCount, TPageItem>, IPagedResult<TCount, TPageItem>
{
	public TCount Count { get; set; }

	public TPageCount PageCount { get; set; }

	public IEnumerable<TPageItem> PageItems { get; set; }
}
