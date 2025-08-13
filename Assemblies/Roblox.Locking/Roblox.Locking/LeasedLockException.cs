using System;

namespace Roblox.Locking;

public class LeasedLockException : Exception
{
	private const string _StandardMessage = "Unable to acquire Leased Lock";

	public LeasedLockException()
		: base("Unable to acquire Leased Lock")
	{
	}

	public LeasedLockException(string message)
		: base(message)
	{
	}

	public LeasedLockException(Exception inner)
		: base("Unable to acquire Leased Lock", inner)
	{
	}

	public LeasedLockException(string message, Exception inner)
		: base(message, inner)
	{
	}
}
