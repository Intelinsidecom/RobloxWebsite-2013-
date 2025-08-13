using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception thrown when a subject's enrollment is declined.
/// </summary>
public class PlatformEnrollmentDeclinationException : PlatformException
{
	public PlatformEnrollmentDeclinationException()
	{
	}

	public PlatformEnrollmentDeclinationException(string message)
		: base(message)
	{
	}

	public PlatformEnrollmentDeclinationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
