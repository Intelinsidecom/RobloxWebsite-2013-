using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public class NullRemoteInvalidator : IRemoteInvalidator
{
	public static NullRemoteInvalidator Instance { get; } = new NullRemoteInvalidator();


	private NullRemoteInvalidator()
	{
	}

	public void Invalidate(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
	}

	public void MultiInvalidate(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
	}

	public Task InvalidateAsync(string key, CancellationToken cancellationToken)
	{
		NullChecker.ThrowIfNull(key, "key");
		return Task.FromResult(result: true);
	}

	public Task MultiInvalidateAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		return Task.FromResult(result: true);
	}
}
