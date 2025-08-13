using System;

namespace Roblox;

/// <summary>
/// Only respected by ExceptionHandler.
/// Throw this exception or an exception derived from this if you don't want it to show up in the Roblox Event Log.
/// </summary>
/// <remarks>
/// This should be used to return an error to the user, but something that isn't technically broken in the system.
/// For example failing validation for a control would be a good canditate as it is nothing for us to fix in the code base.
/// </remarks>
public class NotLoggedException : Exception
{
	public NotLoggedException(string reason)
		: base(reason)
	{
	}

	public NotLoggedException(string reason, Exception inner)
		: base(reason, inner)
	{
	}

	public NotLoggedException()
	{
	}
}
