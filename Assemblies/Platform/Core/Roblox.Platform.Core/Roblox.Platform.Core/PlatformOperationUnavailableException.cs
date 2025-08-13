using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Exception thrown when a platform operation is not currently available at no fault of the caller, but may be available later.
/// </summary>
public class PlatformOperationUnavailableException : PlatformException
{
	public PlatformOperationUnavailableException()
	{
	}

	public PlatformOperationUnavailableException(string message)
		: base(message)
	{
	}

	public PlatformOperationUnavailableException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
