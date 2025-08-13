using System.Threading;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

public delegate Task DatabaseActionAsync(IDatabase database, CancellationToken cancellationToken = default(CancellationToken));
public delegate Task<TResult> DatabaseActionAsync<TResult>(IDatabase database, CancellationToken cancellationToken = default(CancellationToken));
