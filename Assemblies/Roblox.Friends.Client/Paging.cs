// Temporary minimal implementation to unblock build; replace with real Roblox.Paging when available.
namespace Roblox.Paging
{
    public class ExclusiveStartInfo<T>
    {
        public T ExclusiveStartKey { get; set; }
        public int? Limit { get; set; }
    }
}
