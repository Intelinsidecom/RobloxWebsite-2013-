using System;

namespace BeIT.MemCached;

internal interface IServerPool : IDisposable
{
	ISocketPool[] HostList { get; }

	ISocketPool GetSocketPool(uint hash, bool useRoundRobin);

	ISocketPool GetSocketPool(string host);

	T Execute<T>(uint hash, ExecutionType executionType, Func<IPooledSocket, T> use);

	void Execute(ISocketPool socketPool, ExecutionType executionType, Action<IPooledSocket> use);
}
