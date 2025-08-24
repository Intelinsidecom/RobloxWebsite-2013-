using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IRawCache
{
	void Set<TValue>(RawSetEntry<TValue> entry);

	Task SetAsync<TValue>(RawSetEntry<TValue> entry, CancellationToken cancellationToken);

	void Remove(string key);

	Task RemoveAsync(string key, CancellationToken cancellationToken);

	CacheGetResult<TValue> Get<TValue>(string key);

	Task<CacheGetResult<TValue>> GetAsync<TValue>(string key, CancellationToken cancellationToken);

	IEnumerable<CacheGetResult<TValue>> MultiGet<TValue>(IReadOnlyCollection<string> keys);

	Task<IEnumerable<CacheGetResult<TValue>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken);

	void MultiSet<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries);

	Task MultiSetAsync<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries, CancellationToken cancellationToken);

	void MultiRemove(IReadOnlyCollection<string> keys);

	Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken);
}
