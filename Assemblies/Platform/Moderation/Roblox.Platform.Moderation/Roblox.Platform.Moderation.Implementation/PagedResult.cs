using System;
using System.Collections.Generic;

namespace Roblox.Platform.Moderation.Implementation;

public class PagedResult<TPageItem>
{
	private int _PageSize = 100;

	public long TotalPages { get; private set; }

	public IEnumerable<TPageItem> PageItems { get; private set; }

	public PagedResult(long totalItems, IEnumerable<TPageItem> pageItems)
	{
		PageItems = pageItems;
		TotalPages = Math.Max(1L, (long)Math.Ceiling((double)totalItems / (double)_PageSize));
	}
}
