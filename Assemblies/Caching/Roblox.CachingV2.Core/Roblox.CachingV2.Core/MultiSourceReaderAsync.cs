using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public delegate Task<IEnumerable<TValue>> MultiSourceReaderAsync<TValue, in TKey>(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken);
