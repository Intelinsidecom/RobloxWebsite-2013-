using System;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerPermissionGroupException : Exception
{
	public PrivateServerPermissionGroupException(string message)
		: base(message)
	{
	}

	public PrivateServerPermissionGroupException(string message, Exception inner)
		: base(message, inner)
	{
	}
}
