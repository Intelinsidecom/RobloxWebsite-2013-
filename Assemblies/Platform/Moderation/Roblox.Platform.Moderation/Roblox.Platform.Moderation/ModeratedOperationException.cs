using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Moderation;

/// <summary>
/// The exception thrown when an operation failed due to moderation.
/// </summary>
public class ModeratedOperationException : PlatformInvalidOperationException
{
	public ModeratedOperationException()
	{
	}

	public ModeratedOperationException(string message)
		: base(message)
	{
	}

	public ModeratedOperationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
