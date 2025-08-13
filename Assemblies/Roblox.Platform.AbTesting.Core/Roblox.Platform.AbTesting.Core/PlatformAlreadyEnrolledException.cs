using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception that is thrown when an enrollment failed because the subject was already enrolled in the experiment.
/// </summary>
public class PlatformAlreadyEnrolledException : PlatformInvalidOperationException
{
	public PlatformAlreadyEnrolledException()
	{
	}

	public PlatformAlreadyEnrolledException(string message)
		: base(message)
	{
	}

	public PlatformAlreadyEnrolledException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
