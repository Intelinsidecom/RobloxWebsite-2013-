using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public delegate Task SourceDeleterAsync(CancellationToken cancellationToken);
