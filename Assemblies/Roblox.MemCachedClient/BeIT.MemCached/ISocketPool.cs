using System;
using Roblox.Sentinels;

namespace BeIT.MemCached;

internal interface ISocketPool : IDisposable
{
	long PoolSize { get; }

	int OwnedSocketCount { get; }

	string Host { get; }

	ThresholdExecutionCircuitBreaker ExecutionCircuitBreaker { get; }

	IPooledSocket Acquire();

	void Return(IPooledSocket pooledSocket, bool forceReset);
}
