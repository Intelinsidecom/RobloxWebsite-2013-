using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IRemoteInvalidator
{
	void Invalidate(string key);

	void MultiInvalidate(IReadOnlyCollection<string> keys);

	Task InvalidateAsync(string key, CancellationToken cancellationToken);

	Task MultiInvalidateAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken);
}
