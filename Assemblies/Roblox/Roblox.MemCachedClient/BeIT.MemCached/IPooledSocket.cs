using System;

namespace BeIT.MemCached;

internal interface IPooledSocket : IDisposable
{
	bool IsAlive { get; }

	string RemoteEndPoint { get; }

	DateTime Created { get; }

	event EventHandler Disposed;

	void Write(string str);

	void Write(byte[] bytes);

	string ReadLine();

	string ReadResponse();

	void Read(byte[] bytes);

	void SkipUntilEndOfLine();

	bool Reset(bool forceReset);
}
