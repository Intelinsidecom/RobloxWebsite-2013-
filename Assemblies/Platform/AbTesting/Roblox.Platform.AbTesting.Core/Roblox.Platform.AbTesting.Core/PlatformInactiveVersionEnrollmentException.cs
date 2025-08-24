using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// The exception that is thrown when an enrollment failed because the experiment had no active, enrolling versions.
/// </summary>
public class PlatformInactiveVersionEnrollmentException : PlatformInvalidOperationException
{
	public PlatformInactiveVersionEnrollmentException()
	{
	}

	public PlatformInactiveVersionEnrollmentException(string message)
		: base(message)
	{
	}

	public PlatformInactiveVersionEnrollmentException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
