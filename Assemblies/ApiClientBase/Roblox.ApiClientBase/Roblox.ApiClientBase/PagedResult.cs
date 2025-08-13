using System.Collections.Generic;

namespace Roblox.ApiClientBase;

public class PagedResult<TCount, TPageItem>
{
	public TCount Count { get; set; }

	public IEnumerable<TPageItem> PageItems { get; set; }
}
