using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;

namespace Roblox.CachingV2.Core;

public delegate Task<GetOrCreateResult<TValue>> SourceReaderOrCreatorAsync<TValue>(CancellationToken cancellationToken);
