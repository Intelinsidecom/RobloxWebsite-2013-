using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

public delegate Task DatabaseMultiActionAsync(IDatabase database, IReadOnlyCollection<string> keys, CancellationToken cancellationToken);
public delegate Task<IEnumerable<TResult>> DatabaseMultiActionAsync<TResult>(IDatabase database, IReadOnlyCollection<string> keys, CancellationToken cancellationToken);
