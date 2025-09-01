// Temporary stub for Roblox.ApiClientBase to unblock build.
using System.Collections.Generic;

namespace Roblox.ApiClientBase
{
    public class PagedResult<TId, TItem>
    {
        public int Page { get; }
        public int Count { get; }
        public IReadOnlyList<TItem> PageItems { get; }

        public PagedResult(int page, int count, IReadOnlyList<TItem> pageItems)
        {
            Page = page;
            Count = count;
            PageItems = pageItems ?? new List<TItem>();
        }
    }
}
