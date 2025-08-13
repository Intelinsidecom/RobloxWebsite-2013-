using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public delegate Task<TSetArgs> SetArgsConstructorAsync<in TValue, TSetArgs>(TValue value, CancellationToken cancellationToken) where TSetArgs : BasicSetArgs;
