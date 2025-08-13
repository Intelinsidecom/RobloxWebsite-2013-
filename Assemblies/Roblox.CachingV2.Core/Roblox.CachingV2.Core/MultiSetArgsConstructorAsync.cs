using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public delegate Task<IEnumerable<TSetArgs>> MultiSetArgsConstructorAsync<in TValue, TSetArgs>(IReadOnlyCollection<TValue> values, CancellationToken cancellationToken) where TSetArgs : BasicSetArgs;
