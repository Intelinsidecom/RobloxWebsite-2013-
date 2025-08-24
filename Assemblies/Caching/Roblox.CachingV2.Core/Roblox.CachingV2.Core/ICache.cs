using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface ICache<TMetadata, TSetArgs> where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
{
	string Name { get; }

	event EventHandler<EntrySetEventArgs> EntrySet;

	event EventHandler<EntryRemovedEventArgs> EntryRemoved;

	event EventHandler<EntryRetrievalEventArgs> EntryRetrieved;

	event EventHandler<EntryMissedEventArgs> EntryMissed;

	event EventHandler<EntryQueriedEventArgs> EntryQueried;

	event EventHandler<ErrorEventArgs> Error;

	SetResult<TMetadata> Set<TValue>(SetEntry<TValue, TSetArgs> entry);

	Task<SetResult<TMetadata>> SetAsync<TValue>(SetEntry<TValue, TSetArgs> entry, CancellationToken cancellationToken);

	void Remove(string key);

	Task RemoveAsync(string key, CancellationToken cancellationToken);

	MetadataCacheGetResult<TValue, TMetadata> Get<TValue>(string key);

	Task<MetadataCacheGetResult<TValue, TMetadata>> GetAsync<TValue>(string key, CancellationToken cancellationToken);

	IEnumerable<MetadataCacheGetResult<TValue, TMetadata>> MultiGet<TValue>(IReadOnlyCollection<string> keys);

	Task<IEnumerable<MetadataCacheGetResult<TValue, TMetadata>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken);

	IEnumerable<SetResult<TMetadata>> MultiSet<TValue>(IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries);

	Task<IEnumerable<SetResult<TMetadata>>> MultiSetAsync<TValue>(IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries, CancellationToken cancellationToken);

	void MultiRemove(IReadOnlyCollection<string> keys);

	Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken);
}
